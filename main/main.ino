#include <MobaTools.h>

// Constantly update the angles of joints in DEGREES 
float jointAngle1 = 0, jointAngle2 = 0, jointAngle3 = 0, jointAngle4 = 0, flangeWidth = 0;

// Limit switches
const int limitSwitches[4] = {A2, 10, 11, A3}; // Pin numbers for limit switches
int direction;

// Process message
char receivedCommand[100];  // Buffer size to hold incoming data
char *parsedToken = NULL;
char formattedData[10][20];  // Array to hold split data pieces

bool testMode = false;

const byte stepPin[4] = {2, 3, 4, 12};
const byte dirPin[4]  = {5, 6, 7, 13};

const int stepsPerRev = 200; // Microstepping Full
const float stepResolut = 0.1125; // Degrees - Microstepping Full(1.8); Half(0.9); 1/4(0.45); 1/8(0.225); 1/16(0.1125)

MoToStepper *stepper[4];
MoToServo myServo;  // Servo object to control a servo

int heightZ = 175;  // Measure by operator during assembly [mm]
int stepsHeightZ = 5194; // Automatic check

long positions[5]; 

void setup() {
  Serial.begin(9600);
  pinMode(limitSwitches[0], INPUT_PULLUP);
  pinMode(limitSwitches[1], INPUT_PULLUP);
  pinMode(limitSwitches[2], INPUT_PULLUP);
  pinMode(limitSwitches[3], INPUT_PULLUP);

  stepper[0] = new MoToStepper(360/stepResolut * 25, STEPDIR);
  stepper[1] = new MoToStepper(360/stepResolut, STEPDIR);
  stepper[2] = new MoToStepper(360/stepResolut * 9, STEPDIR);
  stepper[3] = new MoToStepper(360/stepResolut * 3, STEPDIR);

  myServo.attach(8);  
  myServo.setSpeedTime(4500); // In 3s servo will make 180°
  myServo.write(135);

  for (byte i = 0; i < 4; i++){
    stepper[i]->attach(stepPin[i], dirPin[i]);
  }
}

void loop() {
    // Always pay attention to limit switches
    checkLimitSwitches();

    // Handle incoming serial commands
    if (Serial.available() > 0) {
        memset(receivedCommand, 0, sizeof(receivedCommand));
        memset(formattedData, 0, sizeof(formattedData));

        String command = Serial.readStringUntil('\n'); // Read the incoming command
        command.trim();  // Remove unwanted whitespace/newlines

        if (testMode && command != "ARQ") {
            Serial.println(command);
        }

        if (command == "ARQ") {
            angleUpdate();
        } else if (command == "HOMEQ") {
            homecoming();
        } else if (command == "DebugMode") {
            testMode = !testMode;
        } else {
            int dataIndex = 0;
            command.toCharArray(receivedCommand, sizeof(receivedCommand));
            char *parsedToken = strtok(receivedCommand, ";");

            while (parsedToken != NULL && dataIndex < 10) {
                strncpy(formattedData[dataIndex], parsedToken, sizeof(formattedData[dataIndex]) - 1);
                formattedData[dataIndex][sizeof(formattedData[dataIndex]) - 1] = '\0'; // Null-terminate
                dataIndex++;
                parsedToken = strtok(NULL, ";");
            }

            if (strcmp(formattedData[0], "STOP") == 0 || strcmp(formattedData[0], "STOPALL") == 0) {
                stopMotor(formattedData);
            } else if (strcmp(formattedData[0], "MCT") == 0) {
                singleMotorControlTurn(formattedData);
            } else if (strcmp(formattedData[0], "MOVE") == 0) {
                goToCoords(formattedData);
            } else if (strcmp(formattedData[0], "StartS") == 0) {
                startSequence(formattedData);
            } else {
                if (testMode) {
                    Serial.print("Unknown command: ");
                    Serial.println(formattedData[0]);
                }
            }
        }
    }

    // Constantly update the angles of the joints in reference to starting position after homecoming
    jointAngle1 = stepper[0]->readSteps() * 1 / 25 * stepResolut; 
    jointAngle2 = stepper[1]->readSteps() * heightZ / stepsHeightZ; 
    jointAngle3 = stepper[2]->readSteps() * 1 / 9 * stepResolut; 
    jointAngle4 = stepper[3]->readSteps() * 1 / 3 * stepResolut; 
    flangeWidth = myServo.read()*30/41 - 46;
    delay(20);
}

void checkLimitSwitches() {
  for (int sw = 0; sw < 4; sw++) {
    if (digitalRead(limitSwitches[sw]) == 0) {
        stepper[sw]->setSpeed(0);
        stepper[sw]->stop(); // Stop the motor immediately
        delay(100);

        stepper[sw]->setSpeed(150);
        stepper[sw]->move(-150 * direction);

        if(testMode){
          Serial.print(sw + 1);
          Serial.println(". Button was pressed");
        }
    }
  }
}


// MCT - Motor Control Turn "To control each motor Left/Right"                        [MCT;M1;L;100;50]
// STOP - "To stop given motor"                                                       [STOP;M1]
// STOPALL - "To stop all the motors                                                  [STOPALL]
// ARQ - Automatic Repeat reQuest "Ask Arduino to get angle values of the motors "    [ARQ]
// ARA - Automatic Repeat Answer "Respond of the Arduino with the angles"             [A1; A2; Height; A3; AG] 
//                                                                                    [MOVE;0;140;0;0;0;0;0]


// StartS
// PV;11,11;22,22;33,33;44,44;55,55;66,66;77,77
// PV;9,11;9,22;9,33;9,44;9,55;9,66;9,77
// EndS