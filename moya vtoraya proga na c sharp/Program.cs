//Смольников Илья КБ Вариант 11 (повышеный)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_vtoraya_proga_na_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа стоянка запущена!");
            List list = new List();
            string x;
            do
            {
                list.menu();
                x = Console.ReadLine();

                switch(x)
                {
                    case "1":
                        list.addAuto(-1);
                        break;
                    case "2":
                        list.addTrain(-1);
                        break;
                    case "3":
                        list.addExpress(-1);
                        break;
                    case "4":
                        list.search_and_print_Auto();
                        break;
                    case "5":
                        list.search_and_print_Train();
                        break;
                    case "6":
                        list.search_and_print_Express();
                        break;
                    case "7":
                        list.edit();
                        break;
                    case "8":
                        list.delete();
                        break;
                    case "9":
                        list.Start();
                        break;
                    case "10":
                        list.Interface();
                        break;
                    case "0":
                        Console.WriteLine("Good night!");
                        break;
                    default:
                        Console.WriteLine("Такой команды нет!");
                        break;
                }
            } while (x != "0");
            Console.WriteLine();
        }
    }
}
