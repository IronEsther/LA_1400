# LA_1400

In diesem Portfolioeintrag werde ich Ihnen zeigen, was für ein Projekt unsere Gruppe (IceCream) gewählt und wie ich Windows Forms in unserem Spiel benutzt habe.

# Einführung

Wir (Gruppe IceCream) haben das Projekt gewählt, als basis ein Hütchenspiel `C#` in `Windows Forms` zu programmieren. In dieser Gruppenarbeit haben wir jedoch auch entschieden, dass wir andere Spiele, wie z.B. 'Higher-Lower-Game' und 'Random-Number-Game', hinzufügen. Im Random-Number-Game muss der Benutzer eine vom Computer zufällig generierte Zahl herausfinden und in einem Textfeld hineinschreiben. 


**Ziele**
1. Der Leser lernt, wie `Windows Forms` in `C#` funktioniert und wofür man es einsetzt.
2. Der Leser weiss, wie man mit `Windows Forms` richtig umgeht.

**Windows Forms**

`Windows Forms` ist neben der 'normalen' Konsole ein Programm in `C#`, der dem Benutzer ermöglicht, in verschiedenen Feldern Features einzufügen. Mit `Windows Forms` kann man mir den Feautures wie in der Konsole den Benutzer für eine Eingabe auffordern, jedoch kann man mit den Labels und anderen Sachen die Gestaltung schöner und übersichtlicher als auf der Konsole machen. Es ermöglicht auch die Erstellung grafischer Benutzeroberflächen für Windows.

Einige Beispiele für die Features sind folgende:
- Textbox --> Für die Eingabe der Benutzers
- Button --> Für das Drücken 
- Label --> Für einer Ausgabe des Programms für den Benutzer

`Windows Forms` funktioniert in `C#` so:
- Man erstellt ein neues Projekt in Windows Forms
- Dabei lädt das Programm eine neue Seite: das Design.
- Auf dieser Seite erscheint dann ein neues 'Forms', die man beliebig unbenennen kann. 
- Dort kann man dann beim Kästchen `Toolbox` verschiedene Grafiken auswählen und hineinfügen.
- Um vom Design zum Code zu wechseln, muss man bei der gewünschten Grafik doppelklicken, danach erscheint der Code von diesem Design

Hier zeige ich Ihnen ein Beispiel dafür aus meinem Projekt:
![image](https://user-images.githubusercontent.com/89132005/147062604-9253b850-4f9f-427a-8723-7aab2185a85a.png)

**Wie geht man mit `Windows Forms` um?**

`Windows Forms` funktioniert fast gleich wie die Konsole in `C#`, jedoch der einzige Unterschied ist, dass man den Code in den dazugehörigen Designs einfügen kann. Dass heisst, dass man z.B. den Code für den Button nicht beim Code für die Ausgabe einfügen kann.
Das bedeutet, dass man beim Code schreiben beachten muss, dass man es beim richtigen Design hineinschreibt. 
Das Programm vom Design stürzt auch ab, wenn man im Code den Namen eines Grafikes ändert, dies jedoch nicht bei der Grafik selber tut. Wenn man das macht, dann kommt eine Fehlermeldung des Systems. Bis man den Fehler nicht fixiert hat, lädt das Design nicht. Dies ist ziemlich mühsam, deshalb würde ich Ihnen abraten, dies zu tun. 
Sonst ist `Windows Forms` ziemlich ähnlich wie die Konsole, es hat jedoch andere Namen für die Ausgabe eines Textes als die Konsole. 

Hier zeige ich Ihnen ein Auschnitt von meinem Code für den Button:

```csharp
private void btn_(object sender, EventArgs e)
  try
  {
     int guessed = Convert.ToInt32(txtEnterNumber.Text);
     
     if (guessed == randomNumber)
     {
         MessageBox.Show("Nice, you guessed the secret number. If you want to try another, just click 'Next'");
         txtEnterNumber.Text = "";
         guesses = guesses - 1;
     }
     else if (guessed > randomNumber && guessed > 0 && guessed <= 100)
     {
         MessageBox.Show("You're thinking too high.");
     }
     else if (guessed < randomNumber && guessed <= 100 && guessed > 0)
     {
         MessageBox.Show("You're thinking too low.");
     }
     else
     {
         MessageBox.Show("Please enter a valide number.");
     }
  }
  catch
  {
      MessageBox.Show("Please enter a number");
  }
  
}
```
**Verifikation**

Ziel 1. Im Block 'Windows Forms' wird erklärt, was Windows Forms ist und für was man es benutzt.
Ziel 2. Im Block 'Wie geht man mit `Windows Forms` um?' wird erklärt, wie man mit Windows Forms umgeht.

**Reflexion**

Ich fand die Gruppenarbeit sehr gut, da ich meine Mitschüler bei einem Problem nach Rat fragen konnte. Ich konnte mich auch sehr gut konzentrieren, da wir bei der Gruppenarbeit uns aufs Projekt und nicht auf irgendetwas anders fokusiert haben. Auch hat der Gruppenleiter uns Aufgaben gegeben, die wir bis zu einem Zeitpunkt erledigt haben müssen. Ich fand diese Methode ziemlich effektiv.

**Verbesserungsvorschlag**

Ich finde, dass wir diese Gruppenarbeit eigentlich gut gemacht haben, jedoch sind wir einmal nicht vorangekommen, da wir irgendwie alle Dateien nicht sauber zusammenfügen konnten und dadurch ein Chaos entstanden ist, den wir zuerst noch beheben mussten. 
