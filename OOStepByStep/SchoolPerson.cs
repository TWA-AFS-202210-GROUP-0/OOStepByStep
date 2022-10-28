using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class SchoolPerson : ISchoolPerson
    {
        public SchoolPerson(string name, int age, string job)
        {
            Name = name;
            Age = age;
            Job = job;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public string Introduce => $"My name is {Name}. I am {Age} years old. I am a {Job}";
    }
}
