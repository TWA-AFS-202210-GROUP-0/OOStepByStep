using System;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string className = string.Empty;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, string className) : base(name, age)
        {
            this.className = className;
        }

        public override string IntroduceMyself()
        {
            string introduceMessage = (this.className != string.Empty) ?
                $"{base.IntroduceMyself()} I am a student of {className}."
                : $"{base.IntroduceMyself()} I am a student.";
            return introduceMessage;
        }

        public string ClassName { get => className; }

    }
}