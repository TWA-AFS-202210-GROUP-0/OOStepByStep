using System.ComponentModel.DataAnnotations;

namespace OOStepByStep
{
    using System;
    public class Person
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public int Age { get; set; }

        public string IntroduceNameAndAge()
        {
            return $"My name is {this.Name}. I am {this.Age} years old.";
        }
    }
}
