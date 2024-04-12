using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_vtoraya_proga_na_c_sharp
{
    delegate void Deleg();
    class List
    {
        Deleg deleg;
        private List<Transport> cars = new List<Transport>();

        public void menu()
        {
            Console.WriteLine("\nКакой объект создать?");
            Console.WriteLine("1:Авто");
            Console.WriteLine("2:Поезд");
            Console.WriteLine("3:Экспресс");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("4:Поиск автомобилей по цвету");
            Console.WriteLine("5:Поиск поезда по его серийному номеру");
            Console.WriteLine("6:Поиск экспрессов по начальному пункту");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("7:Редактирование элементов списка");
            Console.WriteLine("8:Удаление элементов списка");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("9:Запустить двигатель");
            Console.WriteLine("10:Вывод всех объектов на экран (интерфейс)");
            Console.WriteLine("0:Выход");
            Console.Write("Ввод: ");
            //Console.WriteLine($"{Convert.ToInt32( Convert.ToString(16.5).Split(',')[1])%2}");
        }

       public void addAuto(int n)
        {
            Auto transport = new Auto();
            transport.NAuto();
            if (n == -1) cars.Add(transport);
            else cars[n] = transport;

        }

        public void addTrain(int n)
        {
            Train transport = new Train();
            transport.NTrain();
            if (n == -1) cars.Add(transport);
            else cars[n] = transport;

        }

        public void addExpress(int n)
        {
            Express transport = new Express();
            transport.NExpress();
            if (n == -1) cars.Add(transport);
            else cars[n] = transport;
        }

        public void search_and_print_Auto()
        {
            Console.WriteLine("\nПоиск авто по цвету.");
            if (cars.Count > 0)
            {
                Console.Write("Введите цвет: ");
                string user_color = Console.ReadLine();
                bool flag = false;
                foreach (Auto transport in cars)
                    if (transport is Auto auto)
                    {
                        if (auto.Color == user_color)
                        {
                            Console.WriteLine(auto);
                            flag = true;
                        }
                    }
                if (!flag)
                {
                    Console.WriteLine("Таких объектов нет");
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }

        public void search_and_print_Train()
        {
            Console.WriteLine("\nПоиск поезда по серийному номеру.");
            if (cars.Count > 0)
            {
                Console.Write("Введите серийнай номер: ");
                string user_serial = Console.ReadLine();
                bool flag = false;
                foreach (Train transport in cars)
                    if (transport is Train train)
                    {
                        if (train.Serial_number == user_serial)
                        {
                            Console.WriteLine(train);
                            flag = true;
                        }
                    }
                if (!flag)
                {
                    Console.WriteLine("Таких объектов нет");
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }

        public void search_and_print_Express()
        {
            Console.WriteLine("\nПоиск экспресса по начальному пункту.");
            if (cars.Count > 0)
            {
                Console.Write("Введите начальный пункт: ");
                string user_point = Console.ReadLine();
                bool flag = false;
                foreach (Express transport in cars)
                    if (transport is Express express)
                    {
                        if (express.Start_point == user_point)
                        {
                            Console.WriteLine(express);
                            flag = true;
                        }
                    }
                if (!flag)
                {
                    Console.WriteLine("\nТаких объектов нет");
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }

        public void printall()
        {
            if (cars.Count > 0)
            {
                foreach (Transport transport in cars)
                {
                    if (transport is Auto auto) Console.WriteLine(auto);
                    else if (transport is Express express) Console.WriteLine(express);
                    else if (transport is Train train) Console.WriteLine(train);
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }

        public void Start()
        {
            if (cars.Count > 0)
            {
                printall();
                bool flag = true;
                int num;
                while (flag)
                {
                    try
                    {
                        Console.Write("\nВведите номер объекта, который хотели бы запустить: ");
                        num = int.Parse(Console.ReadLine());
                        cars[num - 1].Start_engine(); 
                    }
                    catch
                    {
                        Console.WriteLine("\nНе удалось преобразовать строку в число.");
                        Console.ReadLine();
                        continue;
                    }
                    flag = false;
                }
                
            }
        }
       
        public void delete()
        {
            if (cars.Count > 0)
            {
                printall();
                bool flag = true;
                int num;
                while (flag)
                {
                    try
                    {
                        Console.Write("\nВведите номер удаляемого элемента: ");
                        num = int.Parse(Console.ReadLine());
                        cars.RemoveAt(num - 1);
                    }
                    catch
                    {
                        Console.WriteLine("\nНе удалось преобразовать строку в число.");
                        Console.ReadLine();
                        continue;
                    }
                    
                    flag = false;
                    printall();
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }

        public void edit()
        {
            if (cars.Count > 0)
            {
                printall();
                bool flag = true;
                int num;
                while (flag)
                {
                    try
                    {
                        Console.Write("Введите номер редактируемого элемента: ");
                        num = int.Parse(Console.ReadLine());
                        if (cars[num-1] is Express )
                        {
                            addExpress(num-1);
                        }

                        else if (cars[num - 1] is Train)
                        {
                            addTrain(num-1);
                        }

                        else if(cars[num-1] is Auto)
                        {
                            addAuto(num-1);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nНе удалось преобразовать строку в число.");
                        continue;
                    }

                    flag = false;
                    printall();
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }

        public void Interface()
        {
            if (cars.Count > 0)
            {
                foreach (Auto transport in cars)
                {
                    if(transport is Auto auto)
                    {
                        IBrand brand = auto;
                        deleg = brand.GetData;
                        IPlate plate = auto;
                        deleg += plate.GetData;
                        deleg();
                        Console.WriteLine("УРАААААААААААААА");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nНет объектов");
            }
        }
    }
}
