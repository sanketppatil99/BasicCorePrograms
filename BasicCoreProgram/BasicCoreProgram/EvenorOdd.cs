using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenorOdd
    {
        public static void evenOrOdd()
        {
            Console.WriteLine("Enter the Number = ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("{0} is Even Number",a);
            else
                Console.WriteLine("{0} is Odd Number",a);
        }
    }
}
