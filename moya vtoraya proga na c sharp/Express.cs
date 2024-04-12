using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_vtoraya_proga_na_c_sharp
{
    class Express : Train
    {
        public string Start_point { get; set; }
        public string Finish_point { get; set; }

        public Express()
        {
            Start_point = "Токио";
            Finish_point = "Киото";
        }

        public Express(string Type_of_transport, string Color, string Weight, string Power, string Serial_number, string Start_point, string Finish_point) : base(Type_of_transport, Color, Weight, Power, Serial_number)
        {
            this.Finish_point = Finish_point;
            this.Start_point = Start_point;
        }

        public void NExpress()
        {
            bool flag;
            Type_of_transport = "Экспресс";
            Console.WriteLine("\nСоздание объекта Экспресс.");
            do
            {
                Console.Write("Введите цвет вашего поезда: ");
                Color = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Color);
            }
            while (flag);

            do
            {
                Console.Write("Введите вес вашего поезда: ");
                Weight = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Weight);
            }
            while (flag);

            do
            {
                Console.Write("Введите мощность (л.с.) вашего поезда: ");
                Power = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Power);
            }
            while (flag);

            do
            {
                Console.Write("Введите серийный номер вашего поезда: ");
                Serial_number = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Serial_number);
            }
            while (flag);

            do
            {
                Console.Write("Введите начальный пункт маршрута: ");
                Start_point = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Start_point);
            }
            while (flag);

            do
            {
                Console.Write("Введите конечный пункт маршрута: ");
                Finish_point = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Finish_point);
            }
            while (flag);
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Начальный пункт {Start_point} || конечный пункт {Finish_point}");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nНачальный пункт {Start_point} || конечный пункт {Finish_point}";
        }

        public override void Start_engine()
        {
            Console.WriteLine("звук открытия двери");
        }

    }
}
