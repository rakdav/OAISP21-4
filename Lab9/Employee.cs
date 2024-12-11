using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Employee
    {
        public string Surname { get; set; }
        public string Position { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                if (value > 0) salary = value;
            }
        }
        public Employee(){}
        public Employee(string surname, string position, decimal salary)
        {
            Surname = surname;
            Position = position;
            Salary = salary;
        }
        public void AddSalary()
        {
            salary += (salary*15)/100;
        }
        public void Print()
        {
            Console.WriteLine($"Фамилия:{Surname}, должность:{Position}, оклад:{salary}");
        }
        public void SetPosition()
        {
            if (Surname.StartsWith("Иван")) Position = "Инженер";
        }
    }
}
