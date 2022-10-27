Gruppe: Janick Hurschler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 22.09.2022      | 1.0.0   |      Ich habe alle Testprotokolle durchgeführt und kann somit mein Programm erfolgreich abschliessen.              |
| 15.09.2022      | 0.0.3   |        Ich habe heute die restlichen 3 userstorys bearbeitet und somit die Grundanforderungen erledigt.                |
|  08.09.2022     |  0.0.2  |             Ich habe heute die ersten 2 Userstories verbessert und US 3 gemacht.                                               |
|  1.09.2022     |  0.0.1  |          Ich habe mich ins Programm eingefühlt. Und ich habe heute die ersten 2 Userstories erledigt.                                                  |

## 1 Informieren

### 1.1 Ihr Projekt

Eine Applikation in der Konsole, bei der man eine Zahl raten muss und das Programm dir sagt, ob sie richtig oder falsch war.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |       muss          |   Funktionale Anforderung   | Als ein Spieler möchte ich eine Zahl raten, damit ich die richtige Zahl treffe. |
| 2  |        muss         |   Funktionale Anforderung   | Als Computer möchte ich eine Zufallszahl generieren, die der Spieler erraten muss.                                    |
| 3    |       muss          |   Qualitätsanforderung   | Als Computer möchte ich dem Spieler ausgeben, ob seine eingegebene Zahl zu gross oder zu klein ist, damit er näher an die Zahl heran kommt. |
| 4    |       muss          |   Qualitätsanforderung   | Als Computer möchte ich dem Spieler ausgeben, wie viele versuche er gebraucht hat, damit er weiss, wie gut er war. |
| 5   |       muss          |   Funktionale Anforderung   | Als Computer möchte ich Fehleingaben erkennen können, damit ich dem Spieler den Fehler anzeigen kann. |
| 6   |       kann         |   Qualitätsanforderung    | Als Computer will ich dem Spieler die Möglichkeit geben, das Spiel neu zu starten, damit er nochmal spielen kann. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Eine Zahl ins Eingabefeld schreiben           |    17     |        Richtige Zahl/Zu klein/zu gross           |
| 2.1  |   Nachschauen, ob der Computer eine Zufallszahl generiert         |     Start    |        Zufallszahl (nicht sichtbar)           |
| 3.1  |   Eine Zahl eingeben           |    17     |        Zu klein/zu gross           |
| 4.1  |   richtige Zahl erraten        |   richtige zahl    |        Richtige Zahl/ du hast x versuche gebraucht           |
| 5.1  |   Fehleingabe machen       |    Bameninhong     |        schreiben Sie hier bitte nur Zahlen von 0 bis 100           |
| 6.1  |  Auf "Spiel neu starten" klicken          |    spiel neu starten    |        Spiel fängt nochmal von vorne an          |


### 1.4 Diagramme

<img width="586" alt="PAP_zahlenratspiel_screenshot" src="https://user-images.githubusercontent.com/111045598/186599281-890138bf-2e16-4be0-bebd-111f3c42f37d.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   01.09.2022    |     Janick      |      Eingabefeld für Spieler erstellen. Und alles beschriftet.       |       90 min        |
| 2.A  |    01.09.2022   |      Janick     |      Zufallszahl generieren und in Variable packen.        |        90 min       |
| 3.A  |    01.09.2022   |      Janick     |      Programmiert dass, wenn die eratene Zahl > Zufallszahl ist, dass das Programm ausgibt. Das gleiche mit <.       |        90 min       |
| 4.A  |    15.09.2022   |      Janick     |      "goto" zu Schleifen umschreiben        |        45 min       |
| 5.A  |    15.09.2022   |      Janick     |     try-catch erstellt um Fehleingaben zu erkennen.        |       2 mal 45 min       |
| 6.A  |    15.09.2022   |      Janick     |      Eine Schleife erstellen, wo der Spieler auch abgefragt wird, ob er nochmal Spielen will.        |        2 mal 45 min       |
Total:  6 Lektionen


## 3 Entscheiden

Ich habe mich dazu entschiede, die Grundanforderungen zu machen, weil ich noch keine Erfahrung im Programmieren habe. Vielleicht muss ich bei den US im Verlauf des Projektes noch etwas hinzufügen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  01.09.2022     |     Janick      |       90 min        |      ca   75 min          |
| 3.A  |    01.09.2022   |     Janick      |       90 min        |        ca  90 min         |
| 2.A  |    08.09.2022   |     Janick      |       90 min        |        ca  90 min         |
| 5.A  |    08.09.2022   |     Janick      |       90 min        |        ca  90 min         |
| 6.A  |    08.09.2022   |     Janick      |       90 min        |        ca  90 min         |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  22.09.2022     |    funktioniert      |   Janick     |
| 2.1  |   22.09.2022    |     funktioniert     |   Janick     |
| 3.1  |   22.09.2022    |     funktioniert     |   Janick     |
| 4.1  |   22.09.2022    |     funktioniert     |   Janick     |
| 5.1  |   22.09.2022    |     funktioniert     |   Janick     |
| 6.1  |   22.09.2022    |     funktioniert     |   Janick     |

Fazit: Es funktioniert alles einwandfrei.



## 6 Auswerten
