using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Student:Human
    {
        string qualification;
        bool isIntern;
        int totalGrade;
        int studingHours;

        public Student(string name, bool haJob, int age, bool isMarried, string Qualification, bool isintern, int totalGrade, int studyHoues) : base( name,  haJob,  age,  isMarried)
        {
            this.qualification = Qualification;
            this.isIntern = isintern;
            this.totalGrade = totalGrade;
            this.studingHours = studyHoues;
        }

        public void describe()
        {
            Console.WriteLine("Student Describe::_");
            base.describe();
            Console.WriteLine($"Qulaification: {this.qualification}\n" +
                $"Is Intern: {this.isIntern}\n" +
                $"Total Grade: {this.totalGrade}\n" +
                $"Studing Hours: {this.studingHours}");
        }


    }
}
