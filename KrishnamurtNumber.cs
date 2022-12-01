using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class KrishnamurtNumber

    {
        // 145 · = 1! + 4! + 5! · = 1 + ( 4 * 3 * 2 * 1 ) + ( 5 * 4 * 3 * 2 * 1 ) · = 1 + 24 + 120 · = 145.
        static void Main(string[] args)
        {
            Console.WriteLine("enter number ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum2 = 0;
            
            while (temp > 0)
            {
                int sum = 1;
                int rem = 0;
                rem = temp % 10;
                temp = temp / 10;
                for (int i = 1; i <= rem; i++)
                {
                    sum = sum * i;
                }
                 sum2 =sum2+sum;
                

            }
            if (sum2 == num)
            {
                Console.WriteLine(num + "  is krishnamurti number ");
            }
            else
                Console.WriteLine( num+"  is not krishnamurti number ");
        }
    }
}
