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
            Assert.Equal("My name is Tom. I am 18 years old. I am a student", introduce);
        }
    }
}
