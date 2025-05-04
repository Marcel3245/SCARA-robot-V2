void stopMotor(char formattedData[][20]) {
  if (strcmp(formattedData[0], "STOPALL") == 0) {
    for (int i=0; i < 4; i++){
      stepper[i]->setSpeed(0);
      stepper[i]->stop();
    }
    myServo.write(myServo.read());
    if (testMode) {
      Serial.println("All motors stoped");
    }
  } else {
    MoToStepper* selectedMotor;
    if (strcmp(formattedData[1], "M1") == 0) {
      selectedMotor = stepper[0];
    } else if (strcmp(formattedData[1], "M2") == 0) {
      selectedMotor = stepper[1];
    } else if (strcmp(formattedData[1], "M3") == 0) {
      selectedMotor = stepper[2];
    } else if (strcmp(formattedData[1], "M4") == 0) {
      selectedMotor = stepper[3];
    } else if (strcmp(formattedData[1], "G5") == 0) { 
      myServo.write(myServo.read());
      if (testMode) {
        Serial.println("Gripper stopped");
      }
      return; 
    }

    if (selectedMotor) {
        selectedMotor->setSpeed(0);
        selectedMotor->stop();

        if (testMode) {
          Serial.print("Motor: ");
          Serial.print(formattedData[1]);
          Serial.println(" stopped");
      }
    }
  }
}