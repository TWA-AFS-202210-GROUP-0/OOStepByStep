using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, bool isBelongsToClass, int classNumber) : base(name, age, isBelongsToClass, classNumber)
        {
        }

        public override string Introduce()
        {
            if (isBelongsToClass)
            {
                return base.Introduce() + $". I am a student of class {this.classNumber}";
            }
            else
            {
                return base.Introduce() + ". I am a student";
            }
        }
    }
}