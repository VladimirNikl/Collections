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
            string flag;
            Console.WriteLine("     Элементы коллекции типа int :");
            MyList<int> intCollect = new MyList<int>();
            do
            {
                Console.Write("  Ввести элемент - нажать 1, закончить ввод - иначе. :");
                flag = Console.ReadLine();
                if (flag == "1")
                    if (Int32.TryParse(Console.ReadLine(), out int inInt))
                        intCollect.Add(inInt);
                    else
                    {
                        Console.Write("  Не правильный ввод. Ввести элемент - нажать 1, закончить ввод - иначе. :");
                        flag = Console.ReadLine();
                    }
            } while (flag == "1");
           // MyList<string> strCollect = new MyList<string>("rt", "ytr", "re44", "532", "rrt");
            //strCollect.Add("moj'nkn''ljk");
            //foreach (string item in strCollect)
              //  Console.WriteLine(item);
            Console.WriteLine(string.Format("+-+-"));
            
            // intCollect.Add(new int() { });
            foreach (int item in intCollect)
                Console.WriteLine(item);

            Console.WriteLine("-------");
            Console.WriteLine("   2-й элеьент {0}", intCollect[2]);

            for (int i = 0; i < intCollect.LengthN; i++) // хоть и не создаю новый экземпляр, а только изменяю колл элементов в массиве, всеравно
                Console.Write(intCollect[i]+ "  ");      // перем intCollect содержит ссылку на массив, который изменяется от моих изменений,
                                                         // т.е. ссылка на то место в памяти, которое изменяется, т.е. не запоминает экземпляр
                                                         // то время, то состояние на момент создания.
            Console.ReadKey();
        }
    }
}
