using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Factor
    {
        static void Main (string[] args)
        {
            // write coode to find sum of factor of a given number 
            Console.WriteLine("sum of factor of a given number ");

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {

                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);



            // write code for display number divisible by 5 and 3 
            Console.WriteLine("_________________________________________________________");

            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            // write cone for print table of given number 
            Console.WriteLine("_________________________________________________________");

            Console.WriteLine(" table of given number");
            int n = int.Parse(Console.ReadLine());
            int tb = 0;
            for (int i = 1; i <= 10; i++)
            {
                tb = n * i;
                Console.WriteLine(tb);
            }


        }
    }
}
