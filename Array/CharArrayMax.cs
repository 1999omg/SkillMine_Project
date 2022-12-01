using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class CharArrayMax
    {
        public void findaMax(char[] ch)
        {
            char max = ch[0];
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] > max)
                {
                    max = ch[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("test passs ");
        }
        static void Main (string[] args)
        {
            char[] ch = { 'x', 'y', 'z', 'q', 'r', 'f' } ;
            CharArrayMax obj = new CharArrayMax();
            obj.findaMax(ch);
        }
    }
}
