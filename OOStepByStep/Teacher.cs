using System;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string className = string.Empty;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, string className) : base(name, age)
        {
            this.className = className;
        }

        public override string IntroduceMyself()
        {
            string introduceMessage = (this.className != string.Empty) ?
                $"{base.IntroduceMyself()} I am a teacher of {className}."
                : $"{base.IntroduceMyself()} I am a teacher.";
            return introduceMessage;
        }

        public string WellcomeNewStudent(Student newStudent)
        {
          if (newStudent.ClassName == className)
            {
                return $"{IntroduceMyself()} Welcome {newStudent.Name} join {className}.";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}