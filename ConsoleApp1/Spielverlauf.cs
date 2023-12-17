using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projektarbeit
{
    //Erstellen als eigene Projektmappe ein Abenteuerspiel.
    //Der Nutzer soll darin immer wieder vor Entscheidungen
    //gestellt werden, mit denen er den Verlauf der Handlung
    //bestimmt.
    //Je nachdem welche Entscheidung er trifft, wird er zu einer
    //anderen Szene geleitet, die wieder eine Entscheidung
    //verlangt.
    //Der Nutzer soll im Verlauf des Spiels mindestens drei
    //Entscheidungen treffen müssen.
    //Hier das zu Grunde liegende Konzept:
    //https://de.wikipedia.org/wiki/Spielbuch
    //Die Verwendung von Klassen wäre wünschenswert, vor allem
    //wenn du die Vertiefung in der Anwendungsentwicklung
    //durchführen möchtest. Das Programm darf jedoch auch
    //vollständig prozedural ablaufen, wenn es dir anders gar nicht
    //möglich ist.


    //Abgabe ist Mittwoch, der 26. April 2023 um 14:00 Uhr.


    internal class Spielverlauf
    {
        // Instanz der Story-Klasse erstellen
        Story myStory = new Story();

        // Methode zum Steuern des Spielverlaufs
        public string StoryVerlauf()
        {
            // Einleitung des Spiels aufrufen
            myStory.Einleitung1();

            // Endlosschleife für den Spielverlauf
            do
            {
                // Erstes Kapitel der Story aufrufen und Entscheidung des Spielers abrufen
                string entscheidung = myStory.ErsteKapitel();

                // Überprüfen der Spielerentscheidung im ersten Kapitel
                if (entscheidung == "a")
                {
                    // Zweites Kapitel aufrufen und Entscheidung des Spielers abrufen
                    entscheidung = myStory.ZweiteKapitel();

                    // Überprüfen der Spielerentscheidung im zweiten Kapitel
                    if (entscheidung == "a")
                    {
                        // Viertes Kapitel aufrufen und Entscheidung des Spielers abrufen
                        entscheidung = myStory.VierteKapitel();

                        // ... (und so weiter, verschachtelte Bedingungen für den Spielverlauf)

                    }
                    else if (entscheidung == "b")
                    {
                        // Neuntes Kapitel aufrufen und Entscheidung des Spielers abrufen
                        entscheidung = myStory.NeunteKapitel();

                        // ... (weitere verschachtelte Bedingungen für den Spielverlauf)

                    }
                    else
                    {
                        // Fehlermeldung bei ungültiger Eingabe
                        Console.WriteLine("Da ist etwas schief gelaufen. Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen, damit das Programm neu gestartet werden kann.");
                        Console.ReadLine();
                    }
                }
                else if (entscheidung == "b")
                {
                    // Drittes Kapitel aufrufen und Entscheidung des Spielers abrufen
                    entscheidung = myStory.DritteKapitel();

                    // ... (weitere Bedingungen für den Spielverlauf)

                }
                else
                {
                    // Fehlermeldung bei ungültiger Eingabe
                    Console.WriteLine("Da ist etwas schief gelaufen. Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen, damit das Programm neu gestartet werden kann.");
                    Console.ReadLine();
                }
            }
            // Endlosschleife (kann nur durch externe Faktoren, wie z.B. das Schließen des Programms, beendet werden)
            while (true);

        }
    }
}
