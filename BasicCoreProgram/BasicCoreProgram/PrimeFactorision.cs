using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class PrimeFactorision
    {
        public static void primeFactor()
        {
            int num;
            int count = 0;
            int flag = 0;
            Console.WriteLine("Enter a Number for prime factor : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime Factors of {0} ", num);
            for (int i = 2; i < num; i++)
            {
                // check for divisibility
                if (num % i == 0)
                {
                    count = 0;
                    // check for prime number
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }

        }
    }
}
