using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_System
{
    public partial class DesktopForm : Form
    {
        public DesktopForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Student student = Student.newStudent;
            textBox_Accounment.Text =textBox_Account.Text= student.Account;
            foreach (var announcement in AnnouncementMessage.newAnnouncementMessage.Announcement)
            {
                listBoxAnnouncement.Items.Add(announcement);
            }
            foreach (var message in AnnouncementMessage.newAnnouncementMessage.Message)
            {
                listBoxMessage.Items.Add(message);
            }
        }

        private void button_SavePassword_Click(object sender, EventArgs e)
        {
            Student student = Student.newStudent;
            if (textBox_OldPassword.Text == string.Empty || textBox_NewPassword.Text == string.Empty)
            {
                MessageBox.Show("必填框内容为空");
            }
            else if (textBox_OldPassword.Text != student.Password)
            {
                MessageBox.Show("旧密码输入错误！");
            }
            else if (textBox_CheekPassword.Text != textBox_NewPassword.Text)
            {
                MessageBox.Show("新密码与确认新密码不一致！");
            }
            else if (textBox_OldPassword.Text == textBox_NewPassword.Text)
            {
                MessageBox.Show("旧密码与新密码相同！");
            }
            else
            {
                student.Password = textBox_NewPassword.Text;
                MessageBox.Show("密码修改成功！");
            }
            Student.newStudent = student;
        }

        private void button_ResetPassword_Click(object sender, EventArgs e)
        {
            textBox_OldPassword.Clear();
            textBox_NewPassword.Clear();
            textBox_CheekPassword.Clear();
        }

        private void button_SaveImformation_Click(object sender, EventArgs e)
        {
            Student student = Student.newStudent;
            if(textBox_Name.Text!=student.Name)
            {
                MessageBox.Show("姓名输入错误！");
                textBox_Name.Clear();
            }
            else
            {
                student.FirstQuestion = textBox_FirstQuestion.Text;
                student.FirstAnswer = textBox_FirstAnswer.Text;
                student.SecondQuestion = textBox_SecondQuestion.Text;
                student.SecondAnswer = textBox_SecondAnswer.Text;
                MessageBox.Show("保存成功");
            }
        }

        private void button_ResetImformation_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_FirstQuestion.Clear();
            textBox_FirstAnswer.Clear();
            textBox_SecondQuestion.Clear();
            textBox_SecondAnswer.Clear();
        }
    }
}
