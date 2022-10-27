using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class OOStepByStepTest
    {
        [Fact]
        public void Should_return_message_when_introduce_given_person_name_Tom_age_21()
        {
            // given
            Person person = new Person("Tom", 21);

            // when
            string message = person.IntroduceMyself();

            // then
            Assert.Equal("My name is Tom. I am 21 years old.", message);
        }
    }
}
