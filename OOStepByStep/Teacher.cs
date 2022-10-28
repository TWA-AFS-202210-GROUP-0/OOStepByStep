namespace OOStepByStep
{
    public class Teacher : SchoolPerson
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, bool isBelongClass, int classNumber) : base(name, age, isBelongClass, classNumber)
        {
        }

        public override string Introduce()
        {
            if (this.IsBelongClass)
            {
                return base.Introduce() + $" I am a teacher of class {this.ClassNumber}.";
            }
            else
            {
                return base.Introduce() + $" I am a teacher.";
            }
        }

        public override string Welcome(SchoolPerson newStudent)
        {
            if (this.IsBelongClass & this.ClassNumber == newStudent.ClassNumber)
            {
                return this.Introduce() + base.Welcome(newStudent);
            }
            else
            {
                return this.Introduce();
            }
        }
    }
}