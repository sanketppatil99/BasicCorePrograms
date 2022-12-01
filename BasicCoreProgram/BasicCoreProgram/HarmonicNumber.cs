using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class HarmonicNumber
    {
        public static void harmonicNumber()
        {
            Console.WriteLine("Enter Nth harmonic number  =  ");
            int n = Convert.ToInt32(Console.ReadLine());
            double nth = 0.0;

            if (n != 0)
            {
                for (double i = 1; i <= n; i++)                                  //Hn = Hn-1 + 1/n
                {

                    nth = nth + 1.0 / i;
                    //Console.WriteLine("{0}th Harmonic number is {1}", n , nth);
                }
                Console.WriteLine("{0}th Harmonic number is {1}", n, nth);

            }
            else
            {
                Console.WriteLine("Enter Number greater than zero ");
            }

        }
    }
}