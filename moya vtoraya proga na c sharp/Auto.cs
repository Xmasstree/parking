using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_vtoraya_proga_na_c_sharp
{
    

    class Auto : Transport, IBrand, IPlate
    {
        public string Car_brand { get; set; }
        public string Number_plate { get; set; }

        public Auto()
        {
            Car_brand = "Subaru";
            Number_plate = "W555RX";
        }

        public Auto(string Type_of_transport, string Color, string Weight, string Car_brand, string Number_plate) : base(Type_of_transport, Color, Weight)
        {
            this.Car_brand = Car_brand;
            this.Number_plate = Number_plate;
        }

        public void NAuto()
        {
            bool flag = true;
            Type_of_transport = "Авто";
            Console.WriteLine("\nСоздание объекта Авто.");
            while (flag)
            {
                Console.Write("Введите цвет вашего авто: ");
                Color = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Color);
            }
            do
            {
                Console.Write("Введите вес вашего авто: ");
                Weight = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Weight);
            }
            while (flag);
            do
            {
                Console.Write("Введите марку вашего авто: ");
                Car_brand = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Car_brand);
            }
            while (flag);
            do
            {
                Console.Write("Введите гос. номер вашего авто: ");
                Number_plate = Console.ReadLine();
                flag = String.IsNullOrWhiteSpace(Number_plate);
            }
            while (flag);
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Марка: {Car_brand} || Гос.номер:  {Number_plate}");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nМарка: { Car_brand} || Гос.номер:  { Number_plate}";
        }

        public override void Start_engine()
        {
            Console.WriteLine("Вы слышите приятный звук мотора авто");
        }

        void IBrand.GetData()
        {
            Console.WriteLine($"{Car_brand}"); 
        }

        void IPlate.GetData()
        {
            Console.WriteLine($"{Number_plate}");
        }
    }
}
