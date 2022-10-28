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
        public void Should_return_name_and_age_and_occupation_when_intro_given_student_and_class()
        {
            // given
            var student = new Student("Tom", 21, true, 2);
            // when
            var words = student.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 2.", words);
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
        public void Should_return_name_and_age_and_occupation_when_intro_given_teacher_and_class()
        {
            // given
            var teacher = new Teacher("Amy", 30, true, 2);
            // when
            var words = teacher.Introduce();
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_and_welcome_when_welcome_given_teacher_and_class_and_newstudent()
        {
            // given
            var teacher = new Teacher("Amy", 30, true, 2);
            Student student = new Student("Jim", 18, true, 2);
            // when
            var words = teacher.Welcome(student);
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_and_welcome_when_welcome_given_student_and_class_and_newstudent()
        {
            // given
            var oldStudent = new Student("Tom", 20, true, 2);
            Student newStudent = new Student("Jim", 18, true, 2);
            // when
            var words = oldStudent.Welcome(newStudent);
            // then
            Assert.Equal("My name is Tom. I am 20 years old. I am a student of class 2. Welcome Jim join class 2.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_when_welcome_given_student_and_MayNOT_BELONG_TO_class()
        {
            // given
            Student student = new Student("Jim", 18);
            Student newStudent = new Student("Lucy", 18, true, 2);
            // when
            var words = student.Welcome(newStudent);
            // then
            Assert.Equal("My name is Jim. I am 18 years old. I am a student.", words);
        }

        [Fact]
        public void Should_return_name_and_age_and_occupation_when_welcome_given_student_and_BELONG_TO_another_class()
        {
            // given
            Student student = new Student("Jim", 18, true, 3);
            Student newStudent = new Student("Lucy", 18, true, 2);
            // when
            var words = student.Welcome(newStudent);
            // then
            Assert.Equal("My name is Jim. I am 18 years old. I am a student of class 3.", words);
        }
    }
}
