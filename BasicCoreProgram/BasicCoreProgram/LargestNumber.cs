using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class LargestNumber
    {
        public static void CheckLargestNumber()
        {
            int num1, num2, num3;

            Console.WriteLine("Find the largest of three number : ");
            Console.WriteLine("Input the 1st Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2st Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3st Number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("the 1st Number is gretest among three ");

                }
                else
                {
                    Console.WriteLine("the 3rd Number is gretest among three ");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("the 2nd Number is gretest among three ");
            }
            else
            {
                Console.WriteLine("the 3rd Number is gretest among three ");

            }

        }
    }
}
