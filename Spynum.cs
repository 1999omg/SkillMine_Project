using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Spynum
    {
        static void Main(string[] args)
        {
            // write code to chek num is spy ex  1412
            Console.WriteLine("enter number to chek ");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int sum1 = 0;
            int sum2 = 1;
            int count = 0;
            while (temp > 0)
            {
                int rem = 0;
                rem = temp % 10;
                temp = temp / 10;

                sum1 = sum1 + rem;
                sum2 = sum2 * rem;
                count++;
            }

                if (sum1 == sum2&& count>1)
                {
                    Console.WriteLine(num + "  is spy number ");

                }
                else

                    Console.WriteLine(num + "  is not  spy number ");



            

        }
        
    }
}
