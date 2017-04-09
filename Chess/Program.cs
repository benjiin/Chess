using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bitte Grösse des Spielfeld bestimmen: ");
                int vertical = 8; // Convert.ToInt32(Console.ReadLine());
                int horizontal = vertical;
                string[,] table = new string[vertical, horizontal];
                figure knight1 = new figure(0, vertical-1);

                
                void show()
                {
                    Console.WriteLine("X= " + knight1.XPosition);
                    Console.WriteLine("Y= " + knight1.YPosition);
                    for (int i = 0; i < horizontal; i++)
                    {
                        for (int j = 0; j < vertical; j++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                table[i, j] = "[ ]";
                            }
                            else
                            {
                                table[i, j] = "[■]";
                            }
                            if (knight1.XPosition == j && knight1.YPosition == i)
                            {
                                table[i, j] = "[K]";
                            }
                            Console.Write(table[i, j]);
                        }
                        Console.WriteLine();
                    }

                }
                show();
                while (true)
                {
                    Console.WriteLine("" +
                        "E: 2 links + 1 hoch \n" +
                        "R: 1 links + 2 hoch \n" +
                        "T: 1 rechts + 2 hoch \n" +
                        "G: 2 rechts + 1 hoch\n" +
                        "B: 2 rechts + 1 runter\n" +
                        "V: 1 rechts + 2 runter\n" +
                        "C: 1 links + 2 runter \n" +
                        "D: 2 links + 1 runter\n");
                    Console.WriteLine("Bitte Ihren nächsten Zug angeben: ");

                    ConsoleKeyInfo input = Console.ReadKey();
                   

                    switch (input.Key)
                    {
                        case ConsoleKey.R:
                            if(!(knight1.XPosition > horizontal) && !(knight1.YPosition > vertical) || knight1.YPosition < 0 && knight1.XPosition < 0)
                            knight1.move6();
                            break;
                        case ConsoleKey.T:
                            knight1.move5();
                            break;
                        case ConsoleKey.G:
                            knight1.move4();
                            break;
                        case ConsoleKey.B:
                            knight1.move3();
                            break;
                        case ConsoleKey.V:
                            knight1.move2();
                            break;
                        case ConsoleKey.C:
                            knight1.move1();
                            break;
                        case ConsoleKey.D:
                            knight1.move8();
                            break;
                        case ConsoleKey.E:
                            knight1.move7();
                            break;
                        default:
                            break;
                    }
                    show();

                }
               
              

            }
            catch (FormatException)
            {
                Console.WriteLine("fuck you. nutz ne zahl du pimmel");
            }
            
            
        }
    }
}
