namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string IntroduceMyself()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }

        public string Name
        {
            get { return name; }
        }

        public int Age { get { return age; } }
    }
}