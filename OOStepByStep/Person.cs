namespace OOStepByStep
{
    using System;

    public class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old";
        }
    }
}