using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Minimum
    {
        //minimun valu int array

        public void findMin(int[] ar)
        {
            int min = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }
            }
            Console.WriteLine(min+"  minimun value ");
        }
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());

            }

            Minimum obj = new Minimum();
            obj.findMin(ar);

        }

    }

}
