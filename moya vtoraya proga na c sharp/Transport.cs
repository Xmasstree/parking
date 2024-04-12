using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_vtoraya_proga_na_c_sharp
{
    abstract class Transport 
    {
        public string Type_of_transport { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }

        public Transport()
        {
            Type_of_transport = "Авто";
            Color = "Синий";
            Weight = "1270";
        }

        public Transport(string Type_of_transport, string Color, string Weight)
        {
            this.Type_of_transport = Type_of_transport;
            this.Weight = Weight;
            this.Color = Color;

        }

        public void Print()
        {
            Console.WriteLine("_______________________");
            Console.WriteLine($"Тип транспорта: {Type_of_transport} || цвет: {Color} || вес: {Weight}");
        }

        public override string ToString()
        {
            return $"_______________________\nТип транспорта: {Type_of_transport} || цвет: {Color} || вес: {Weight}";
        }

        public abstract void Start_engine();
    }
}
