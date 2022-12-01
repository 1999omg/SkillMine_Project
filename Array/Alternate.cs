using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Array
{
    class Alternate
    {
        public void alternate(int[] arr)
        {
           for (int i = 0; i < arr.Length-1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            // write code for print alternate number from array
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Alternate obj =new Alternate();
            obj.alternate(arr);
        }
    }
}
