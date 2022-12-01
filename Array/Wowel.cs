using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    //write code display wowels from the arry


    class Wowel
    {
        public void findWowel(char[] ch,char [] wowel )
        {
            for(int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j < wowel.Length; j++)
                {
                    if (ch[i] == wowel[j])
                    {
                        Console.WriteLine(ch[i]);
                    }
                }
            }
        }

        static void Main (string[] args)
        {
            char[] wowel = { 'a', 'e', 'i', 'o', 'u' };
            char[] ch = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's' ,'u'};
            Wowel obj = new Wowel();
            obj.findWowel(ch, wowel);
        }
    }
}
