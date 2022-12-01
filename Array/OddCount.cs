using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class OddCount
    {   public void count(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int [5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());



            }
        }
    }
}
