
#include <avr/io.h>
#include <stdio.h>
#include "Usart.h"
#include <string.h>
#include <stdlib.h>

void setup();

volatile int red=0, green=0, blue = 0;

int main()
{
    
    setup();

    //declaration of the (in this scope) needed Variables
    int valueDecoder = 0;
    char recievedData[15];
    char delim[] = ";";
    char *stringPartHelper="";
    
    while (1)
    {
        valueDecoder = 0;
        scanf("%s", recievedData);

        //splitting up the recieved data array into the three needed values
        stringPartHelper = strtok(recievedData, delim);
        while (stringPartHelper != NULL)
        {
            switch (valueDecoder)
            {
            case 0:
                red = atoi(stringPartHelper);
                break;
            case 1: 
                green = atoi(stringPartHelper);
                break;
            case 2:
                blue = atoi(stringPartHelper);
                break;
            default:
                break;
            }
            valueDecoder++;
            stringPartHelper = strtok(NULL, delim);
        }

        //Calculating the respective values for each pin
        OCR1A = (39999 / 255) * red;
        OCR1B = (39999 / 255) * green;
        OCR1C = (39999 / 255) * blue;

        //sending back the values
        printf("R: %d G: %d B: %d", red, green, blue);
    }
}

void setup()
{
    //Declaring port definitions

        DDRB = 0xFF;
        DDRD = 0x00;
    //Timer definitions start
        //Mode 14
        TCCR1A |= (1 << WGM11);
        TCCR1B |= (1 << WGM12);
        TCCR1B |= (1 << WGM13);

        //Prescaler 8
        TCCR1B |= (1 << CS11);


        //TOP-Value
        ICR1 = 39999;

        //Non-inverting mode
        TCCR1A |= (1 << COM1A1);
        TCCR1A |= (1 << COM1B1);
        TCCR1A |= (1 << COM1C1);

    //Timer definitions end

    //Interrupt definitions start
        //Enable Interrupt
        EIMSK |= (1 << INT3);
        EIMSK |= (1 << INT2);

        sei();

        //Falling Edge
        EICRA |= (1 << ISC31);
        EICRA &= ~(1 << ISC30);
        EICRA |= (1 << ISC20);
        EICRA &= ~(1 << ISC21);

    //Interrupt definitions end

    //USART-definitions
        USARTInitSTDIO(0);
        USARTInit(0, 9600, 1, 0, 1, 0);

    //Compare matches
        OCR1A = 29999;
        OCR1B = 29999;


}

ISR(INT3_vect)
{
    EIMSK &= ~(1 << INT3);
    WaitMs(30);
    EIFR |= (1 << INTF3); 

    red -= 5;
    green -= 5;
    blue -= 5;

    if (red <= 0)
    {
        red = 0;
    }
    if (green <= 0)
    {
        green = 0;
    }
    if (blue <= 0)
    {
        blue = 0;
    }

    OCR1A = (39999 / 255) * red;
    OCR1B = (39999 / 255) * green;
    OCR1C = (39999 / 255) * blue;

    EIMSK |= (1 << INT3);
}

ISR(INT2_vect) 
{
    EIMSK &= ~(1 << INT2);
    WaitMs(30);
    EIFR |= (1 << INTF2); 

    red += 5;
    green += 5;
    blue += 5;

    if (red >= 255)
    {
        red = 255;
    }
    if (green >= 255)
    {
        green = 255;
    }
    if (blue >= 255)
    {
        blue = 255;
    }

    OCR1A = (39999 / 255) * red;
    OCR1B = (39999 / 255) * green;
    OCR1C = (39999 / 255) * blue;

    EIMSK |= (1 << INT2);
}
