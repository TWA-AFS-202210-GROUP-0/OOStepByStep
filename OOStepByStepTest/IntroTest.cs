namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class IntroTest
    {
        [Fact]
        public void Should_return_name_and_age_when_intro_given_person()
        {
            // given
            var person = new Person("Tom", 21);
            // when
            var words = person.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_when_intro_given_student()
        {
            // given
            var student = new Student("Tom", 21);
            // when
            var words = student.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_when_intro_given_teacher()
        {
            // given
            var teacher = new Teacher("Amy", 30);
            // when
            var words = teacher.Introduce();
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_when_intro_given_student_and_class()
        {
            // given
            var student = new Student("Tom", 21, 2);
            // when
            var words = student.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 2.", words);
        }
    }
}
