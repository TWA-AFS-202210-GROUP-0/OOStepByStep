using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class SchoolPersonWithClassNumber : ISchoolPersonWithClassNumber
    {
        public SchoolPersonWithClassNumber(string name, int age, string job, int classNumber)
        {
            Name = name;
            Age = age;
            Job = job;
            ClassNumber = classNumber;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public int ClassNumber { get; set; }

        public string Introduce => $"My name is {Name}. I am {Age} years old. I am a student of class {ClassNumber}";
        public string Welcome(SchoolPersonWithClassNumber student)
        {
            if (student.ClassNumber == ClassNumber)
            {
                return $"My name is {Name}. I am {Age} years old. I am a student of class {ClassNumber}. Welcome Jim join class {ClassNumber}";
            }

            return " ";
        }
    }
}
