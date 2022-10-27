using System.Collections.Generic;
using System.Threading;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class OOTest
    {
        [Fact]
        public void Should_return_Zhouyun_39_When_IntroduceNameAndAge_given_zhouyun_19()
        {
            //Given
            var zhouyun = new Person()
            {
                Name = "Zhouyun",
                Age = 39,
            };
            //When
            var result = zhouyun.IntroduceNameAndAge();
            //Then
            Assert.Equal("My name is Zhouyun. I am 39 years old.", result);
        }

        [Fact]
        public void Should_return_Meng_27_student_When_IntroduceWithRole_given_Student_Meng_19()
        {
            //Given
            var meng = new Student()
            {
                Name = "Meng",
                Age = 27,
            };
            //When
            var result = meng.IntroduceWithRole();
            //Then
            Assert.Equal("My name is Meng. I am 27 years old. I am a student.", result);
        }

        [Fact]
        public void Should_return_Zhouyun_39_teacher_When_IntroduceWithRole_given_Teacher_Zhouyun_39()
        {
            //Given
            var zhouyun = new Teacher()
            {
                Name = "Zhouyun",
                Age = 39,
            };
            //When
            var result = zhouyun.IntroduceWithRole();
            //Then
            Assert.Equal("My name is Zhouyun. I am 39 years old. I am a teacher.", result);
        }

        [Fact]
        public void Should_return_Meng_27_student_class2_When_IntroduceWithRole_given_Student_Meng_19_class2()
        {
            //Given
            var meng = new Student()
            {
                Name = "Meng",
                Age = 27,
                ClassNumber = 2
            };
            //When
            var result = meng.IntroduceWithClass();
            //Then
            Assert.Equal("My name is Meng. I am 27 years old. I am a student of class 2.", result);
        }

        [Fact]
        public void Should_return_Zhouyun_39_teacher_class2_When_IntroduceWithRole_given_Teacher_Zhouyun_39_class2()
        {
            //Given
            var zhouyun = new Teacher()
            {
                Name = "Zhouyun",
                Age = 39,
                ClassNumber = 2
            };
            //When
            var result = zhouyun.IntroduceWithClass();
            //Then
            Assert.Equal("My name is Zhouyun. I am 39 years old. I am a teacher of class 2.", result);
        }

        [Fact]
        public void Should_welcome_Tom_when_Tom_jois_class2()
        {
            //Given
            var meng = new Student()
            {
                Name = "Meng",
                Age = 27,
                ClassNumber = 2,
            };
            var yanxi = new Student()
            {
                Name = "Yanxi",
                Age = 18,
                ClassNumber = 2,
            };
            var zhouyun = new Teacher()
            {
                Name = "Zhouyun",
                Age = 39,
                ClassNumber = 2,
            };
            var tom = new Student()
            {
                Name = "Tom",
                Age = 18,
            };
            var class2 = new Class()
            {
                ClassNumber = 2,
                Students = new List<Student>() { meng, yanxi, },
                Teacher = zhouyun,
            };
            //When
            var welcome = class2.AddNewStudent(tom);
            //Then
            Assert.Equal(2, tom.ClassNumber);
            Assert.Equal("My name is Meng. I am 27 years old. I am a student of class 2. Welcome Tom join class 2.\nMy name is Yanxi. I am 18 years old. I am a student of class 2. Welcome Tom join class 2.\nMy name is Zhouyun. I am 39 years old. I am a teacher of class 2. Welcome Tom join class 2.\n", welcome);
        }
    }
}
