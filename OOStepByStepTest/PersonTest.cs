using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Shoule_return_greeting_when_introduce_self_given_person_have_name_age()
        {
            // given
            Person person = new Person("Tom", 21);
            // when
            string greeting = person.Greeting;
            // then
            Assert.Equal("My name is Tom. I am 21 years old", greeting);
        }
    }
}
