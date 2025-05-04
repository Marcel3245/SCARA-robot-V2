void angleUpdate() {
  Serial.println("");
  Serial.print("ARA; ");
  Serial.print(jointAngle1, 2); // Print with 2 decimal places
  Serial.print(";");
  Serial.print(jointAngle2, 2); // Print with 2 decimal places
  Serial.print(";");
  Serial.print(jointAngle3, 2); // Print with 2 decimal places
  Serial.print(";");
  Serial.print(jointAngle4, 2); // Print with 2 decimal places
  Serial.print(";");
  Serial.println(flangeWidth, 2); // Print with 2 decimal places
}