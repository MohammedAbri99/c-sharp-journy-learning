using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Human
    {
       public string name;
       public int id;
       public bool haJob;
       public int age ;
       public bool isMarried;
        public Human( string name ,bool haJob , int age , bool isMarried )
        {
            this.name = name;  
            this.haJob = haJob;
            this.age = age;
            this.isMarried = isMarried;

            
        }
        public void describe()
        {
            Console.WriteLine($"Name: {name}\n" +
                $"has job: {(this.haJob ? "he Has job" : "He doesn't have a job")}\n" +
                $"Age {this.age}\n" +
                $"Is Married: {(this.isMarried ? "He is Married" : "He doesn't Married")}");
        }

    }
}
