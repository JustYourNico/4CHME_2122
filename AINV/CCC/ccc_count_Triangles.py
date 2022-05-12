#!/usr/bin/python3

'''
Put this file in a directory with all the .zip files
the answers will be written into the filesr
'''

from os import listdir
from os import chdir
import zipfile
import shutil

i = 0
triangleNumber = 0
maxPoints = 0
stringInFiles = ""
triangles = []
tempCoord = []
points = []
lines = []
lines_px = []
lines_py = []
specialTriangles = 0


class coordinates:
    def __init__(self, x, y):
        self.x = x
        self.y = y


class triangle:
    def __init__(self, P1=coordinates, P2=coordinates, P3=coordinates):
        self.P1 = P1
        self.P2 = P2
        self.P3 = P3

    def specialTriangle(self):

        p1_p2eq = self.P1.x == self.P2.x and self.P1.y == self.P2.y
        p1_p3eq = self.P1.x == self.P3.x and self.P1.y == self.P3.y
        p2_p3eq = self.P2.x == self.P3.x and self.P2.y == self.P3.y

        if not p1_p2eq and not p1_p3eq and not p2_p3eq:
            if self.P1.x == self.P2.x or self.P1.x == self.P3.x or self.P2.x == self.P3.x:
                if self.P1.y == self.P2.y or self.P1.y == self.P3.y or self.P2.y == self.P3.y:
                    return True
                else:
                    return False
            else:
                return False
        else:
            return False

'''
class newTriangles:
    def __init__(self, p)
'''
class line:
    def __init__(self, P1, P2):
        self.P1 = P1
        self.P2 = P2

    def XParalell(self):
        if self.P1.y == self.P2.y:
            return True
        else:
            return False

    def YParalell(self):
        if self.P1.x == self.P2.x:
            return True
        else:
            return False

chosenLevel = input("Please choose the level you want to execute (r for reset) [1/a/2/b/3/c/4/d/5/e/r]: ")

if chosenLevel == "r":
    shutil.rmtree("./Level1", ignore_errors=True)
    shutil.rmtree("./Level2", ignore_errors=True)
    shutil.rmtree("./Level3", ignore_errors=True)
    shutil.rmtree("./Level4", ignore_errors=True)
    shutil.rmtree("./Level5", ignore_errors=True)
    with zipfile.ZipFile("Level1.zip", "r") as zip_ref:
        zip_ref.extractall("./")
    with zipfile.ZipFile("Level2.zip", "r") as zip_ref:
        zip_ref.extractall("./")
    with zipfile.ZipFile("Level3.zip", "r") as zip_ref:
        zip_ref.extractall("./")
    with zipfile.ZipFile("Level4.zip", "r") as zip_ref:
        zip_ref.extractall("./")
    with zipfile.ZipFile("Level5.zip", "r") as zip_ref:
        zip_ref.extractall("./")

# Level 1
if chosenLevel == '1':
    chdir("./Level1")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        with open(f, 'r') as x:
            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            for i in range(len(tempCoord)):
                if i % 2 == 0:
                    points.append(coordinates(int(tempCoord[i]), int(tempCoord[i + 1])))
            print(points)

        if points[-2].x == points[-1].x:
            print("y axis")
        elif points[-2].y == points[-1].y:
            print("x axis")
        else:
            print("None")

# Level 1 alternative
if chosenLevel == 'a':
    lines = []
    chdir("./Level1")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        with open(f, 'r') as x:
            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            for i in range(len(tempCoord)):
                if i % 2 == 0:
                    points.append(coordinates(int(tempCoord[i]), int(tempCoord[i + 1])))

            lines.append(line(points[-2], points[-1]))
            print(f)
            if lines[-1].YParalell():
                print("is paralell to y axis")
            if lines[-1].XParalell():
                print("is paralell to x-axis")
            if not lines[-1].XParalell() and not lines[-1].YParalell():
                print("none")

# Level 2
if chosenLevel == '2':
    chdir("./Level2")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        points = []
        with open(f, 'r') as x:
            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            for i in range(len(tempCoord)):
                if i % 2 == 0:
                    points.append(coordinates(int(tempCoord[i]), int(tempCoord[i + 1])))

        triangles.append(triangle(points[0], points[1], points[2]))
        if triangles[triangleNumber].specialTriangle():
            print("Yes")
        else:
            print("No")

        triangleNumber += 1

