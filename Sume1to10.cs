using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Sume1to10
    {
        static void Main (string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.WriteLine("________________________________");


            // write code for display odd num from 120 to 81 
            for (int i = 120; i >= 81; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }




            // write code to count odd from 1 to 20
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("write code to count odd from 1 to 20");

            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);


        }
    }
}
