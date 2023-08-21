using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit
{
    internal class Spielverlauf
    {
        Story myStroy = new Story();
        public string StoryVerlauf()
        {
            myStroy.Einleitung1();
            do
            {
                string entscheidung = myStroy.ErsteKapitel();

                if (entscheidung == "a")
                {
                    entscheidung = myStroy.ZweiteKapitel();

                    if (entscheidung == "a")
                    {
                        entscheidung = myStroy.VierteKapitel();

                        if (entscheidung == "a")
                        {
                            entscheidung = myStroy.AchteKapitel();

                            if (entscheidung == "a")
                            {
                                myStroy.Ende_c();
                            }
                            else if (entscheidung == "b")
                            {
                                entscheidung = myStroy.NeunteKapitel();

                                if (entscheidung == "a")
                                {
                                    entscheidung = myStroy.ElfteKapitel();

                                    if (entscheidung == "a")
                                    {
                                        myStroy.Ende_e();
                                    }
                                    else if (entscheidung == "b")
                                    {
                                        myStroy.Ende_f();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Da ist etwas schief gelaufen,Bitte gebe a oder b ein.\nBitte mit         der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                        Console.ReadLine();
                                    }

                                }
                                else if (entscheidung == "b")
                                {
                                    entscheidung = myStroy.ZehnteKapitel();

                                    if (entscheidung == "a")
                                    {
                                        myStroy.Ende_d();
                                    }
                                    else if (entscheidung == "b")
                                    {
                                        entscheidung = myStroy.ElfteKapitel();

                                        if (entscheidung == "a")
                                        {
                                            myStroy.Ende_e();
                                        }
                                        else if (entscheidung == "b")
                                        {
                                            myStroy.Ende_f();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte            mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                            Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit        der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                        Console.ReadLine();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der    Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                    Console.ReadLine();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                Console.ReadLine();
                            }
                        }
                        else if (entscheidung == "b")
                        {
                            entscheidung = myStroy.NeunteKapitel();

                            if (entscheidung == "a")
                            {
                                entscheidung = myStroy.ElfteKapitel();

                                if (entscheidung == "a")
                                {
                                    myStroy.Ende_e();
                                }
                                else if (entscheidung == "b")
                                {
                                    myStroy.Ende_f();
                                }
                                else
                                {
                                    Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der    Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                    Console.ReadLine();
                                }

                            }
                            else if (entscheidung == "b")
                            {
                                entscheidung = myStroy.ZehnteKapitel();

                                if (entscheidung == "a")
                                {
                                    myStroy.Ende_d();
                                }
                                else if (entscheidung == "b")
                                {
                                    entscheidung = myStroy.ElfteKapitel();

                                    if (entscheidung == "a")
                                    {
                                        myStroy.Ende_e();
                                    }
                                    else if (entscheidung == "b")
                                    {
                                        myStroy.Ende_f();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit        der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                        Console.ReadLine();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der    Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                    Console.ReadLine();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                            Console.ReadLine();
                        }
                    }
                    else if (entscheidung == "b")
                    {
                        entscheidung = myStroy.FuenfteKapitel();

                        if (entscheidung == "a")
                        {
                            entscheidung = myStroy.ZehnteKapitel();

                            if (entscheidung == "a")
                            {
                                myStroy.Ende_d();
                            }
                            else if (entscheidung == "b")
                            {
                                entscheidung = myStroy.ElfteKapitel();

                                if (entscheidung == "a")
                                {
                                    myStroy.Ende_e();
                                }
                                else if (entscheidung == "b")
                                {
                                    myStroy.Ende_f();
                                }
                                else
                                {
                                    Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der    Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit derEnter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                Console.ReadLine();
                            }
                        }
                        else if (entscheidung == "b")
                        {
                            entscheidung = myStroy.ElfteKapitel();

                            if (entscheidung == "a")
                            {
                                myStroy.Ende_e();
                            }
                            else if (entscheidung == "b")
                            {
                                myStroy.Ende_f();
                            }
                            else
                            {
                                Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                        Console.ReadLine();
                    }
                }
                else if (entscheidung == "b")
                {
                    entscheidung = myStroy.DritteKapitel();

                    if (entscheidung == "a")
                    {
                        entscheidung = myStroy.SechsteKapitel();

                        if (entscheidung == "a")
                        {
                            myStroy.Ende_a();
                        }
                        else if (entscheidung == "b")
                        {
                            entscheidung = myStroy.SiebteKapitel();

                            if (entscheidung == "a")
                            {
                                entscheidung = myStroy.ElfteKapitel();

                                if (entscheidung == "a")
                                {
                                    myStroy.Ende_e();
                                }
                                else if (entscheidung == "b")
                                {
                                    myStroy.Ende_f();
                                }
                                else
                                {
                                    Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                    Console.ReadLine();
                                }
                            }
                            else if (entscheidung == "b")
                            {
                                myStroy.Ende_b();
                            }
                            else
                            {
                                Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (entscheidung == "b")
                    {
                        entscheidung = myStroy.SiebteKapitel();
                    }
                    else
                    {
                        Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Da ist etwas schief gelaufen, Bitte gebe a oder b ein.\nBitte mit der Enter Taste bestätigen,damit das Programm neu gestartet werden kann.");
                    Console.ReadLine();
                }
            }
            while (true);

        }
    }
}
