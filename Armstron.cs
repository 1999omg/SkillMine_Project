using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Armstron
        // code for print armstrong for given range 

    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            int temp = 0;
            int count = 0;
            int rem = 0;
            for ( i = 1; i <= num; i++)
            {
                count = 0;
                 rem = 0;
            }
            temp = i;
            while (temp > 0)
            {
              
                temp = temp / 10;
                count++;
            }
            temp = num;
            for (int j = 1; j <= count; j++)
            {
               for (int k = 1; k <= count; k++)
                {

                }
            }

        }
    }
}
