using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;


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

        private void Form_System_MouseMove(object sender, MouseEventArgs e)
        {
            
            

        }

        private void Form_System_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_Acountment.Text = Student.newStudent.StudentNo;
            if (textBox_Acountment.Text == "未登录")
            {
                bt_Desktop.Enabled = bt_Evaluation.Enabled = bt_ExamRegistration.Enabled = bt_Grade.Enabled = bt_Management.Enabled = bt_Practice.Enabled = btn_LogOut.Enabled = false;
                lbl_BirthdayFill.Text = lbl_GenderFill.Text = lbl_NameFill.Text = lbl_NoFill.Text = lbl_PhoneFill.Text = "";
            }
            else
            {
                bt_Desktop.Enabled = bt_Evaluation.Enabled = bt_ExamRegistration.Enabled = bt_Grade.Enabled = bt_Management.Enabled = bt_Practice.Enabled = btn_LogOut.Enabled = true;
                lbl_NoFill.Text = textBox_Acountment.Text;
                string commandText =
                    $@"SELECT * FROM dbo.tb_StudentInformation WHERE StudentID='{textBox_Acountment.Text}'";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickRead(commandText);
                
                if (sqlHelper.HasRecord)
                {
                    lbl_BirthdayFill.Text = ((DateTime)sqlHelper["Birthday"]).ToLongDateString().ToString();
                    lbl_GenderFill.Text = sqlHelper["Gender"].ToString();
                    lbl_NameFill.Text = sqlHelper["StudentName"].ToString();
                    lbl_PhoneFill.Text = sqlHelper["Phone"].ToString();
                    
                }
            }
        }
    }
}
