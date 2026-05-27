using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Lists
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public void increaseSalary(double percentage) 
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"ID: {Id, -6}| Name: {Name, -30}| Salary: {Salary, -12:F2}";
        }
    }
}
