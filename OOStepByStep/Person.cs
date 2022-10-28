namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public virtual string Introduce()
        {
            return $"My name is {this.name}. I am {this.age} years old.";
        }
    }
}