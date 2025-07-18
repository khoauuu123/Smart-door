#include <16F877a.h>  // khai b�o thu vi�n cho con pic 16F877A
#FUSES PUT,HS,NOWDT,NOPROTECT,NOLVP
#use delay(clock=20M)  // kh�i b�o h�m delay su dung thach anh 20M
#use i2c(Master,Fast=100000, sda=PIN_C4, scl=PIN_C3,force_sw)  // khia b�o su dung chuan giao tiep I2C
#use rs232(baud=9600,parity=N,xmit=PIN_C6,rcv=PIN_C7,bits=8,stream=PORT1)  //khai b�o su dung chuan giao tiep UART
#include "i2c_Flex_LCD.c"   //khai b�o thu vien giao tiep I2C Voi LCD
#define RELAY PIN_D7   // chan K�ch Relay
#define COI PIN_A0   // chan k�ch coi

/*******khai b�o chan giao tiep SPI*******/

#define MFRC522_CS         PIN_D0
#define MFRC522_SCK        PIN_D1
#define MFRC522_SI         PIN_C2
#define MFRC522_SO         PIN_C1       
#define MFRC522_RST        PIN_C0
#include<Built_in.h>  // thu vi�n su dung chuan giao SPI voi

CHAR UID[6];  // bien doc ma UID
UNSIGNED int TagType;  // bien check the
char c;  // bien doc uart xuong

void coi_keu(int m)
{
   if(m == 1)
   {
      output_High(coi);
      delay_ms(100);
      output_Low(coi);
      delay_ms(100);
      output_High(coi);
      delay_ms(100);
      output_Low(coi);
      delay_ms(100);
   }
   else
   {
      output_High(coi);
      delay_ms(700);
      output_Low(coi);
   }
}

void quet_the()
{
   IF (MFRC522_isCard (&TagType)) //Check any card  c� the moi khong 
   {                                           
      IF (MFRC522_ReadCardSerial (&UID))// doc ma UID the            
      {
         for(int i=0; i<4; i++)
         {
            printf("%x"(unsigned char)UID[i]);
         }
         printf("\r\n");
         delay_ms(300);
      }
   }
   MFRC522_Halt ();  // dua module v�o ch� do ngu den khi the cu duoc lay ra, chong doi the
}

int1 doc_data_uart()
{
   int tt;
   if(kbhit())
   {
      c = getc();
      if(c =='2') //  the dung tt mo cua
      {
         output_High(RELAY);
         coi_keu(1);
         tt = 1;
      }
      if(c =='1')// the dung tt dong cua
      {
         output_Low(RELAY);
         coi_keu(1);
         tt = 2;
      }
      if(c =='0')// the sau thong b�o loi ERROR
      {
         coi_keu(0);
         tt = 3;
      }
      if(c =='L') // ngat k�t n�i phan mem
      {
         tt = 4;
      }
   }
   return tt;
}



int tam3 = 0;
int tam_KN = 0;
void main()
{
   printf("1");// khi PIC duoc reset 
   printf("\r\n");
   tam_KN = 0;
   output_Low(RELAY);   
   MFRC522_Init (); // khoi dong RC522
   set_tris_D(0x00);
   set_tris_A(0x00);
   output_Low(coi);
   lcd_init(0x4E,16,2);  //khoi dong lcd dia chi 0x4E
   lcd_backlight_led(ON); //bat led nen lcd
   
   while(TRUE)
   {
      if(tam_KN == 0)
      {
         if(kbhit())// khi c� t�n hieu tu uart gui ve
         {
            c = getc();// lay tin hieu uart gui ve dang ky tu
            if(c=='K')
            {
               tam_KN = 1;
            }
         }
         lcd_gotoxy(1, 1);
         printf(lcd_putc, "    HE THONG    ");
         lcd_gotoxy(1, 2);
         printf(lcd_putc, "  CHUA KET NOI  ");
         
         if(tam_KN == 1)
         {
            lcd_gotoxy(1, 1);
            printf(lcd_putc, "HE THONG KET NOI");
            lcd_gotoxy(1, 2);
            printf(lcd_putc, "   THANH CONG   ");
            delay_ms(3000);
         }
      }
      if(tam_KN == 1)
      {
         quet_the();
         tam3 = doc_data_uart();
         if(tam3 == 0)
         {
            lcd_gotoxy(1, 1);
            printf(lcd_putc, " HE THONG THE TU ");
            lcd_gotoxy(1, 2);
            printf(lcd_putc, "  MOI QUET THE  ");
         }
         else if(tam3 == 1)
         {
            tam3 = 3;
            lcd_gotoxy(1, 1);
            printf(lcd_putc, " QUET THANH CONG");
            lcd_gotoxy(1, 2);
            printf(lcd_putc, "     CUA MO     ");
            delay_ms(2000);
         }
         else if(tam3 == 2)
         {
            tam3 = 3;
            lcd_gotoxy(1, 1);
            printf(lcd_putc, " QUET THANH CONG");
            lcd_gotoxy(1, 2);
            printf(lcd_putc, "     CUA DONG   ");
            delay_ms(2000);
         }
         else if(tam3 == 3)
         {
            tam3 = 3;
            lcd_gotoxy(1, 1);
            printf(lcd_putc, " !!!!THE SAI!!!!");
            lcd_gotoxy(1, 2);
            printf(lcd_putc, "KHONG THANH CONG");
            delay_ms(2000);
         }
         else if(tam3 == 4)
         {
            tam_KN = 0;
         }
      }
   }
}

