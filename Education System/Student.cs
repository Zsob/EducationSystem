using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_System
{
    class Student
    {
        public string Account;
        public string Name;
        public string Password;
        public string FirstQuestion;
        public string SecondQuestion;
        public string FirstAnswer;
        public string SecondAnswer;
        public Student(string Account, string Name,string Password)
        {
            this.Account = Account;
            this.Name = Name;
            this.Password = Password;
        }
        public static  Student  newStudent= new Student("3190707011", "曾极涵","123");

    }
}
