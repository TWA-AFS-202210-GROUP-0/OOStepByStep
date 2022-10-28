using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class StudentTest
    {
        [Fact]
        public void Should_return_greeting_with_job_student_when_introduce_given_student_with_name_age_job()
        {
            // given
            SchoolPerson student = new SchoolPerson("Tom", 18, "student");
            // when
            string introduce = student.Introduce;
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student", introduce);
        }
    }
}
