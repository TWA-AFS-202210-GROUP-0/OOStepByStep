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

        [Fact]
        public void Should_return_message_when_introduce_given_student_name_Tom_age_18()
        {
            // given
            Student student = new Student("Tom", 18);

            // when
            string message = student.IntroduceMyself();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", message);
        }
    }
}
