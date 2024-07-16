/*Copyright (c) 2013, Silas Parker
All rights reserved. 
Modified for FullBaster403*/
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

#define PACKET_SYNC 0xFF
#define PACKET_VER  2

#define SERVO_DIR_NORMAL false
#define SERVO_DIR_INVERT true

int serial_byte;

void setup()
{
  Serial.begin(115200);
  
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

  // Check LEDs  
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
  
  delay(500);
  
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

  delay(500);
  
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

  delay (1000);

 // Check Servos
  speedo.write(180);
  rpm.write(180);
  delay(500);
  speedo.write(0);
  rpm.write(0);
  delay(500);
  speedo.write(180);
  rpm.write(180);

  delay(1000);

  air.write(180);
  fuel.write(180);
  delay(500);
  air.write(0);
  fuel.write(0);
  delay(500);
  air.write(180);
  fuel.write(180);

  delay(1000);

  oil.write(180);
  temp.write(180);
  delay(500);
  oil.write(0);
  temp.write(0);
  delay(500);
  oil.write(180);
  temp.write(180);

}



void read_serial_byte_set_servo(Servo& servo, bool invert)
{
  serial_byte = Serial.read();
  serial_byte = (serial_byte < 0) ? 0 : ((serial_byte > 180) ? 180 : serial_byte);
  if (invert)
    servo.write(180 - serial_byte);
  else
    servo.write(serial_byte);
}

void skip_serial_byte()
{
  (void)Serial.read();
}

void digitalWriteFromBit(int port, int value, int shift)
{
  digitalWrite(port, (value >> shift) & 0x01);
}

void loop()
{
  if (Serial.available() < 16)
    return;
  
  serial_byte = Serial.read();
  if (serial_byte != PACKET_SYNC)
    return;
   serial_byte = Serial.read();
  if (serial_byte != PACKET_VER)
  {
    return;
  }   
  
  read_serial_byte_set_servo(speedo, SERVO_DIR_INVERT); // Speed  
  read_serial_byte_set_servo(rpm, SERVO_DIR_INVERT); // RPM
  read_serial_byte_set_servo(air, SERVO_DIR_INVERT); // Brake air pressure
  skip_serial_byte(); // Brake temperature
  read_serial_byte_set_servo(fuel, SERVO_DIR_INVERT); // Fuel ratio
  read_serial_byte_set_servo(oil, SERVO_DIR_INVERT); // Oil pressure
  skip_serial_byte(); // Oil temperature
  read_serial_byte_set_servo(temp, SERVO_DIR_INVERT); // Water temperature
  skip_serial_byte(); // Battery voltage
    
              //Dashboard lights
              
  // Truck lights byte
  serial_byte = Serial.read();
  digitalWriteFromBit(LEFT_INDICATOR,  serial_byte, 5);  
  digitalWriteFromBit(RIGHT_INDICATOR, serial_byte, 4);
  digitalWriteFromBit(LOWBEAM, serial_byte, 3);
  digitalWriteFromBit(HIGHBEAM, serial_byte, 2);
  
  // Warning lights bytes

  serial_byte = Serial.read();  
  digitalWriteFromBit(PARKING_BREAK, serial_byte, 7);
  digitalWriteFromBit(ENGINEBRACK, serial_byte, 6);
  digitalWriteFromBit(AIRPRESS, serial_byte, 5);
  digitalWriteFromBit(FUEL_WARNING, serial_byte, 3); 
  digitalWriteFromBit(BATTERY, serial_byte, 2);
  digitalWriteFromBit(OILPRESS, serial_byte, 1);
 
  }
  
