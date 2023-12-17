using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Projektarbeit
{
    internal class Charakter
    {
        // Private Felder zur Speicherung der Charakterinformationen
        private string name;
        private int alter;
        private string handy;

        // Eigenschaften (Properties) zum Lesen und Setzen der privaten Felder
        public string Name { get => name; private set => name = value; }
        public int Alter { get => alter; private set => alter = value; }
        public string Handy { get => handy; private set => handy = value; }

        // Methode zur Abfrage des Namens mit Konsolenausgabe und Validierung
        public string AbfrageName()
        {
            Console.WriteLine("Bitte gib deinen Namen ein.");
            Name = Console.ReadLine();

            if (Name.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nHallo {Name}!!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                return Name;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen");
                return Name;
            }
        }

        // Methode zur Abfrage des Alters mit Konsolenausgabe und Validierung
        public int AbfrageAlter()
        {
            Console.WriteLine("Gib bitte dein Alter ein.");
            Alter = Convert.ToInt32(Console.ReadLine());

            if (Alter >= 10 && Alter <= 99)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nDein Alter ist {Alter}\n");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                return Alter;
            }
            else if (Alter < 10)
            {
                Console.WriteLine("Du musst mindestens 10 Jahre alt sein!");
                return Alter;
            }
            else if (Alter > 99)
            {
                Console.WriteLine("Komm schon, wir wollen ja nicht übertreiben :)");
                return Alter;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen!");
                return Alter;
            }
        }

        // Methode zur Abfrage des Handys mit Konsolenausgabe und Validierung
        public string AbfrageHandy()
        {
            Console.WriteLine("Gib bitte an, welches Handy du hast.");
            Handy = Console.ReadLine();

            if (Handy.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nDu hast ein {Handy}!!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return Handy;
            }
            else
            {
                Console.WriteLine("Da ist etwas schief gelaufen");
                return Handy;
            }
        }
    }
}
