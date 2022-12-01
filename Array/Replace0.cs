
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{ 



    class Replace0
    {
        public void replacewith0(int[] arr)
        {
            Console.WriteLine(string.Join("", arr));
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr[i] = 0;
                }
            }
            Console.WriteLine(string.Join("", arr));

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 15 };
            Replace0 obj = new Replace0();
            obj.replacewith0(arr);
        }
    }
}
