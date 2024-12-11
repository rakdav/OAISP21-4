using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class FlightBody:Body
    {
        private const double G = 9.8;
        private double height;
        public double Height
        {
            get => height;
            set { if (value > 0) height = value; }
        }
        public FlightBody(double _massa, double _speed, double _height) : 
            base(_massa, _speed)
        {
            Height = _height;
        }
        public double GetPotencialEnergy() => Massa * G * Height;

        public new void Print()
        {
            Console.WriteLine($"Масса:{Massa} кг. Скорость:{Speed} м/с." +
                $" Кинетическая энергия:{GetKiniticEnergy():F2} Дж, высота:{Height}," +
                $" потенциальная энергия:{GetPotencialEnergy():F2} Дж");
        }
    }
}
