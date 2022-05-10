#include <avr/io.h>
#include <stdio.h>
#include "USART.h" 

int16_t main(void)
{
	int number;

	DDRA = 0xFF;		// all pins are output
	PORTA = 0xFF;		// all leds are off

	// USART init
	USARTInit(0, 9600, 1, 0, 1, 0);

	while (1)
	{
		scanf("%d", &number);	// read integer and store in number
		PORTA = ~number;
		printf("received: %d --> displayed: %d\n", number, number%256);
	}
	return 0;
}
