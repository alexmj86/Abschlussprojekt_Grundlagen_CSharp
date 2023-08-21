using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit
{
    internal class Story
    {
        Charakter myCharakter = new Charakter();

        ///////////////////Einleitung
        ////
        public void Einleitung1()
        {
            Console.WriteLine(value: "Wilkommen in \"Hacker's Dilemma: Ein interaktives Spielbuch.\"\nDich erwartet ein kleines Abenteuer mit insgesamt 6 verschiedenen Enden.\n");
            Console.WriteLine(value: "  ██████╗ ██╗░░░██╗░██████╗░░█████╗░███╗░░░███╗");
            Console.WriteLine(value: "  ██╔══██╗██║░░░██║██╔══██╗██╔══██╗████╗░████║");
            Console.WriteLine(value: "  ██████╔╝██║░░░██║██████╔╝███████║██╔████╔██║");
            Console.WriteLine(value: "  ██╔═══╝░██║░░░██║██╔═══╝░██╔══██║██║╚██╔╝██║");
            Console.WriteLine(value: "  ██║░░░░░╚██████╔╝██║░░░░░██║░░██║██║░╚═╝░██║");
            Console.WriteLine(value: "  ╚═╝░░░░░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═╝░░░░░░╚═╝");
            Console.WriteLine(value: "\nDrücke Enter um zu bestätigen.\n\n");
            Console.ReadLine();

            Console.WriteLine("Beginnen wir erstmal damit deinen Charakter zu erstellen.\n");
            myCharakter.AbfrageName();
            Console.WriteLine( "Bitte gebe dein Alter ein.\n");
            myCharakter.AbfrageAlter();
            Console.WriteLine(value: "Welches Handy hast du?\n");
            myCharakter.AbfrageHandy();
        }
    
        /////////////////////Kapitel_1
        ///
        public string ErsteKapitel()
        {

            Console.WriteLine("Drücke die Enter um das Spiel zu starten.\n\n");
            Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Beginnen wir mit Kaptel 1: \"Der Anfang\"\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine($"Hallo {myCharakter.Name} du bist ein Hacker der {myCharakter.Alter} Jahre jung ist, der ist sich auf geheime Regierungsdaten spezialisiert hat.\nEines Tages erhältst du von einer unbekannten Person eine Nachricht auf dein Handy {myCharakter.Handy}.\nDie Person behauptet, dass sie dir helfen kann, an noch geheimere Informationen zu gelangen.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Ignoriere die Nachricht und geh weiterhin allein auf Geheimdienst-Missionen (Weiter zu Kapitel 2).");
            Console.WriteLine("b) Nimm die Hilfe an und arbeite mit der unbekannten Person zusammen (Weiter zu Kapitel 3).");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungErsteKapitel = Console.ReadLine().ToLower();

            if (entscheidungErsteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 2 \"Der Geheimdienst-Einsatz\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungErsteKapitel;
            }
            else if (entscheidungErsteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 3 \"Die Zusammenarbeit\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungErsteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungErsteKapitel;

            }
        }

        /////////////////////Kapitel_2
        ///
        public string ZweiteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 2: \"Der Geheimdienst-Einsatz\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du bist auf einer Geheimdienst-Mission und musst in ein Gebäude einbrechen, um an wichtige Daten zu gelangen.\nEs gibt jedoch viele Alarmsysteme und Sicherheitskameras. Du stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Schalte alle Alarmsysteme und Kameras aus. (Weiter zu Kapitel 4)");
            Console.WriteLine("b) Versuche, die Systeme zu umgehen und heimlich ins Gebäude zu gelangen. (Weiter zu Kapitel 5)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungZweiteKapitel = Console.ReadLine().ToLower();

            if (entscheidungZweiteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 4 \"Der Alarm\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungZweiteKapitel;
            }
            else if (entscheidungZweiteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 5 \"Der Fluchtversuch\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungZweiteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungZweiteKapitel;
            }
        }

        /////////////////////Kapitel_3
        ///
        public string DritteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 3: \"Die Zusammenarbeit\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du arbeitest nun mit der unbekannten Person zusammen, die sich als eine Regierungsangestellte entpuppt.\nSie gibt dir Zugang zu einem hochsicheren Netzwerk, auf dem sich viele geheime Daten befinden. Du stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Gehe direkt zu den Daten, die du benötigst. (Weiter zu Kapitel 6)");
            Console.WriteLine("b) Erkunde das Netzwerk und sieh dir alle Daten an. (Weiter zu Kapitel 7)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungDritteKapitel = Console.ReadLine().ToLower();

            if (entscheidungDritteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 6 \"Die Entdeckung\"\n");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungDritteKapitel;
            }
            else if (entscheidungDritteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 7 \"Die Enthüllung\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungDritteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungDritteKapitel;
            }
        }

        /////////////////////Kapitel_4
        ///
        public string VierteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 4: \"Der Alarm\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine($"Du hast alle Alarmsysteme und Kameras mit deinem Handy {myCharakter.Handy} ausgeschaltet und bist in das Gebäude eingebrochen.\nDoch plötzlich geht der Alarm los. Du stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Versuche, den Alarm auszuschalten und weiterzumachen. (Weiter zu Kapitel 8) ");
            Console.WriteLine("b) Verlasse das Gebäude und breche die Mission ab. (Weiter zu Kapitel 9)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungVierteKapitel = Console.ReadLine().ToLower();

            if (entscheidungVierteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 8 \"Die Deaktivierung\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungVierteKapitel;
            }
            else if (entscheidungVierteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 9 \"Die Festnahme\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungVierteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungVierteKapitel;
            }
        }

        /////////////////////Kapitel_5
        ///
        public string FuenfteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 5: \"Der Fluchtversuch\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine(" Du hast versucht, die Systeme zu umgehen, aber ein Wachmann hat dich bemerkt und verfolgt dich nun.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Versuche, den Wachmann abzuschütteln und weiterzumachen. (Weiter zu Kapitel 10)");
            Console.WriteLine("b) Gib auf und lasse dich verhaften. (Weiter zu Kapitel 11)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungFuenfteKapitel = Console.ReadLine().ToLower();

            if (entscheidungFuenfteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 10 \"Die Flucht\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungFuenfteKapitel;
            }
            else if (entscheidungFuenfteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 11 \"Die Konsequenzen\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungFuenfteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungFuenfteKapitel;
            }
        }

        /////////////////////Kapitel_6
        ///
        public string SechsteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im Kapitel 6: \"Die Entdeckung\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du hast direkt die benötigten Daten gefunden, aber dabei auch etwas viel Größeres entdeckt.\nDie Regierung plant einen geheimen Angriff auf ein anderes Land. Du stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Veröffentliche die Informationen über den geplanten Angriff, um die Weltöffentlichkeit zu informieren. (Weiter zu Kapitel 12a)");
            Console.WriteLine("b) Ignoriere die Informationen und konzentriere dich nur auf deine ursprüngliche Mission. (Weiter zu Kapitel 7)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungSechsteKapitel = Console.ReadLine().ToLower();

            if (entscheidungSechsteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 12a \"Das Ende!\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungSechsteKapitel;
            }
            else if (entscheidungSechsteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 7 \"Die Enthüllung\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungSechsteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungSechsteKapitel;
            }
        }

        /////////////////////Kapitel_7
        ///
        public string SiebteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 7: \"Die Enthüllung\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du hast das Netzwerk weiter erkundet und viele brisante Informationen gefunden.\nDu könntest sie nutzen, um Rache an denjenigen zu nehmen, die dir in der Vergangenheit Unrecht getan haben.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Nutze die Informationen, um Rache zu nehmen. (Weiter zu Kapitel 11)");
            Console.WriteLine("b) Entscheide dich dagegen und handle moralisch richtig. (Weiter zu Kapitel 12b)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungSiebteKapitel = Console.ReadLine().ToLower();

            if (entscheidungSiebteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 11 \"Die Konsequenzen\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungSiebteKapitel;
            }
            else if (entscheidungSiebteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 12b \"Das Ende!\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungSiebteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungSiebteKapitel;
            }
        }

        /////////////////////Kapitel_8
        ///
        public string AchteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 8: \"Die Deaktivierung\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du hast den Alarm erfolgreich ausgeschaltet und kannst nun weiterhin unentdeckt das Gebäude durchsuchen.\nDu findest die gewünschten Daten und kannst sie kopieren.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Verlasse unauffällig das Gebäude mit den Daten. (Weiter zu Kapitel 12c)");
            Console.WriteLine("b) Suche nach weiteren Informationen, bevor du das Gebäude verlässt. (Weiter zu Kapitel 9)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungAchteKapitel = Console.ReadLine().ToLower();

            if (entscheidungAchteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 12c \"Das Ende!\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungAchteKapitel;
            }
            else if (entscheidungAchteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 9 \"Die Festnahme\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungAchteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungAchteKapitel;
            }
        }

        /////////////////////Kapitel_9
        ///
        public string NeunteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 9: \"Die Festnahme\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du hast versucht, den Wachmann abzuschütteln, aber er hat dich erwischt. Du wirst verhaftet und inhaftiert.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Versuche aus dem Gefängnis auszubrechen. (Weiter zu Kapitel 11)");
            Console.WriteLine("b) Warte ab und hoffe auf eine Gelegenheit zur Flucht. (Weiter zu Kapitel 10)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungNeunteKapitel = Console.ReadLine().ToLower();

            if (entscheidungNeunteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 11 \"Die Konsequenzen\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungNeunteKapitel;
            }
            else if (entscheidungNeunteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 10 \"Die Flucht\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungNeunteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungNeunteKapitel;
            }
        }

        /////////////////////Kapitel_10
        ///
        public string ZehnteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 10: \"Die Flucht\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Du hast eine Gelegenheit zur Flucht genutzt und bist aus dem Gebäude entkommen.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Fliehe aus dem Land und beginne ein neues Leben im Ausland. (Weiter zu Kapitel 12d) ");
            Console.WriteLine("b) Kehre in deine Heimat zurück und versuche, deine Unschuld zu beweisen. (Weiter zu Kapitel 11)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungZehnteKapitel = Console.ReadLine().ToLower();

            if (entscheidungZehnteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zuKapitel 12d \"Das Ende!\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungZehnteKapitel;
            }
            else if (entscheidungZehnteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 11 \"Die Konsequenzen\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungZehnteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungZehnteKapitel;
            }
        }

        /////////////////////Kapitel_11
        ///
        public string ElfteKapitel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wilkommen im  Kapitel 11: \"Die Konsequenzen\"\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Egal ob du verhaftet wurdest oder Rache genommen hast, deine Handlungen haben Konsequenzen.\nDu wirst vor Gericht gestellt und verurteilt.\nDu stehst nun vor der Entscheidung.\n");
            Console.WriteLine("a) Akzeptiere das Urteil und lebe mit den Konsequenzen. (Weiter zu Kapitel 12e) ");
            Console.WriteLine("b) Versuche, das Urteil anzufechten und deine Unschuld zu beweisen. (Weiter zu Kapitel 12f)");

            Console.WriteLine("Gebe a oder b ein.");
            string entscheidungElfteKapitel = Console.ReadLine().ToLower();

            if (entscheidungElfteKapitel == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Weiter zu Kapitel 12e \"Das Ende!\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungElfteKapitel;
            }
            else if (entscheidungElfteKapitel == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Weiter zu Kapitel 12f \"Das Ende!\"");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                return entscheidungElfteKapitel;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen.");
                return entscheidungElfteKapitel;
            }
        }

        /////////////////////Ende 12a
        ///
        public void Ende_a()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du hast direkt die benötigten Daten gefunden, aber dabei auch etwas viel Größeres entdeckt.\nDie Regierung plant einen geheimen Angriff auf ein anderes Land.\nDu entscheidest dich, die Informationen zu veröffentlichen, um die Weltöffentlichkeit zu informieren.\nTrotz Verfolgung und Drohungen gelingt es dir, den geplanten Angriff zu verhindern.\nDu wirst als Held gefeiert und inspirierst andere, für ihre Überzeugungen einzustehen.\n\nVielen Dank, dass du diese Geschichte gespielt hast!\nDu kannst jederzeit von vorne beginnen und andere Entscheidungen treffen, um neue Abenteuer zu erleben!\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wenn du das Spiel nochmal starten willst dann Bitte mit Enter bestätigen, ansonsten \"CIAO\" bis zum nächsten mal.");
            Console.ReadLine();
        }

        /////////////////////Ende 12b
        ///
        public void Ende_b()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du hast das Netzwerk weiter erkundet und viele brisante Informationen gefunden\nDu könntest sie nutzen, um Rache an denjenigen zu nehmen, die dir in der Vergangenheit Unrecht getan haben.\nDoch du entscheidest dich dagegen und handelst moralisch richtig.\nDu arbeitest mit anderen Hackern und Aktivisten zusammen, um die Informationen verantwortungsvoll zu nutzen und Missstände aufzudecken.\nDu fühlst dich erleichtert und stolz, positive Veränderungen herbeigeführt zu haben.\n\nVielen Dank, dass du diese Geschichte gespielt hast!\nDu kannst jederzeit von vorne beginnen und andere Entscheidungen treffen, um neue Abenteuer zu erleben!\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wenn du das Spiel nochmal starten willst dann Bitte mit Enter bestätigen, ansonsten \"CIAO\" bis zum nächsten mal.");
            Console.ReadLine();
        }

        /////////////////////Ende 12c
        ///
        public void Ende_c()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du hast den Alarm ausgeschaltet und erfolgreich die gewünschten Daten kopiert.\nDu stehst nun vor der Entscheidung, unauffällig das Gebäude zu verlassen und mit den Daten zu entkommen.\nDu entscheidest dich dafür und nutzt dein Wissen, um unbemerkt das Gebäude zu verlassen.\nMit den Daten in deinem Besitz verschwindest du in den Schatten und kommst unentdeckt davon.\n\nVielen Dank, dass du diese Geschichte gespielt hast!\nDu kannst jederzeit von vorne beginnen und andere Entscheidungen treffen, um neue Abenteuer zu erleben!\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wenn du das Spiel nochmal starten willst dann Bitte mit Enter bestätigen, ansonsten \"CIAO\" bis zum nächsten mal.");
            Console.ReadLine();
        }

        /////////////////////Ende 12d
        ///
        public void Ende_d()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du nutzt die Gelegenheit zur Flucht und entkommst aus dem Gebäude. Du entscheidest dich, aus dem Land zu fliehen und ein neues Leben im Ausland zu beginnen.\nDu setzt deine Hacker-Fähigkeiten ein, um deine Identität zu verschleiern und erfolgreich die Grenzen zu überqueren.\nIm Ausland startest du ein neues Leben und baust dir ein neues Netzwerk von Hackern auf, um deine Ziele zu verfolgen. Das ist das Ende deines Hacker-Abenteuers mit einem neuanfangenden Ausgang.\n\nVielen Dank, dass du diese Geschichte gespielt hast!\nDu kannst jederzeit von vorne beginnen und andere Entscheidungen treffen, um neue Abenteuer zu erleben!\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wenn du das Spiel nochmal starten willst dann Bitte mit Enter bestätigen, ansonsten \"CIAO\" bis zum nächsten mal.");
            Console.ReadLine();
        }

        /////////////////////Ende 12e
        ///
        public void Ende_e()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du akzeptierst das Urteil und lebst mit den Konsequenzen. Du wirst zu einer langen Haftstrafe verurteilt und verbringst Jahre im Gefängnis.\nTrotz der Herausforderungen entwickelst du neue Fähigkeiten und nutzt deine Hacker-Kenntnisse, um anderen zu helfen.\nDu baust dir Respekt und Anerkennung auf, kommst zur Bewährung frei und beginnst ein neues Leben, um aus deinen Fehlern zu lernen und ein besserer Mensch zu sein.\n\nVielen Dank, dass du diese Geschichte gespielt hast!\nDu kannst jederzeit von vorne beginnen und andere Entscheidungen treffen, um neue Abenteuer zu erleben!\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wenn du das Spiel nochmal starten willst dann Bitte mit Enter bestätigen, ansonsten \"CIAO\" bis zum nächsten mal.");
            Console.ReadLine();
        }

        /////////////////////Ende 12f
        ///
        public void Ende_f()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du entscheidest dich, das Urteil anzufechten und deine Unschuld zu beweisen.\nMit Unterstützung von engagierten Anwälten und hartem Kampf gelingt es dir, neue Beweise vorzulegen und Zweifel an deiner Schuld zu wecken.\nNach einem langwierigen Prozess wird das Urteil aufgehoben und du wirst freigesprochen.\nDu rehabilitierst deinen Ruf und erhältst Entschädigung für die zu Unrecht erlittene Haft.\nDu nutzt diese Erfahrung, um für Gerechtigkeit einzutreten und als Aktivist für Datenschutz und Cyber-Sicherheit aktiv zu werden.\n\nVielen Dank, dass du diese Geschichte gespielt hast!\nDu kannst jederzeit von vorne beginnen und andere Entscheidungen treffen, um neue Abenteuer zu erleben!\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wenn du das Spiel nochmal starten willst dann Bitte mit Enter bestätigen, ansonsten \"CIAO\" bis zum nächsten mal.");
            Console.ReadLine();
        }
    }
}
