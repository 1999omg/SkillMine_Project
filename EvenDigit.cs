using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class EvenDigit
    {
        static void Main (string[]args)
        {
            // write code for sum of even digit from number and count even digit 

            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int count = 0;
            while (temp > 0)
            {
                int rem = 0;
                temp = temp / 10;
                
                rem = temp % 10;
                if (rem % 2 == 0)
                {
                    count++;
                    sum = sum + rem;
                    
                }
            }
            Console.WriteLine("sum of a even number is  " + sum + "  total even  number is   " + count);


        }
    }
}
