using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class DissariumNumber
    {
        static void Main (string[] args)
        {
            // write code to chek dissarium number  89
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            int sum = 1;
            int sum2 = 0;
           while (temp > 0)
            {
                temp = temp / 10;
                count++;
            
            }
            // Console.WriteLine(count);
               temp = num;
            for (int j =count; j >=1; j--)
            {
                int rem = 0;
                rem = temp % 10;
                temp = temp / 10;
                for (int k = 1; k <= count; k++)
                {

                    sum = sum * rem ;
                }
                Console.WriteLine(sum);
                sum2 = sum2 + sum;
            }
           if (sum2 == num)
            {
                Console.WriteLine(num + "   is dissarium number");
            }
           else
                Console.WriteLine(num + "   is not dissarium number");

        }
    }
}
