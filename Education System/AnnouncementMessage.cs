using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_System
{
    class AnnouncementMessage
    {
        public Student student;
        public List<string> Announcement = new List<string>();
        public List<string> Message = new List<string>();
        public AnnouncementMessage(Student student,List<string> announcement,List<string> message)
        {
            this.student = student;
            this.Announcement = announcement;
            this.Message = message;
        }
        static List<string> announcement = new List<string>() { "测试公告" };
        static List<string> message = new List<string>() { "测试留言" };
        public static AnnouncementMessage newAnnouncementMessage = new AnnouncementMessage(Student.newStudent, announcement, message);
    }
}
