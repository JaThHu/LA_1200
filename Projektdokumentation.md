# LA_1200
# Projekt-Dokumentation


### Gruppe: Butterfly
Mitglieder: Joël Haldimann, Mohamad Amraya, Tim Kral, Janick Hurschler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  03.11.2022     | 0.1.0   |  Der Code ist jetzt soweit, dass er eine Datei mit Daten einlesen kann. |
|   10.11.2022    | 0.2.0     |        Der Code ist nun Zusammengesetzt aber die Zuteilung muss noch überarbeitet werden.                                                      |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Programm in Visual Studios, bei dem Anmeldungen für verschiedene Workshops eingelesen und zugeteilt werden.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    muss             |  funktionale Anforderung    | Als Benutzer will ich dem Programm eine Datei geben können, um die Zuteilung zu ermöglichen. |
| 2  |       muss          |  funktionale Anforderung   |        Als Computer möchte ich alle Teilnehmer und deren Prioritäten einteilen.   |
| 3 | muss | funktionale Anforderung | Als Computer möchte ich verhindern, dass zu wenig oder zu viele Teilnehmer in einen Workshop kommen. |
| 4   |    muss             |  funktionale Anforderung    | Als Computer möchte ich dem User ausgeben, welche Person, welchen Workshop bekommt. |
| 5   |    kann             |  Qualitätsanforderung    | Als Computer möchte ich zählen, wie viele Personen sich eingetragen haben, um dem User die Teilnehmeranzahl mitzuteilen. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm wurde gestartet. | Textdatei einfügen        |  Einteilung mit Teilnehmer und zugeteiltem Workshop.                  |
| 2.1 | Textdatei wurde eingelesen. | Breakpoint bei der Zuweisung setzen. | Teilnehmer werden in jeden Workshop eingeteilt. |
| 3.1 | Textdatei wurde eingelesen. | Breakpoint bei der while-Schleife setzen. | maximal 20 und minimum 4 Perosnen in einem Workshop. |
| 4.1 | Textdatei wurde eingelesen. |         Einteilungs-Textdatei öffnen.          | Einteilung mit Name und Workshop. |
| 5.1 | Textdatei wurde eingelesen. | Einteilungs-Textdatei öffnen. | Anzahl Teilnehmer: (z.B. 20) |


### 1.4 Diagramme

![Screenshot 2022-10-27 103413](https://user-images.githubusercontent.com/111045792/198235501-023c56f7-9432-41ac-8d94-fcc40997807f.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  03.11.2022     |   Janick, Joel       |       Funktion zum Einlesen der Textdatei       |      45 min         |
|  1.B  |  03.11.2022     |    Tim       |       Die Daten der Textdatei sollen den verschiedene Variabeln zugeteilt werden       |       2 mal 45 min        |
|  2.A  |  10.11.2022     |      Joel      |   die einzelnen Zeilen der Textdatei sollen in ein Array gespeichert werden.         |      60 min         |
|  3.A  |  10.11.2022     |     Mohamad    |     zuteilunng der Workshops und begrenzung der freien Plätze     |      60 min         |
|  3.B  |  10.11.2022     |     Janick      |   Ausgabe der Einteilung mit Teilnehmern.        |      60 min         |
|  4.A  |  10.11.2022     |     Janick, Joel, Mohamad      |   Zusammenfügen vom Code und Überarbeitung       |      60 min         |
Total: 28 Arbeitspakete


## 3 Entscheiden

-Code in Visual Studios.
-Mit Arrays arbeiten.
-die Einteilung in einer Textdatei rückgeben.
-jeder macht sein Code und der wird am Schluss zusammengesetzt.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  3.11.2022     |    Janick, Joel       |     45 min          |        90 min.           |
| 1.B  |   3.11.2022    |    Tim       |       2 mal 45 min        |        90min           |
| 2.A | 10.11.2022 | Joel | 60 min | 90 min |
|3.A|10.11.2022|Mohamad|60 min|100 min|
|3.B|10.11.2022|Janick| 60 min| 90 min|
|4.A|10.11.2022|Janick, Mohamad, Joel| 60 min| 120 min|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
