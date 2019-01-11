using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012OSQuestion6
{
    class Program
    {
        static void Main(string[] args)
        {

            int answer = 0;
            int column = 8;

            for (int i = 0; i < answer; i++)
            {
                int bit;
                Console.WriteLine("enter a bit value");
                bit = Convert.ToInt32(Console.ReadLine());

                answer = answer + (column*bit);
                column = column / 2;
            }

            if (column < 1) 
            {
                Console.WriteLine("decimal value is: " + answer);
                Console.ReadLine();
            }
            else
            {

            }

        }
    }
}
