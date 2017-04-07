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
            
            Console.WriteLine("Bitte Zahl eingeben: ");

            int vertical = Convert.ToInt32(Console.ReadLine());
            int horizontal = vertical;
            string[,] table = new string[vertical, horizontal];
             
            for(int i=0; i<vertical; i++) //A B C D E F G H 
            {
                for(int j=0; j<horizontal; j++) //  1 2 3 4 5 6 7 8
                {
                    if ((i+j)%2 == 0)
                    {
                        table[i, j] = "[ ]";
                    }
                    else
                    {
                        table[i, j] = "[.]";
                    }
                }
            }
            for (int i=0; i<horizontal; i++)
            {
                for (int j=0; j<vertical; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
