#!/usr/bin/python3

import random
randomNum = random.randint(0,30)
guessedNumber = 0
guessAnm = 1

print("Erraten Sie eine Zahl zwischen 1 und 30\n") 
guessedNumber=int(input("Geben Sie ihre erste Zahl ein:"))
while guessedNumber != randomNum:
    if guessedNumber>randomNum:
        guessedNumber=int(input("Ihre Zahl ist zu groß\nGeben Sie eine neue Zahl ein:"))
    elif guessedNumber<randomNum:
        guessedNumber=int(input("Ihre Zahl ist zu klein\nGeben Sie eine neue Zahl ein:"))
    guessAnm+=1
print("Sie haben erfolgreich die Zahl "+str(guessedNumber)+" in "+str(guessAnm)+" Versuchen erraten")
