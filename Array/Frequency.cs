using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Array
{
    class Frequency

    {
		public void ferquency(int[] a)
        {
			int counter = 0;

			for (int i = 0; i < a.Length; i++)
			{

				if (a[i] == 999)
				{
					continue;

				}

				for (int j = i + 1; j < a.Length; j++)
				{

					if (a[i] == a[j])
					{

						counter++;
						a[i] = -999;


					}
				}
				Console.WriteLine(a[i] + "numrepeat" + counter + "times");
			}
		}
		static void Main(string[] args)
		{

			int counter = 0;
			int[] a = { 11, 22, 33, 11, 22, 33, 33 };



		}
			
    }
}
