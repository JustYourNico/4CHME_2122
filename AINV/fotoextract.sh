#!/bin/bash

anm=$#
counter=0
if [ -e $1 ]
then
	if [ $# -eq 2  ]
	then
		wkdir=$(pwd)
		pdfimages $1 ./ -j
		pdftotext $1 ./text.txt -layout
		while read line
		do
		    if [[ ${line} =~ ^[0-9] ]]; then
			echo -e ${line} | tr -s " " >> temp.txt
		    fi
		done < text.txt
		while read line
		do
		    newNames[$counter]=${line// /_}
		    counter=$(($counter+1))

		done < temp.txt
		counter=0
		for entry in $wkdir/*.jpg
		do
			mv $entry $2_${newNames[$counter]}
			counter=$(($counter+1))
		done
		rm temp.txt
		rm text.txt
	elif [ $# -eq 3 ]
	then
		mkdir $3
		cd $3
		wkdir=$(pwd)
		
		pdfimages ../$1 ./ -j
		pdftotext ../$1 ./text.txt -layout
		while read line
		do
		    if [[ ${line} =~ ^[0-9] ]]; then
			echo -e ${line} | tr -s " " >> temp.txt
		    fi
		done < text.txt
		while read line
		do
		    newNames[$counter]=${line// /_}
		    counter=$(($counter+1))

		done < temp.txt
		counter=0
		for entry in $wkdir/*.jpg
		do
			mv $entry $2_${newNames[$counter]}
			counter=$(($counter+1))
		done
		rm temp.txt
		rm text.txt
	else
		echo "Die Anzahl an Argumenten ist nicht zulässig, Zulässige Argumente sind: \n
		      1: Dateiname\n
		      2: Prefix\n
		      3: Zu erstellender Unterordner"
		exit 2
	fi
else
	echo "Diese angegebene Datei $1 Konnte nicht gefunden werden"
	exit 1
fi

