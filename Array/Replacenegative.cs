using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Array
{
    class Replacenegative
    {
        public void replace(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                int mul = 0;
                int sum = 1;
                if (ar[i] < 0)
                {
                    mul = ar[i - 1];
                    sum = mul * mul;
                }
                Console.WriteLine(sum);
            }
            
        }
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Replacenegative obj=new Replacenegative();
            obj.replace(ar);
        }
    }
}
