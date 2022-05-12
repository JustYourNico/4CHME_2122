# Meine Lösung von level 1 vom CCC 2014

Alle benötigten Funktionen der os-Bibliothek importieren

```python
from os import listdir
from os import chdir
```

eigene Klasse definieren, durch welche die Koordinaten abgespeichert werden können

```python
class coordinates:
    def __init__( self, x, y):
        self.x=x
        self.y=y
```

Deklaration aller benötigten Variablen

```python
chdir("./Level1")
allFilesInFolder=listdir("./")
i=0
stringInFiles = ""
tempCoord = []
points = []
```

Dateien nach der Reihe öffnen

```python
for f in allFilesInFolder:
    with open(f,'r') as x:
```

Alle Einzelnen Zahlen einlesen und getrennt in einer Liste abspeichern

```python
        stringInFiles = str(x.readline().strip('\n'))
        tempCoord=stringInFiles.split(" ")
```

Die Koordinaten dann auf x und y aufteilen

```python
for i in range(len(tempCoord)):
    if i%2 == 0:
        points.append(coordinates(int(tempCoord[i]), int(tempCoord[i+1]))) 
```

Die aktuell im programm im read mode geöffnete Datei schließen, um die selbe dann im "append" mode wieder auf zu machen. (Append mode bedeutet, alles was durch . write geschrieben wird wird am Ende des existenten Textes eingefügt)

```python
        x.close()
    with open(f,'a') as x:
```

Abgleich, ob x oder y koordinate eines Punktes gleich sind, wodurch diese entweder Paralell zur x oder y achse sind

```python
        if points[-2].x == points[-1].x:
            x.write("Paralell to y axis")
        if points[-2].y == points[-1].y:
            x.write("Paralell to x axis")
```

Die offene Datei wieder schließen

```python
        x.close()
```
