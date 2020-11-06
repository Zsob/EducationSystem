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
    public partial class Form_System : Form
    {
        public Form_System()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox_Acountment.Text = Student.newStudent.StudentNo;
            if(textBox_Acountment.Text=="未登录")
            {
                bt_Desktop.Enabled = bt_Evaluation.Enabled = bt_ExamRegistration.Enabled = bt_Grade.Enabled = bt_Management.Enabled = bt_Practice.Enabled=btn_LogOut.Enabled = false;
            }
        }

        private void bt_Desktop_Click(object sender, EventArgs e)
        {
            DesktopForm desktopForm = new DesktopForm();
            desktopForm.Show();
        }

        private void bt_Grade_Click(object sender, EventArgs e)
        {
            StudentGrade studentStatus = new StudentGrade();
            studentStatus.Show();
        }

        private void bt_Management_Click(object sender, EventArgs e)
        {
            TrainingManagement trainingManagement = new TrainingManagement();
            trainingManagement.Show();
        }

        private void bt_ExamRegistration_Click(object sender, EventArgs e)
        {
            ExamRegistration examRegistration = new ExamRegistration();
            examRegistration.Show();
        }

        private void bt_Practice_Click(object sender, EventArgs e)
        {
            PracticeLink practiceLink = new PracticeLink();
            practiceLink.Show();
        }

        private void bt_Evaluation_Click(object sender, EventArgs e)
        {
            TeachingEvaluation teachingEvaluation = new TeachingEvaluation();
            teachingEvaluation.Show();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            textBox_Acountment.Text = Student.newStudent.StudentNo;
            if (textBox_Acountment.Text == "未登录")
            {
                bt_Desktop.Enabled = bt_Evaluation.Enabled = bt_ExamRegistration.Enabled = bt_Grade.Enabled = bt_Management.Enabled = bt_Practice.Enabled = btn_LogOut.Enabled = false;
            }
            else
            {
                bt_Desktop.Enabled = bt_Evaluation.Enabled = bt_ExamRegistration.Enabled = bt_Grade.Enabled = bt_Management.Enabled = bt_Practice.Enabled = btn_LogOut.Enabled = true;
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            textBox_Acountment.Text = Student.newStudent.StudentNo = "未登录";
            bt_Desktop.Enabled = bt_Evaluation.Enabled = bt_ExamRegistration.Enabled = bt_Grade.Enabled = bt_Management.Enabled = bt_Practice.Enabled = btn_LogOut.Enabled = false;
        }
    }
}
