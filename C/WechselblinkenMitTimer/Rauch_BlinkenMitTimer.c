	/*****************************************,**********************************//**
	Implementation of blinking lights (PORTA and PORTB), period duration T = 1 sec, using the timerinterrupt
	The frequency can be changed by input into the serial console (115200bd), it should be possible to change
	the start value for the timer and the prescaler, using + and - on your Keyboard


	Adapt to your own specification! This code is an example!

	@author Rauch Nico
	@date 15.12.2021
	@version 1.0

	@param compiler switches: none
	@param linker switches: none
	*/

	#include <avr\interrupt.h>
	#include "HWTimer.h"
	#include "LITECShieldDefinitions.h"
	#include <avr\delay.h>
	#include "Timer.h"
	#include "USART.h"

	volatile uint16_t start = 40536;
	uint8_t i, aenderung;

	void setup(void); 


	int main(void) 
	{
	   setup();

	   while (1) 
	   {
		   while (i <= 9) 
		   {
			   PORTA = segm_inv[i];
			   i++;
			   _delay_ms(2000);
			   
			   if (USARTCharReceived(0))				//Check if anything is recieved by the ussart Serial communication
			   {
				  aenderung = USARTReceive(0);				//save char from serial port to "Buffer"		  
				  if (aenderung == '+')
				  {
					  printf("The frequency went up");
					  start = start + 1000;
				  }				
				  else if (aenderung == '-')
				  {
					  printf("The Frequency went down");
					  start = start - 1000;
				  }
				  printf("The new start Value is: %u\n", start);			//%u = unasigned integer
			   }
		   }
		   i = 0;
	   }

	}


	void setup(void) 
	{
	   // PORT Configuration
	   DDRA = 0xFF;
	   PORTA = 0xFF;
	   // PORT Configuration
	   DDRB = 0xFF;
	   PORTB = 0xFF;

	   // Timer Configuration
	   // direkter Zugriff auf die Register:
	   TCNT3 = start;					// Startwert fuer ca. 500 ms
	   TCCR3B |= (1 << CS32);			// Prescaler 256 -> max. Timerlaufzeit ca. 1 sec
	   TIMSK3 |= (1 << TOIE3);
	  
	   sei();
	   // unter Verwendung der entsprechenden Funktion:
	   TimerLoadValue(3, start);
	   TimerEnable(3, PRE_DIV_256, TIMER_MODE0_NORMAL);
	   TimerEnableOVFInt(3);
	   
	   //USART confugiration

	   USARTInit(0, 115200, 1, 0, 1, 0);

	   // Interrupt Configuration  	   
	}

	// Interrupt Service Routine for Timer Overflow Interrupt

	ISR(TIMER3_OVF_vect) {

	   PORTA = ~PORTA;
	   PORTB = ~PORTB;
	   TCNT3 = start;					// Startwert fuer ca. 500 ms
	}

	