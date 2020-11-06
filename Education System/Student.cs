using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_System
{
    class Student
    {
        public string StudentNo;
        public string Name;
        public string Password;
        public string FirstQuestion;
        public string SecondQuestion;
        public string FirstAnswer;
        public string SecondAnswer;
        public Student(string StudentNo)
        {
            this.StudentNo = StudentNo;
        }
        public static Student newStudent = new Student("未登录");

    }
}
