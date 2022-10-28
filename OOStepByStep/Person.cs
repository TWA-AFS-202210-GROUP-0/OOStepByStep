namespace OOStepByStep
{
    using System;
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string Name { get; set; }
        private int Age { get; set; }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}
