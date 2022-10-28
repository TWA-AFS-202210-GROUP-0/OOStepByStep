namespace OOStepByStep
{
    public class SchoolPerson : Person
    {
        private int classNumber;
        private bool isBelongClass;
        public SchoolPerson(string name, int age) : base(name, age)
        {
        }

        public SchoolPerson(string name, int age, bool isBelongClass, int classNumber) : base(name, age)
        {
            this.ClassNumber = classNumber;
            this.IsBelongClass = isBelongClass;
        }

        public int ClassNumber { get => classNumber; set => classNumber = value; }
        public bool IsBelongClass { get => isBelongClass; set => isBelongClass = value; }

        public override string Introduce()
        {
            return base.Introduce();
        }

        public virtual string Welcome(SchoolPerson newStudent)
        {
            return $" Welcome {newStudent.Name} join class {newStudent.classNumber}.";
        }
    }
}