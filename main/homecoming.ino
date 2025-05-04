void homecoming() {
  Serial.println("Stepper is Homing . . . . . . . . . . . ");

  int workSpace;
  bool state = true; 
  
  myServo.write(135);

  for (int i = 3; i > -1; i--) {
    stepper[i]->setSpeed(90);
    stepper[i]->setRampLen(40);

    while (state) { 
      stepper[i]->rotate(1); 

      // Check limit switch state
      if (digitalRead(limitSwitches[i]) == 0) {
        stepper[i]->setSpeed(0);
        stepper[i]->stop(); 
        stepper[i]->setZero();
        state = false;
      }
    }

    state = true;
    stepper[i]->setSpeed(90);
    stepper[i]->rotate(-1); 
    delay(3000);

    while (state) { 
      // Check limit switch state
      if (digitalRead(limitSwitches[i]) == 0) {
        stepper[i]->setSpeed(0);
        stepper[i]->stop(); 
        state = false;
      }
    }

    workSpace = stepper[i]->read();

    if (i == 1){
      stepsHeightZ = stepper[i]->readSteps();
    }

    delay(20);
    state = true;

    delay(100);
    stepper[i]->setSpeed(150);
    stepper[i]->write(workSpace/2);

    while(state){
      delay(10);
      if (stepper[i]->getSpeedSteps() == 0){
        state = false;
      }
    }

    state = true;
    if (i == 1) {
      continue;
    } else {
      stepper[i]->setZero();
    }
  }

  delay(500);
  Serial.println("HOMEA");
  Serial.println("Homing Completed");
}