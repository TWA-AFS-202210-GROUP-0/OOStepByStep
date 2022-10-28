namespace OOStepByStep
{
    using System;

    public class Person
    {
        protected string name;
        protected int age;
        protected Boolean isBelongsToClass;
        protected int classNumber;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, bool isBelongsToClass, int classNumber)
        {
            this.name = name;
            this.age = age;
            this.isBelongsToClass = isBelongsToClass;
            this.classNumber = classNumber;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old";
        }
    }
}