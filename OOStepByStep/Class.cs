using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        public int ClassNumber { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }

        public string AddNewStudent(Student newStudent)
        {
            var welcome = Welcome(newStudent);
            newStudent.ClassNumber = ClassNumber;
            Students.Add(newStudent);
            return welcome;
        }

        private string Welcome(Student newStudent)
        {
            string welcome = string.Empty;
            foreach (var student in Students)
            {
                welcome += student.IntroduceWithClass() + $" Welcome {newStudent.Name} join class {ClassNumber}.\n";
            }

            welcome += Teacher.IntroduceWithClass() + $" Welcome {newStudent.Name} join class {ClassNumber}.\n";
            return welcome;
        }
    }
}
