using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Employee:Human
    {
        string role;
        string department;
        int workingHours;
        int waged;

        public Employee(string name, bool haJob, int age, bool isMarried, string role, string department, int workingHours, int waged): base(name, haJob, age, isMarried)
        {   
            this.role = role;
            this.department = department;
            this.workingHours = workingHours;
            this.waged = waged;
        }

        double calculateSalary()
        {
            return this.waged*this.workingHours;
        }


        public void describe()
        {
            Console.WriteLine("Employee Inforamtion::_");
            base.describe();
            Console.WriteLine($"Role: {this.role}\n" +
                $"Department: {this.department}\n" +
                $"Salary: {calculateSalary()}"); 
                

        }


    }
}
