using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class TeacherTest
    {
        [Fact]
        public void Should_return_greeting_with_job_teacher_when_introduce_given_teacher_with_name_age_job()
        {
            // given
            SchoolPerson teacher = new SchoolPerson("Amy", 30, "teacher");
            // when
            string introduce = teacher.Introduce;
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher", introduce);
        }
    }
}
