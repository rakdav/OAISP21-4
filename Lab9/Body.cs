using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Body
    {
        private double massa;
        public double Massa
        {
            get => massa;
            set { if (value > 0) massa = value; }
        }
        private double speed;
        public double Speed
        {
            get => speed;
            set { if (speed >= 0) speed = value; }
        }
        public Body(double massa, double speed)
        {
            this.Massa = massa;
            this.Speed = speed;
        }
        public void Print()
        {
            Console.WriteLine($"Масса:{massa} кг. Скорость:{speed} м/с." +
                $" Кинетическая энергия:{GetKiniticEnergy():F2} Дж");
        }
        public double GetKiniticEnergy()
        {
            return massa * speed * speed / 2;
        }
    }
}
