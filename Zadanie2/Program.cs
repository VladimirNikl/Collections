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
            Console.WriteLine(" Элементы коллекции типа int :");
            MyList<int> intCollect = new MyList<int>();
            do
            {
                Console.WriteLine("\n    Ввести элемент - нажать 1\n    удалить эдемент - нажать 0\n   просмотреть коллекцию - 2");
                Console.Write("   вывести элемент коллекции - 3\n   вывести общее количество - 4\n        закончить - иначе.      : ");
                flag = Console.ReadLine();
                if (flag == "1")
                    if (Int32.TryParse(Console.ReadLine(), out int inInt))
                        intCollect.Add(inInt);
                    else
                        Console.Write("  Не правильный ввод.");
                if (flag == "2")
                    if (intCollect.LengthN == 0)
                        Console.WriteLine("  Колекция не имеет элементов.");
                    else
                        OutCollect(); // OutCollect2();
                if (flag == "0" || flag == "3")
                {
                    if (intCollect.LengthN == 0)
                        Console.WriteLine("  Колекция не имеет элементов.");
                    else
                    {
                        if (flag == "0")
                        {
                            Console.Write(" Номер удаляемого элемента. Ввести : ");
                            if (Int32.TryParse(Console.ReadLine(), out int input) && (input >= 0 & input < intCollect.LengthN))
                                intCollect.Del(input);
                            else
                                Console.WriteLine(" Не корректный ввод");
                        }
                        if (flag == "3")
                        {
                            Console.Write("  Вводим номер элемента колекции для вывода : ");
                            if (Int32.TryParse(Console.ReadLine(), out int index) && (index >= 0 & index < intCollect.LengthN))
                                Console.WriteLine(intCollect[index]); // показать и по свойству Current;
                            else
                                Console.WriteLine("  Не корректный ввод");
                        }
                    }
                }
                if (flag == "4")
                    Console.WriteLine("  Количество элементов колекции - {0}", intCollect.LengthN);
            } while (flag == "1" || flag == "2" || flag == "0" || flag == "3" || flag == "4");
            // MyList<string> strCollect = new MyList<string>("rt", "ytr", "re44", "532", "rrt");
            //strCollect.Add("moj'nkn''ljk");
            //foreach (string item in strCollect)
            //  Console.WriteLine(item);
            // Console.WriteLine(string.Format("+-+-"));

            // intCollect.Add(new int() { });
            // foreach (int item in intCollect)
            //  Console.WriteLine(item);

            //Console.WriteLine("-------");
            //Console.WriteLine("   2-й элеьент {0}", intCollect[2]);
            void OutCollect()    //  ДАЖЕ В main() хоть мы идем по строкам - , методы без их вызова НЕ ВЫПОЛНЯЮТСЯ  !!!
            {
                for (int i = 0; i < intCollect.LengthN; i++) // хоть и не создаю новый экземпляр, а только изменяю колл элементов в массиве, всеравно
                    Console.Write(intCollect[i] + "  ");      // перем intCollect содержит ссылку на массив, который изменяется от моих изменений,
                Console.WriteLine();                         // т.е. ссылка на то место в памяти, которое изменяется, т.е. экземпляр не запоминает
            }                                            // то время, то состояние на момент создания.
                                                         // Console.ReadKey();
            void OutCollect2()
            {
                foreach (int item in intCollect)
                    Console.Write(item + "  ");
            }
           // Console.ReadKey();
        }
    }
}
