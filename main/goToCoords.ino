void goToCoords(char formattedData[][20]) {
    float rpm = atof(formattedData[6]);
    float rampLen = atof(formattedData[7]);

    positions[0] = atof(formattedData[1]) * 25 / stepResolut;
    positions[1] = atof(formattedData[2]) * stepsHeightZ / heightZ;
    positions[2] = atof(formattedData[3]) * 9 / stepResolut;
    positions[3] = atof(formattedData[4]) * 3 / stepResolut;
    positions[4] = (atof(formattedData[5]) + 46) *41/30;

    if (stepper[0]->getSpeedSteps() == 0 &&
        stepper[1]->getSpeedSteps() == 0 &&
        stepper[2]->getSpeedSteps() == 0 &&
        stepper[3]->getSpeedSteps() == 0 &&
        myServo.moving() == 0) {
        for (int i = 0; i < 5; i++) {
            if (i == 4) {
              if ((atof(formattedData[5]) <= 23) {
                positions[4] = 92;
              } else {
                myServo.write(positions[4]);
              }
            } else {
              stepper[i]->setSpeed(rpm);
              stepper[i]->setRampLen(rampLen);
              stepper[i]->writeSteps(positions[i]);
            }
        }
    }
}

