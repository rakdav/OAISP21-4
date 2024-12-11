using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class EmpFactory:Employee
    {
        private int rating;
        public int Rating
        {
            get => rating;
            set { if (value >= 0 && value <= 100) rating = value; }
        }
        public EmpFactory(string surname, string position, decimal salary,
            int  rating):base(surname,position,salary)
        {
            Rating = rating;
        }
        public new void AddSalary()
        {
            if(rating>=60&&rating<75) Salary += (Salary * 40) / 100;
            else if(rating>=75&&rating<90) Salary += (Salary * 60) / 100;
            else if(rating >= 90 && rating <=100) Salary += (Salary * 60) / 100;
        }
        public new void Print()
        {
            Console.WriteLine($"Фамилия:{Surname}, должность:{Position}, рейтинг: {Rating}, оклад:{Salary}");
        }
    }
}
