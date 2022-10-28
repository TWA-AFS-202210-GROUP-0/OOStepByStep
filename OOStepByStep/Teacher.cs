using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, bool isBelongsToClass, int classNumber) : base(name, age, isBelongsToClass, classNumber)
        {
        }

        public override string Introduce()
        {
            if (isBelongsToClass)
            {
                return base.Introduce() + $". I am a teacher of class {this.classNumber}";
            }
            else
            {
                return base.Introduce() + ". I am a teacher";
            }
        }
    }
}