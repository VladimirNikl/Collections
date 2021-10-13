using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main()
        {
            int i = 5;
            MyList<string> strCollect = new MyList<string>("k","i");
            foreach(string item in strCollect)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
