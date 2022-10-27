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

        [Fact]
        public void Should_return_message_when_introduce_given_teacher_name_Amy_age_30()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30);

            // when
            string message = teacher.IntroduceMyself();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", message);
        }

        [Fact]
        public void Should_return_message_when_introduce_given_student_name_Tom_age_18_class_2()
        {
            // given
            Student student = new Student("Tom", 18, "class 2");

            // when
            string message = student.IntroduceMyself();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_introduce_given_teacher_name_Amy_age_30_class_2()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30, "class 2");

            // when
            string message = teacher.IntroduceMyself();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", message);
        }

    }
}
