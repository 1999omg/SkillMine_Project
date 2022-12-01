using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Opps
{
    class Car
    {
        int model;
        string name;
        int price;
        string colour;
        public void acceptDetails(int mod,string nam,int p, string col)
        {
            model = mod;
            name = nam;
            price = p;
            colour = col;
        }
        public void show()
        {
            Console.WriteLine(" model number is  " + model + "  car name  " + name + "  price is " + price + "  colour is  " + colour);
        }
        static void Main (string[] args)
        {
            Car obj = new Car();
            obj.acceptDetails(1247,"swift",60000,"white");
            obj.show();

        }
    }
}
