/*Copyright (c) 2023, FullBaster403
All rights reserved. 

#include <Servo.h>
/*Declare Servos*/
const int SPEEDO_PIN      = A0;
const int RPM_PIN         = A1;
const int AIR_PIN         = A2;
const int FUEL_PIN        = A3;
const int OILTEMP_PIN     = A4;
const int TEMP_PIN        = A5;
/*Declare LEDs*/  
const int LEFT_INDICATOR  = 3;
const int RIGHT_INDICATOR = 4;
const int PARKING_BREAK   = 5;
const int FUEL_WARNING    = 6;
const int LOWBEAM         = 7;
const int HIGHBEAM        = 8;
const int AIRPRESS        = 10;
const int BATTERY         = 11;
const int OILPRESS       = 12;
const int ENGINEBRACK     = 13;

// Servo variables
Servo speedo;
Servo rpm;
Servo air;
Servo fuel;
Servo oil;
Servo temp;

int serial_byte;

void setup()
{
  Serial.begin(9600);
  
  // Initialise LEDs
  pinMode(LEFT_INDICATOR, OUTPUT);
  pinMode(RIGHT_INDICATOR, OUTPUT);
  pinMode(PARKING_BREAK, OUTPUT);
  pinMode(FUEL_WARNING, OUTPUT);
  pinMode(LOWBEAM, OUTPUT);
  pinMode(HIGHBEAM, OUTPUT);
  pinMode(AIRPRESS, OUTPUT);
  pinMode(BATTERY, OUTPUT);
  pinMode(OILPRESS, OUTPUT);
  pinMode(ENGINEBRACK, OUTPUT);

  // Initialise servos
  speedo.attach(SPEEDO_PIN);
  rpm.attach(RPM_PIN);
  air.attach(AIR_PIN);
  fuel.attach(FUEL_PIN);
  oil.attach(OILTEMP_PIN);
  temp.attach(TEMP_PIN);

  digitalWrite(LEFT_INDICATOR, 0);
  digitalWrite(RIGHT_INDICATOR, 0);
  digitalWrite(PARKING_BREAK, 0);
  digitalWrite(FUEL_WARNING, 0);
  digitalWrite(LOWBEAM, 0);
  digitalWrite(HIGHBEAM, 0);
  digitalWrite(AIRPRESS, 0);
  digitalWrite(BATTERY, 0);
  digitalWrite(OILPRESS, 0);
  digitalWrite(ENGINEBRACK, 0);
}


void loop() 
{
   if (Serial.available() > 0)
   {
    int SerialData = Serial.read();
    if(SerialData == '1')
    {
  digitalWrite(LEFT_INDICATOR, 1);
  digitalWrite(RIGHT_INDICATOR, 1);
  digitalWrite(PARKING_BREAK, 1);
  digitalWrite(FUEL_WARNING, 1);
  digitalWrite(LOWBEAM, 1);
  digitalWrite(HIGHBEAM, 1);
  digitalWrite(AIRPRESS, 1);
  digitalWrite(BATTERY, 1);
  digitalWrite(OILPRESS, 1);
  digitalWrite(ENGINEBRACK, 1);
      }else if (SerialData== '2')
      {
   digitalWrite(LEFT_INDICATOR, 0);
  digitalWrite(RIGHT_INDICATOR, 0);
  digitalWrite(PARKING_BREAK, 0);
  digitalWrite(FUEL_WARNING, 0);
  digitalWrite(LOWBEAM, 0);
  digitalWrite(HIGHBEAM, 0);
  digitalWrite(AIRPRESS, 0);
  digitalWrite(BATTERY, 0);
  digitalWrite(OILPRESS, 0);
  digitalWrite(ENGINEBRACK, 0);
        }
    if (SerialData == '3')
    {
  speedo.write(180);
  rpm.write(180);
  delay(1000);
  air.write(180);
  fuel.write(180);
  delay(1000);
  oil.write(180);
  temp.write(180);
      }else if (SerialData == '4') 
      {
  speedo.write(0);
  rpm.write(0); 
  delay(1000);
  air.write(0);
  fuel.write(0);
  delay(1000);
  oil.write(0);
  temp.write(0);
        }

    //Servos indivuduales    
    if (SerialData == 'f')
    {
  fuel.write(0);
  delay(1000);
  fuel.write(180);
      }
  else if (SerialData == 'g') 
      {
       oil.write(0);
       delay(1000);
       oil.write(180);
        }
  else if (SerialData == 'h')
    {
  speedo.write(0);
  delay(1000);
  speedo.write(180);
      }
  else if (SerialData == 'i') 
      {
       rpm.write(0);
       delay(1000);
      rpm.write(180);
        }
    else  if (SerialData == 'j')
    {
  temp.write(0);
  delay(1000);
  temp.write(180);
      }
 else if (SerialData == 'k') 
      {
       air.write(0);
       delay(1000);
      air.write(180);
        }
    }

}
