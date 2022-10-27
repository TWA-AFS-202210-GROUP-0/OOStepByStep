namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_person_can_introduce_himself()
        {
            // given
            var person = new Person("Tom", 21);
            // when
            var msg = person.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old", msg);
        }

        [Fact]
        public void Should_student_can_introduce_himself()
        {
            // given
            var student = new Student("Tom", 18);
            // when
            var msg = student.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student", msg);
        }

        [Fact]
        public void Should_teacher_can_introduce_himself()
        {
            // given
            var teacher = new Teacher("Amy", 30);
            // when
            var msg = teacher.Introduce();
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher", msg);
        }
    }
}