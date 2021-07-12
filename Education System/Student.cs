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
        public Student(string StudentNo)
        {
            this.StudentNo = StudentNo;
        }
        public static Student newStudent = new Student("未登录");
        //public static Student newStudent = new Student("3190707011");
    }
}
