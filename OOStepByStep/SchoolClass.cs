using System.Collections.Generic;

namespace OOStepByStep
{
    public class SchoolClass
    {
        private string className;

        private Teacher teacher;
        private List<Student> students = new List<Student>();

        public SchoolClass(string className)
        {
            this.className = className;
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }

        public string AddNewStudentWellcome(Student newStudent)
        {

            if (newStudent.ClassName == className)
            {
                string welcomeMessage = WelcomeMessage(newStudent);
                this.students.Add(newStudent);
                return welcomeMessage;

            }

            return string.Empty;
        }

        private string WelcomeMessage(Student newStudent)
        {
            string studentsWelcome = string.Empty;
            foreach (Student oldStudent in students)
            {
                studentsWelcome += $"{oldStudent.WellcomeNewStudent(newStudent)}\n";
            }

            return studentsWelcome;
        }
    }
}