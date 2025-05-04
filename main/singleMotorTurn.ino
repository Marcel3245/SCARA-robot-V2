void singleMotorControlTurn(char formattedData[10][20]) {   
  float rpm = atof(formattedData[3]);  
  direction = (strcmp(formattedData[2], "L") == 0) ? -1 : 1;  
  float rampLen = atof(formattedData[4]);  

  MoToStepper* selectedMotor = nullptr;  

  if (strcmp(formattedData[1], "M1") == 0) { selectedMotor = stepper[0]; }  
  else if (strcmp(formattedData[1], "M2") == 0) { selectedMotor = stepper[1]; }  
  else if (strcmp(formattedData[1], "M3") == 0) { selectedMotor = stepper[2]; }  
  else if (strcmp(formattedData[1], "M4") == 0) { selectedMotor = stepper[3]; } 
  else if (strcmp(formattedData[1], "Gr") == 0) {
    selectedMotor = nullptr;
    if (strcmp(formattedData[2], "O") == 0){
      myServo.write(135);
      return;
    } else if (strcmp(formattedData[2], "C") == 0){
      myServo.write(94);
      return;
    }
  }  
  else {  
      Serial.print("Unknown motor identifier: ");  
      Serial.println(formattedData[1]);  
      return;  
  }  

  if (selectedMotor->getSpeedSteps() != 0) {  
      Serial.println("Already in use!");  
      return;  
  }  

  selectedMotor->setSpeed(rpm);  
  selectedMotor->setRampLen(rampLen);  
  selectedMotor->rotate(direction);  
  
  if (testMode) {  
      Serial.print("Rotate motor: ");  
      Serial.print(formattedData[1]);  
      Serial.print("; Direction: ");  
      Serial.print(formattedData[2]);  
      Serial.print("; Velocity: ");  
      Serial.print(formattedData[3]);  
      Serial.print("; Acceleration: ");  
      Serial.print(formattedData[4]);  
      Serial.println();  
  }  
}