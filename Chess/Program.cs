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
                figure knight1 = new figure(4, 4);

                
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
                Console.WriteLine("Bitte Ihren nächsten Zug angeben: ");
                ConsoleKeyInfo input = Console.ReadKey();
                if(knight1.XPosition < 0 || knight1.XPosition > horizontal && knight1.YPosition < 0 || knight1.YPosition > horizontal)
                switch (input.Key)
                {
                    case ConsoleKey.R:
                            knight1.move6();
                        break;
                    default:
                        break;
                }
                show();

            }
            catch (FormatException)
            {
                Console.WriteLine("fuck you. nutz ne zahl du pimmel");
            }
            
            
        }
    }
}
