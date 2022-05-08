#include <SPI.h> 
#include <RFID.h>
#include <Servo.h> 
#include <LiquidCrystal.h>
#define SS_PIN 42
#define RST_PIN 43
RFID rfid(SS_PIN,RST_PIN);
Servo servocontrol;
const int rs = 7, en = 6, d4 = 2, d5 = 3, d6 = 4, d7 = 5;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);
char inChar; int i=0; int ad=31;


void setup() {
  Serial.begin(9600);
servocontrol.attach(35);
lcd.begin(16,2);
pinMode(35,OUTPUT); pinMode(ad,INPUT);
SPI.begin(); rfid.init(); lcd.clear();
lcd.setCursor(0,0);
lcd.print("WELCOME EUL");
lcd.setCursor(0,1);
lcd.print("Mert OZDEMIR");
servocontrol.write(0);
}
void loop() {
inChar=(char)Serial.read();

if(inChar==','){
servocontrol.write(180);
delay(500);
servocontrol.write(0);
digitalWrite(ad,HIGH);
delay(1000);
digitalWrite(ad,LOW);}


if(rfid.isCard()){
  if(rfid.readCardSerial())  {
  Serial.print(rfid.serNum[0]);  Serial.print(rfid.serNum[1]);  Serial.print(rfid.serNum[2]);
  Serial.print(rfid.serNum[3]);  Serial.println(rfid.serNum[4]);
  lcd.clear();  lcd.setCursor(0,0);
  lcd.print("READED CARD NO: ");
  lcd.setCursor(0,1);
  lcd.print(rfid.serNum[0]);  lcd.print(rfid.serNum[1]);
  lcd.print(rfid.serNum[2]);  lcd.print(rfid.serNum[3]);
  lcd.print(rfid.serNum[4]);
while(rfid.readCardSerial()){}
  }}
delay(50);rfid.halt();
}
