# LA_1200
# Projekt-Dokumentation


### Gruppe: Butterfly
Mitglieder: Joël Haldimann, Mohamad Amraya, Tim Kral, Janick Hurschler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  03.11.2022     | 0.1.0   |  Der Code ist jetzt soweit, dass er eine Datei mit Daten einlesen kann. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Programm in der Konsole, bei dem Anmeldungen für verschiedene Workshops eingelesen und zugeteilt werden.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    muss             |  funktionale Anforderung    | Als Benutzer will ich dem Programm eine Datei geben können, um die Zuteilung zu ermöglichen. |
| 2  |       muss          |  Qualitätsanforderung   |        Als Computer möchte ich erkennen, ob die Datei vollständig ist, um dem User einen möglichen Fehler mitzuteilen.                            |
| 3   |    muss             |  funktionale Anforderung    | Als Computer möchte ich dem User ausgeben, welche Person, welchen Workshop bekommt. |
| 4   |    kann             |  Qualitätsanforderung    | Als Computer möchte ich zählen, wie viele Personen sich eingetragen haben, um den User zu informieren fals es schon zu viele Teilnehmende hat. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm wurde Gestartet. | Ich gebe meinen Namen, und meine Prioritäten hinein        | Im Txt File werden mein Name und die Prioritäten angezeigt.                  |
| 1.2  | Es sind 20 User in einem Workshop eingetragen| Ich trage einen Weiteren Namen mit der 1. Priorität in diesem Workshop ein        | Der Name wird mit der zweiten Priorität abgespeichert.                   |
| 1.3  | Es sind weniger als 3 Users im Workshop eingetragen. | Ich trage meinen Namen in diesen Workshop ein. | Ich werde zu meiner 2. Priorität zugeteilt. |


### 1.4 Diagramme

![Screenshot 2022-10-27 103413](https://user-images.githubusercontent.com/111045792/198235501-023c56f7-9432-41ac-8d94-fcc40997807f.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  03.11.2022     |   Janick, Joel       |       Funktion zum Einlesen der Textdatei       |      45 min         |
|  1.B  |  03.11.2022     |    Tim       |       Die Daten der Textdatei sollen den verschiedene Variabeln zugeteilt werden       |       2 mal 45 min        |
|  2.A  |  10.11.2022     |     Janick, Joel      |   try-catch um mögliche Fehler zu vermeiden.         |      45 min         |
|  3.A  |  10.11.2022     |     Tim      |   Ausgabe in einer Externen Textdatei.        |      45 min         |
|  3.B  |  10.11.2022     |     Janick, Joel      |   Design der Externen Textdatei.         |      45 min         |
|  4.A  |   10.11.2022    |   Mohamad |     Zuteilung den Personen auf die Workshops |  45 min |     
Total: 28 Arbeitspakete


✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
