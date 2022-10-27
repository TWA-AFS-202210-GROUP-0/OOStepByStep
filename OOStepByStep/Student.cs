namespace OOStepByStep
{
    using System;
    public class Student : SchoolPerson
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, bool isBelongClass, int classNumber) : base(name, age, isBelongClass, classNumber)
        {
        }

        public override string Introduce()
        {
            if (this.IsBelongClass)
            {
                return base.Introduce() + $" I am a student of class {this.ClassNumber}.";
            }
            else
            {
                return base.Introduce() + $" I am a student.";
            }
        }
    }
}
