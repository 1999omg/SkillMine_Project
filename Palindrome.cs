using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            // write code for print up to 100 palindrome number 
            Console.WriteLine("enter maximum number up to print palindrome number ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num ; i++)
            {
                int rev = 0;
                int temp = i;
                while (temp > 0)
                {
                    int rem = 0;
                    rem = temp % 10;
                    rev = rev * 10 + rem;
                    temp = temp / 10;
                    if (i == rev)
                    {
                        Console.WriteLine(i);

                    }
                }
                
               
            }
        }
    }
}
