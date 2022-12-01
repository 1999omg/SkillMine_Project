using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class OddNum

    {
        static void Main(string[] args)
        {
            // write code to chek prime  number 
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)

                {
                    count++;
                }


            }
            if (count < 1)
            {
                Console.WriteLine(num + "  is prime");
            }
            else
                Console.WriteLine(num + "  is not prime ");


            
            
        }

    }
}
