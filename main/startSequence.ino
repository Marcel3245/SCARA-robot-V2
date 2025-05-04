void startSequence(char data[][20]) {
    bool endSequence = false;
    int rowIndex = 0;
    float path[7][10];

    while (!endSequence) {
        int dataIndex = 0;
        if (Serial.available() > 0) {
            String command = Serial.readStringUntil('\n');
            command.toCharArray(receivedCommand, sizeof(receivedCommand));

            parsedToken = strtok(receivedCommand, ";");
            while (parsedToken != NULL && dataIndex < 10) {
                strncpy(formattedData[dataIndex], parsedToken, sizeof(formattedData[dataIndex]) - 1);
                formattedData[dataIndex][sizeof(formattedData[dataIndex]) - 1] = '\0';
                dataIndex++;
                parsedToken = strtok(NULL, ";");
            }

            if (strcmp(formattedData[0], "EndS") == 0) {
                endSequence = true;
                continue;
            }

            if (strcmp(formattedData[0], "PV") == 0) {
                for (int i = 1; i < dataIndex; i++) {
                    String temp = formattedData[i];
                    temp.replace(',', '.');
                    strncpy(formattedData[i - 1], temp.c_str(), sizeof(formattedData[i - 1]) - 1);
                    formattedData[i - 1][sizeof(formattedData[i - 1]) - 1] = '\0';
                }

                for (int i = 0; i < dataIndex - 1; i++) {
                    path[rowIndex][i] = atof(formattedData[i]);
                }

                rowIndex++;
            }
        }
    }
    pathExecute(path, rowIndex);
}

void pathExecute(float formattedPath[][10], int numOfRows) {
    float rpm;
    float rampLen;

    for (int i = 0; i < numOfRows; i++) {
        positions[0] = formattedPath[i][0] * 25 / stepResolut;
        positions[1] = formattedPath[i][1] * stepsHeightZ / heightZ;
        positions[2] = formattedPath[i][2] * 9 / stepResolut;
        positions[3] = formattedPath[i][3] * 3 / stepResolut;
        positions[4] = (formattedPath[i][4] + 46)*41/30;

        if (formattedPath[i][4] <= 23) {
          positions[4] = 92;
        }

        rpm = formattedPath[i][5];
        rampLen = formattedPath[i][6];

        for (int k = 0; k < 5; k++) {
          if (k == 4){
            myServo.write(positions[4]);
          } else {
            stepper[k]->setSpeed(rpm);
            stepper[k]->setRampLen(rampLen);
            stepper[k]->writeSteps(positions[k]);
          }
        }

        delay(500);
        bool motorsMoving = true;
        while (motorsMoving) {
            motorsMoving = stepper[0]->getSpeedSteps() != 0 ||
                           stepper[1]->getSpeedSteps() != 0 ||
                           stepper[2]->getSpeedSteps() != 0 ||
                           stepper[3]->getSpeedSteps() != 0 ||
                           myServo.moving() != 0;
            checkLimitSwitches();
        }
      delay(500);
    }
}