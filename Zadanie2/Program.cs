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
            int i = 1;
            bool flag = true;
            string line = null;
            Console.WriteLine("     Введем элементы коллекции:");
            do
            {
                line += Console.ReadLine();
                Console.WriteLine("    Закончить -  нажать '0', продолжить - иначе.");
                string endInput = Console.ReadLine();
                if (endInput == "0")
                    flag = false;
            } while (flag);
            MyList<string> strCollect = new MyList<string>(line);
            foreach (string item in strCollect)
                Console.WriteLine(item);
            Console.WriteLine(string.Format("+-+-"));
            MyList<int> intCollect = new MyList<int>(284, 48);
            foreach (int item in intCollect)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
