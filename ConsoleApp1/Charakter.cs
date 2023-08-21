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
        private string name;
        private int alter;
        private string handy;

        public string Name { get => name; private set => name = value; }
        public int Alter { get => alter; private set => alter = value; }
        public string Handy { get => handy; private set => handy = value; }

        public string AbfrageName()
        {

            Console.WriteLine("Bitte gib dein Name ein. Dein Name darf Maximal 20 Zeichen haben.");
            Name = Console.ReadLine();

            if (Name.Length <= 20)
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

        public int AbfrageAlter()
        {

            Console.WriteLine("Gib Bitte dein Alter ein.");
            Alter = Convert.ToInt32(Console.ReadLine());

            if (Alter >= 10 && Alter <= 99)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nDein Alter ist {Alter}\n");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                return Alter;
            }
            else if (Alter < 12)
            {
                Console.WriteLine("Du musst mindestens 10 Jahre sein!");
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

        public string AbfrageHandy()
        {

            Console.WriteLine("Gib ein welches Handy du hast.");
            Handy = Console.ReadLine();

            if (Handy.Length >= 3)
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
