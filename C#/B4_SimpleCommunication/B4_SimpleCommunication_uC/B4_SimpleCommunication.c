

#include <avr/io.h>
#include <stdio.h>
#include "Usart.h"
#include "Wait.h"

void setup(void);
int * convertDezToBin(int);
void blinkLed(int);

int main(void)
{
	setup();

	//Declaring variables
	int NumScan = 0;
	int ReturnNum = 0;
	int BitNum = 0;
	int OldNum = 0;
	int BlinkNum = 0;
	int *binNum; //Array for storing the bit-information which is needed for the individual pins
	
	while (1)
	{

		scanf("%d", &NumScan); //Getting input from C#-program

		//Calculations and converting
		ReturnNum = (NumScan % 256);
		BitNum = ReturnNum;

	
		printf("Empfangen: %i ----> Angezeigt: %i", NumScan, ReturnNum); //Output for the WPF-application

		if (OldNum != NumScan) //If a new number was recieved, the array, which sets the pins is reset
		{
			OldNum = NumScan;
			
			for (int j = 0; j < 8; j++)
			{
				binNum[j] = 0;
			}

			blinkLed(NumScan);
		}

		binNum = convertDezToBin(BitNum);
		
		//LEDs		
		if (*(binNum+0) == 0) //If the array-entry is 0, the corresponding pin will be set to 0, if its it 0 it will be set to 1
		{
			PORTA &= ~(1 << PINA0);
		}
		else
		{
			PORTA |= (1 << PINA0); 
		}
				
		if (*(binNum + 1) == 0)
		{
			PORTA &= ~(1 << PINA1);
		}
		else
		{
			PORTA |= (1 << PINA1);
		}
				
		if (*(binNum + 2) == 0)
		{
			PORTA &= ~(1 << PINA2);
		}
		else
		{
			PORTA |= (1 << PINA2);
		}
				
		if (*(binNum + 3) == 0)
		{
			PORTA &= ~(1 << PINA3);
		}
		else
		{
			PORTA |= (1 << PINA3);
		}
				
		if (*(binNum + 4) == 0)
		{
			PORTA &= ~(1 << PINA4);
		}
		else
		{
			PORTA |= (1 << PINA4);
		}
				
		if (*(binNum + 5) == 0)
		{
			PORTA &= ~(1 << PINA5);
		}
		else
		{
			PORTA |= (1 << PINA5);
		}
				
		if (*(binNum + 6) == 0)
		{
			PORTA &= ~(1 << PINA6);
		}
		else
		{
			PORTA |= (1 << PINA6);
		}
				
		if (*(binNum + 7) == 0)
		{
			PORTA &= ~(1 << PINA7);
		}
		else
		{
			PORTA |= (1 << PINA7);
		}
	}	
}


int * convertDezToBin(int dezRec) //converts decimal number into binary
{
	static int binNum[8];
	int dezNum = dezRec;
	for (int i = 0; dezNum > 0; i++) //Converts the value of ReturnNum into an binary number array
	{
		binNum[i] = dezNum % 2;
		dezNum = dezNum / 2;
		WaitMs(20);
	}
	return binNum;
}

void blinkLed(int numScan)
{
	int BlinkNum;
	BlinkNum = (numScan / 256);
	for (int k = 0; k <= BlinkNum; k++) //Addition Nr. 1 for the µC-program
	{
		PORTA = 0x00;
		PORTA = 0xFF;
		WaitMs(100);
		PORTA = 0x00;
		WaitMs(100);
	}
}

void setup(void)
{
	//Declaring port definitions
	DDRA = 0xFF; //Port-A is output

	//USART-definitions
	USARTInitSTDIO(0); //prepare Serial0 of uC for standard-I/O
	USARTInit(0, 9600, 1, 0, 1, 0); //set communication-parameters for Serial0
}
