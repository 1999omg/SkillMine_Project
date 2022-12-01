using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Opps
{
    class Simple
    {
        int roll;
        int id;
        string name;
        public void accept(int rolls,int idd,string namee)
        {
            roll = rolls;
            id = idd;
            name = namee;
        }
        public void show()
        {
            Console.WriteLine(roll+"  roll  "+ id+ "  id " + name+"  name ");
        }
        static void Main(string []args)
        {
            Simple obj = new Simple();
            obj.show();
            obj.accept(1,10,"ram");
            obj.show();
        }
    }
}
