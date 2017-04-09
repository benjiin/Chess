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
                string input = String.Empty;

                 
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
                Console.WriteLine("Bitte Ihren nächsten Zug angeben: ");
                input = Convert.ToString(Console.ReadLine());
                switch (input)
                {
                    case "s":
                        Console.WriteLine("yes");
                        break;
                    default:
                        break;
                }




            }
            catch (FormatException)
            {
                Console.WriteLine("fuck you. nutz ne zahl du pimmel");
            }
            
            
        }
    }
}
