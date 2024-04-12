using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_vtoraya_proga_na_c_sharp
{
    class Train : Transport
    {
        public string Power { get; set; }
        public string Serial_number { get; set; }

        public Train()
        {
            Power = "1000";
            Serial_number = "8800";
        }

        public Train(string Type_of_transport, string Color, string Weight, string Power, string Serial_number) : base(Type_of_transport, Color, Weight)
        {
            this.Power = Power;
            this.Serial_number = Serial_number;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Мощность (л.с.): {Power} || Серийный номер {Serial_number}");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nМощность (л.с.): {Power} || Серийный номер {Serial_number}";
        }

        public void NTrain()
        {
            bool flag;
            Type_of_transport = "Поезд";
            Console.WriteLine("\nСоздание объекта Поезд.");
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
        }

        public override void Start_engine()
        {
            Console.WriteLine("Вы слышите писк электродвигателя");
        }
    }
}
