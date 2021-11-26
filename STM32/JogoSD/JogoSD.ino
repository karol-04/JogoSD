/*
  Guilheme Henrique Oliveira Silveira 13
  Karolaine Bonifácio Teodoro 24
  Maria Eduarda Silveira e Silva 30
  Turma 35DS
*/
#include <USBComposite.h>

USBHID HID;
HIDKeyboard Keyboard(HID);

int volante;
int acelerador;
int freio;
int aceleracao;
int i;
int j;

void setup()
{
  pinMode(PB5, INPUT_PULLDOWN); //botao inicio
  pinMode(PB9, INPUT_PULLDOWN); //botao buzina
  HID.begin(HID_KEYBOARD_MOUSE);
  while (!USBComposite);
}

void loop()
{
  if (digitalRead(PB9) == HIGH)
  {
    Keyboard.println("B");
    delay(2000);
  }
  if (digitalRead(PB5) == HIGH)
  {
    volante = analogRead(0);
    acelerador = analogRead(1);
    freio = analogRead(2);
    if (volante <= 2047)
    {
      for (i = (2047 / 128); i > (volante / 128); i--)
      {
        Keyboard.println("A");
      }
    }
    else
    {
      for (i = (2047 / 128); i < (volante / 128); i++)
      {
        Keyboard.println("D");
      }
    }
    if (freio >= acelerador)
    {
      aceleracao = 0;
    }
    else
    {
      aceleracao = acelerador - freio;
    }
    for (j = (2047 / 64); j < (aceleracao / 64); j++)
    {
      Keyboard.println("W");
    }
  }
}
