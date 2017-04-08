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
                int vertical = Convert.ToInt32(Console.ReadLine());
                int horizontal = vertical;
                string[,] table = new string[vertical, horizontal];
                figure knight1 = new figure(4, 4);


                //Brett erstellen
                for (int i = 0; i < vertical; i++) //A B C D E F G H 
                {
                    for (int j = 0; j < horizontal; j++) //  1 2 3 4 5 6 7 8
                    {
                        if ((i + j) % 2 == 0)
                        {
                            table[i, j] = "[ ]";
                        }
                        else
                        {
                            table[i, j] = "[■]";
                        }
                    }
                }


                //Brett anzeigen lassen
                knight1.move1();
                Console.WriteLine("X= " + knight1.XPosition);
                Console.WriteLine("Y= " + knight1.YPosition);
                for (int i = 0; i < horizontal; i++)
                {
                    for (int j = 0; j < vertical; j++)
                    {
                        if (knight1.XPosition == j && knight1.YPosition == i)
                        {
                            table[i, j] = "[K]";
                        }
                        Console.Write(table[i, j]);
                    }
                    Console.WriteLine();
                }
                knight1.move1();
                Console.WriteLine();
                Console.WriteLine("X= " + knight1.XPosition);
                Console.WriteLine("Y= " + knight1.YPosition);
                for (int i = 0; i < horizontal; i++)
                {
                    for (int j = 0; j < vertical; j++)
                    {
                        if (knight1.XPosition == j && knight1.YPosition == i)
                        {
                            table[i, j] = "[K]";
                        }
                        Console.Write(table[i, j]);
                    }
                    Console.WriteLine();
                }




            }
            catch (FormatException)
            {
                Console.WriteLine("fuck you. nutz ne zahl du pimmel");
            }
            
            
        }
    }
}
