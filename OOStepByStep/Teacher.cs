namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string IntroduceMyself()
        {
            return $"My name is {Name}. I am {Age} years old. I am a teacher.";
        }
    }
}