using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class SchoolPersonWithClassTest
    {
        [Fact]
        public void Should_return_greeting_with_job_class_student_when_introduce_given_student_with_name_age_job_class()
        {
            // given
            SchoolPersonWithClassNumber student = new SchoolPersonWithClassNumber("Tom", 18, "student", 3);
            // when
            string introduce = student.Introduce;
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 3", introduce);
        }

        [Fact]
        public void Should_return_greeting_with_job_class_teacher_when_introduce_given_teacher_with_name_age_job_class()
        {
            // given
            SchoolPersonWithClassNumber teacher = new SchoolPersonWithClassNumber("Tom", 18, "teacher", 3);
            // when
            string introduce = teacher.Introduce;
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 3", introduce);
        }

        [Fact]
        public void Should_return_greeting_welcome_when_welcome_new_student_given_student_with_name_age_job_class()
        {
            // given
            SchoolPersonWithClassNumber student = new SchoolPersonWithClassNumber("Tom", 18, "student", 3);
            // when
            SchoolPersonWithClassNumber newStudent = new SchoolPersonWithClassNumber("Jerry", 18, "student", 3);
            string welcome = student.Welcome(newStudent);
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 3. Welcome Jim join class 3", welcome);
        }

        [Fact]
        public void Should_return_greeting_welcome_when_welcome_new_student_given_teacher_with_name_age_job_class()
        {
            // given
            SchoolPersonWithClassNumber teacher = new SchoolPersonWithClassNumber("Ammy", 30, "teacher", 3);
            // when
            SchoolPersonWithClassNumber newStudent = new SchoolPersonWithClassNumber("Jerry", 18, "student", 3);
            string welcome = teacher.Welcome(newStudent);
            // then
            Assert.Equal("My name is Ammy. I am 30 years old. I am a student of class 3. Welcome Jim join class 3", welcome);
        }

        public void Should_return_nothing_when_welcome_new_student_from_different_class_given_teacher_with_name_age_job_class()
        {
            // given
            SchoolPersonWithClassNumber teacher = new SchoolPersonWithClassNumber("Ammy", 30, "teacher", 3);
            // when
            SchoolPersonWithClassNumber newStudent = new SchoolPersonWithClassNumber("Jerry", 18, "student", 4);
            string welcome = teacher.Welcome(newStudent);
            // then
            Assert.Equal(" ", welcome);
        }
    }
}
