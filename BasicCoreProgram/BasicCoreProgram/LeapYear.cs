using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("Enter the Year in 4 Digit Number = ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y % 4 == 0)
            {
                Console.WriteLine("{0} is LeapYear", y);
            }
            else if (y % 100 == 0)
            {
                Console.WriteLine("{0} is not leapYear", y);
            }
            else if (y % 400 == 0)
            {
                Console.WriteLine("{0} is LeapYear", y);
            }
            else
            {
                Console.WriteLine("{0} is not LeapYear", y);
            }
        }
    }
}
