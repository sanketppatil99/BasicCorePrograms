using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        public static void flipCoin()
        {
            int HeadCount = 0;
            int TailCount = 0;
            Console.WriteLine("Enter the number of times to Flip Coin =  ");
            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 0)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                }
                Console.WriteLine("Toatal HeadCount is = " + HeadCount);
                Console.WriteLine("Toatl TailCount is = " + TailCount);

                double HeadPercentage = HeadCount * 100 / flipCoin;
                double TailPercentage = TailCount * 100 / flipCoin;

                Console.WriteLine("HeadPercentage is = {0}%", HeadPercentage);
                Console.WriteLine("TailPercentage is = {0}%", TailPercentage);

            }
            else
            {
                Console.WriteLine("Enter the greater than Zero");
            }
        }
    }
}