# Level 2 Alternative
if chosenLevel == '2a':
    chdir("./Level2")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        points = []
        with open(f, 'r') as x:
            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            for i in range(len(tempCoord)):
                if i % 2 == 0:
                    points.append(coordinates(int(tempCoord[i]), int(tempCoord[i + 1])))

# level 3
if chosenLevel == '3':
    chdir("./Level3")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        specialTriangles = 0
        points = []
        lines = []
        with open(f, 'r') as x:

            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            maxPoints = int(tempCoord.pop(0))
            for i in range(0, maxPoints * 2, 2):
                points.append(coordinates(int(tempCoord[i]), int(tempCoord[i + 1])))


            for p in range(len(points) - 1):
                for p2 in points[p + 1:]:
                    if not (points[p].x == p2.x and points[p].y == p2.y):
                        if points[p].x == p2.x:
                            lines.append(line(points[p], p2))

            # print("Lines | : {}".format(str(len(lines))))

            for l in lines:
                for p in points:
                    if (not l.P1.x == p.x and not l.P1.y == p.y) or (not l.P2.x == p.x and not l.P2.y == p.y):
                        if l.P1.y == p.y or l.P2.y == p.y:
                            specialTriangles += 1

            # print("Triangles: " + str(specialTriangles))

        print("The number of special triangles is: " + str(specialTriangles))

# level 4
if chosenLevel == '4':
    chdir("./Level4")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        specialTriangles = 0
        xpoints = {}
        ypoints = {}
        with open(f, 'r') as x:

            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            maxPoints = int(tempCoord.pop(0))

            for i in range(0, maxPoints * 2, 2):
                if not xpoints.keys().__contains__(int(tempCoord[i])):
                    xpoints[int(tempCoord[i])] = [int(tempCoord[i + 1])]
                else:
                    if int(tempCoord[i + 1]) not in xpoints[int(tempCoord[i])]:
                        xpoints[int(tempCoord[i])].append(int(tempCoord[i + 1]))

                if not ypoints.keys().__contains__(int(tempCoord[i + 1])):
                    ypoints[int(tempCoord[i + 1])] = [int(tempCoord[i])]
                else:
                    if int(tempCoord[i]) not in ypoints[int(tempCoord[i + 1])]:
                        ypoints[int(tempCoord[i + 1])].append(int(tempCoord[i]))

            print("Cx:"+str(len(xpoints[int(tempCoord[0])])))
            print("Cy:"+str(len(ypoints[int(tempCoord[1])])))


# level 5
if chosenLevel == '5':
    chdir("./Level5")
    allFilesInFolder = listdir("./")
    for f in allFilesInFolder:
        specialTriangles = 0
        xpoints = {}
        ypoints = {}
        with open(f, 'r') as x:

            stringInFiles = str(x.readline().strip('\n'))
            tempCoord = stringInFiles.split(" ")

            maxPoints = int(tempCoord.pop(0))
            for i in range(0, maxPoints * 2, 2):
                if not xpoints.keys().__contains__(int(tempCoord[i])):
                    xpoints[int(tempCoord[i])] = [int(tempCoord[i + 1])]
                else:
                    if int(tempCoord[i]) not in xpoints[int(tempCoord[i])]:
                        xpoints[int(tempCoord[i])].append(int(tempCoord[i + 1]))
                if not ypoints.keys().__contains__(int(tempCoord[i + 1])):
                    ypoints[int(tempCoord[i + 1])] = [int(tempCoord[i])]
                else:
                    if int(tempCoord[i]) not in ypoints[int(tempCoord[i + 1])]:
                        ypoints[int(tempCoord[i + 1])].append(int(tempCoord[i]))

            for key, values in ypoints.items():
                for val in values:
                    if len(xpoints[val]) > 1:
                        specialTriangles += (len(xpoints[val]) - 1) * (len(ypoints[key]) - 1)

                # print("Triangles: " + str(specialTriangles))

            print("The number of special triangles is: " + str(specialTriangles))
            print("{} done".format((str(f))))
