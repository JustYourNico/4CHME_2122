/*
You should be able to change the frequency with 2 Buttons, wich unfortunately does not work
*/

#include<avr\io.h>
#include<avr\interrupt.h>
#include<avr\delay.h>
#include<math.h>


uint16_t startwert = 6161;
void setup(void);

int main(void)
{
    setup();
    while (1)
    {
        ;
    }
}

void setup(void)
{
    //definitions for timer
    DDRB |= (1 << DDB7);
    TCNT3 = 6161;
    TCCR3B |= ((1 << CS30) | (1 << CS31));
    TIMSK3 |= (1 << TOIE3);
    
    //Definitions for timer frequency change

    DDRD &= ~(1 << PD2);
    DDRB &= ~(1 << PD3);


    EICRA |= (1 << ISC31); // Damit INT3 nur "Falling edge" zählt
    EICRA &= ~(1 << ISC30);
    EIMSK |= (1 << INT3); //enable INT3

    EICRA |= (1 << ISC21); //Damit INT2 nur "Rising edge" zählt
    EICRA &= ~(1 << ISC20);
    EIMSK |= (1 << INT2); //enable INT2
    
    USARTInitSTDIO(0);    //prepare serial 0 of uC
    USARTInit(0, 9600, 1, 0, 1, 0);    //set communication parameter for serial communications
    
    
    sei();
}


ISR(TIMER3_OVF_vect)
{
    PORTB = (PINB & (1 << PB7)) ? PORTB & ~(1 << PB7) : PORTB | (1 << PB7);
}

ISR(INT3_vect)
{
    EIMSK &= ~(1 << INT3);
    _delay_ms(30);
    EIFR |= (1 << INTF3);
    if (startwert >= (65535*0.89))
    {
        ;
    }
    else
    {
        startwert = round(startwert * 1.1);
    }
    TCNT3 = startwert;
    printf("startwert betraegt: %u \n", startwert);

    EIMSK |= (1 << INT3);
}

ISR(INT2_vect)
{
        EIMSK &= ~(1 << INT2);
        _delay_ms(30);

        startwert = round(startwert * 0.9);

        TCNT3 = startwert;
        EIFR |= (1 << INTF2);
        EIMSK |= (1 << INT2);
        printf("startwert betraegt: %u \n", startwert);
}
