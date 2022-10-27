namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_say_name_and_age_when_self_introduce_given_name_Tom_age_21()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            var introduction = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }

        [Fact]
        public void Should_say_name_age_role_when_introduce_self_given_name_age_student()
        {
            //given
            Student student = new Student("Tom", 21);
            //when
            var introduction = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", introduction);
        }

        [Fact]
        public void Should_say_name_age_role_when_introduce_self_given_name_age_teacher()
        {
            //given
            Teacher teacher = new Teacher("Tom", 21);
            //when
            var introduction = teacher.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old. I am a teacher.", introduction);
        }
    }
}
