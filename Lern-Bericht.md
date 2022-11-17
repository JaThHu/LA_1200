# LA_1200 Lern-Bericht
Janick Hurschler
Joel Haldimann
Mohamad Amraya

## Einleitung

Wir haben ein Manager für die Einteilung in Workshops mit C# programmiert.

## Was habe ich gelernt?

Wir haben gelernt, wie man Daten aus einer Textdatei ausliest und in eine Textdatei einfügt.

## Beschreibung

Als wir beim Planen des Projektes waren, mussten wir herausfinden, wie man die benötigten Daten (hier E-Mail-Adressen) aus einer Textdatei ausliest. Wir wollten nicht, dass
der Nutzer alles von Hand eingeben muss, sondern dass er einfach eine Textdatei angeben kann, indem schon alles geschrieben ist.
Wir sind zuerst in Internet gegangen und haben nach einer Lösung gesucht. Wir haben viele verschiedene Möglichkeiten gesehen, aber diese waren meist zu kompliziert und nicht geeignet.
Als im nächsten Input genau diese Funktion besprochen wurde, haben wir genau diese Art gewählt. Sie war passend, übersichtlich und verständlich.
Zusammengefasst besteht die Funktion ganz einfach aus "file.ReadAllText()" und "file.WriteAllText()". Bei beiden muss man in die Klammer einen Path, also ein Dateipfad, und
Content, also was geschrieben werden soll, schreiben. Das bewirkt dann, dass das Programm diese Datei nimmt und entweder alle Zeichen ausliest und das hineinschreibt, was man verlangt.
Das ganze haben wir mit einer Liste verbunden. Das heisst, dass er das in eine Textdatei schreibt, was in dieser Liste z.B. an Platz 3 steht. So wollten wir dann schlussendlich
die Einteilung in die Workshops, in einer Textdatei ausgeben.

```csharp

string dataPath = @"C:\Users\haldi\OneDrive\Desktop\Test.txt";



           //Liest den Text aus der Datei
            string fileData = File.ReadAllText(dataPath);




            string Test = "Test3";



           // Ersetzt  den Text mit der Variable (hier Test)
            File.WriteAllText(dataPath, Test);

```

![3d71e97a-a010-4bbf-91b3-f25b285157b5](https://user-images.githubusercontent.com/111045598/202411052-158ce887-963a-43e3-99fc-f26c118b2ac9.jpg)

![019e46d8-5b5a-4a8f-85c1-5881649fb86f](https://user-images.githubusercontent.com/111045598/202411095-111da7f1-22d3-4815-81b3-b4dd3ca28886.jpg)




## Verifikation

Der Text zeigt, wie wir zur erklärten Funktion gekommen sind. 
Das Code-Beispiel zeigt, wie man den Text aus einer Datei auslesen kann und wie man in eine Datei reinschreiben kann.
Das erste Bild zeigt die Textdatei vor dem Einlesen. Das zweite Bild zeigt die Textdatei nach dem Ausführen des Programmes.


# Reflexion zum Arbeitsprozess

Wir hatten die Planung sehr schnell zusammen und wussten wie wir den Code aufteilen können, sodass jeder arbeiten kann.

Wir hatten teilweise Probleme beim Programmieren, sodass die Arbeit sehr schleppend verlief.

**VBV**: Wir nehmen uns vor, dass wir uns strikt an die Arbeitspakete und die Planung halten. Das können wir erreichen, indem wir die Planung immer im Auge behalten
und indem der Gruppenchef mehr kontrolliert, was gemacht wird.
