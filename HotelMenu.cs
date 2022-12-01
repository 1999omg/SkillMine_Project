using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class HotelMenu
    {
        static void Main(string[] args)
        {

            Console.WriteLine("press 1 to order pav bhaji ");
            Console.WriteLine("press 2 to order puri bhaji ");
            Console.WriteLine(" press 3 to order pav bhaji ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(" pleasse  enter quantity ");
            int q = int.Parse(Console.ReadLine());
            int bill = 0;


            switch (s)
            {

                case 1:
                    bill = q * 100;
                    Console.WriteLine("you ordered pav bhaji and your bill is  "+bill );
                    break;
                case 2:
                    bill = q * 120;
                    Console.WriteLine("you ordered puri bhaji your bill is  " + bill);
                    break;
                case 3:
                    bill = q * 50;
                    Console.WriteLine("you orderd dosa your bill is  " + bill);
                    break;
               
            }
            Console.WriteLine("thank you and visit again  your bill is  " + bill);
            


        }
    }
}
