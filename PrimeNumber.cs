using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class PrimeNumber

    {
        public void findPrime(int [] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                count = 0;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr [i] % j == 0)
                    {
                        count++;
                    }
                }
                if (count < 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void Main (string[] args)
        {
            int [] arr = new int [10];
            for (int i = 0; i < arr.Length; i++)
            {
                 arr[i] = int.Parse(Console.ReadLine());
            }
            PrimeNumber obj = new PrimeNumber();
            obj.findPrime(arr);
            
        }
    }
}
