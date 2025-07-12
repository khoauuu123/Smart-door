unsigned long bien = 0;
int bt1 = 33;
int bt2 = 35;
int bt3 = 37;
int bt4 = 39;
int led = 28;
int led_tt = 1;
void setup() {
  Serial.begin(9600);
  pinMode(bt1, INPUT_PULLUP);
  pinMode(bt2, INPUT_PULLUP);
  pinMode(bt3, INPUT_PULLUP);
  pinMode(bt4, INPUT_PULLUP);
  pinMode(led, OUTPUT);
  digitalWrite(led, led_tt);
}
int tam = 0;
char c;
void loop() {
  if (digitalRead(bt4) == 0) {
    tam = 1;
    delay(200);
  }
  if (digitalRead(bt1) == 0) {
    tam = 2;
    delay(200);
  }
  if (digitalRead(bt2) == 0) {
    tam = 3;
    delay(200);
  }
  if (digitalRead(bt3) == 0) {
    tam = 4;
    delay(200);
  }
  if (tam == 1) {
    tam = 0;
    bien = random(10000000 , 99999999);
    String s1 = String(bien);
    Serial.println(s1);
  }
  else if (tam == 2) {
    tam = 0;
    Serial.println("12345678");
  }
  else if (tam == 3) {
    tam = 0;
    Serial.println("45678910");
  }
  else if (tam == 4) {
    tam = 0;
    Serial.println("43628373");
  }
  if (Serial.available())
  {
    c = Serial.read();
    if (c == '1') {
      led_tt = !led_tt;
      digitalWrite(led, led_tt);
      Serial.println(led_tt);
    }
  }
}
