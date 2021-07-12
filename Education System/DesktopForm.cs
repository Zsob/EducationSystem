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
    public partial class DesktopForm : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        public DesktopForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Student student = Student.newStudent;
            textBox_Accounment.Text = textBox_Account.Text = student.StudentNo;
            DataFill();

        }

        private void DataFill()
        {
            string commandText = $@"SELECT
                        		A.AnnouncementID AS 通知编号
		                        ,A.AnnouncementTitle AS 通知标题
		                        ,A.Announcement AS 通知内容
                                ,ISNULL(MR.Reply,'无') AS 回复
		                        ,IIF(MR.StudentNo IS NULL,'未读','已读') AS 状态
		                        FROM dbo.tb_Announcement AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.AnnouncementID=MR.ID AND MR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(commandText, this.dgv_Announcement);
            commandText = $@"SELECT
		                    A.MessageID AS 留言编号
		                    ,A.MessageTitle AS 留言标题
		                    ,A.Message AS 留言内容
                            ,ISNULL(MR.Reply,'无') AS 回复
		                    ,IIF(MR.StudentNo IS NULL,'未读','已读') AS 状态
		                    FROM dbo.tb_Message AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.MessageID=MR.ID AND MR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(commandText, this.dgv_Message);
        }

        private void button_SavePassword_Click(object sender, EventArgs e)
        {
            string commandText = $@"SELECT 1 FROM dbo.tb_StudentLogIn WHERE No='{Student.newStudent.StudentNo}'AND Password=HASHBYTES('MD5','{textBox_OldPassword.Text}')";
            if (textBox_OldPassword.Text.Trim() == string.Empty || textBox_NewPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("必填框内容为空");
            }
            else if (textBox_CheekPassword.Text != textBox_NewPassword.Text)
            {
                MessageBox.Show("新密码与确认新密码不一致！");
            }
            else if (textBox_OldPassword.Text == textBox_NewPassword.Text)
            {
                MessageBox.Show("旧密码与新密码相同！");

            }
            else if (sqlHelper.QuickReturn<int>(commandText) == 1)
            {
                commandText = $@"UPDATE dbo.tb_StudentLogIn SET Password=HASHBYTES('MD5','{textBox_NewPassword.Text}') WHERE No='{textBox_Accounment.Text}'";
                int result = sqlHelper.QuickSubmit(commandText);
                if (result > 0)
                {
                    MessageBox.Show("密码修改成功！");
                    textBox_OldPassword.Clear();
                    textBox_NewPassword.Clear();
                    textBox_CheekPassword.Clear();

                }

            }
            else
            {
                MessageBox.Show("旧密码输入错误！");
            }
        }

        private void button_ResetPassword_Click(object sender, EventArgs e)
        {
            textBox_OldPassword.Clear();
            textBox_NewPassword.Clear();
            textBox_CheekPassword.Clear();
        }

        private void button_SaveImformation_Click(object sender, EventArgs e)
        {
            string name= sqlHelper.QuickReturn<string>($@"SELECT StudentName FROM dbo.tb_StudentInformation WHERE StudentID = '{Student.newStudent.StudentNo}'");
            if (sqlHelper.HasRecord)
            {
            if (!name.Equals(textBox_Name.ToString()))
            {
                textBox_Name.Clear();
                textBox_FirstQuestion.Clear();
                textBox_FirstAnswer.Clear();
                textBox_SecondQuestion.Clear();
                textBox_SecondAnswer.Clear();
                MessageBox.Show("名字输入错误！");
                return;
            }

            }
            sqlHelper.QuickSubmit($@"UPDATE dbo.tb_StudentInformation
                                    SET FirstQuestion='{textBox_FirstQuestion.Text}',FirstAnswer='{textBox_FirstAnswer.Text}',SecendQuestion='{textBox_SecondQuestion.Text}',SecendAnswer='{textBox_SecondAnswer.Text}'
                                    WHERE StudentID='{Student.newStudent.StudentNo}'");
            MessageBox.Show("密保问题修改成功！");
        }

        private void button_ResetImformation_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_FirstQuestion.Clear();
            textBox_FirstAnswer.Clear();
            textBox_SecondQuestion.Clear();
            textBox_SecondAnswer.Clear();
        }

        private void dgv_Announcement_DoubleClick(object sender, EventArgs e)
        {
            string no = dgv_Announcement.CurrentRow.Cells["通知编号"].Value.ToString();

            sqlHelper.QuickRead($@"SELECT * FROM dbo.tb_Announcement WHERE AnnouncementID = '{no}'; ");
            if (sqlHelper.HasRecord)
            {
                string message = sqlHelper["Announcement"].ToString();
                string title = sqlHelper["AnnouncementTitle"].ToString();
                MessageReply messageReply = new MessageReply(no, title, message);
                messageReply.FormClosed += MessageReply_FormClosed1;
                messageReply.Show();
            }
            string status= dgv_Announcement.CurrentRow.Cells["状态"].Value.ToString();
            if (status.Equals("未读"))
            {
                sqlHelper.QuickSubmit($@"INSERT INTO dbo.tb_MessageRecord(StudentNo,ID)
                                        VALUES(   '{Student.newStudent.StudentNo}','{no}')");
            }
            string commandText = $@"SELECT
                        		A.AnnouncementID AS 通知编号
		                        ,A.AnnouncementTitle AS 通知标题
		                        ,A.Announcement AS 通知内容
                                ,ISNULL(MR.Reply,'无') AS 回复
		                        ,IIF(MR.StudentNo IS NULL,'未读','已读') AS 状态
		                        FROM dbo.tb_Announcement AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.AnnouncementID=MR.ID AND MR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(commandText, this.dgv_Announcement);

        }

        private void MessageReply_FormClosed1(object sender, FormClosedEventArgs e)
        {
            DataFill();
        }

        private void dgv_Message_DoubleClick(object sender, EventArgs e)
        {
            string no = dgv_Message.CurrentRow.Cells["留言编号"].Value.ToString();

            sqlHelper.QuickRead($@"SELECT * FROM dbo.tb_Message WHERE MessageID = '{no}'; ");
            if (sqlHelper.HasRecord)
            {
                string message = sqlHelper["Message"].ToString();
                string title = sqlHelper["MessageTitle"].ToString();
                MessageReply messageReply = new MessageReply(no, title, message);
                //添加事件
                messageReply.FormClosed += MessageReply_FormClosed;
                messageReply.Show();
            }
            string status = dgv_Message.CurrentRow.Cells["状态"].Value.ToString();
            if (status.Equals("未读"))
            {
                sqlHelper.QuickSubmit($@"INSERT INTO dbo.tb_MessageRecord(StudentNo,ID)
                                        VALUES(   '{Student.newStudent.StudentNo}','{no}')");
            }

            string commandText = $@"SELECT
		                    A.MessageID AS 留言编号
		                    ,A.MessageTitle AS 留言标题
		                    ,A.Message AS 留言内容
                            ,ISNULL(MR.Reply,'无') AS 回复
		                    ,IIF(MR.StudentNo IS NULL,'未读','已读') AS 状态
		                    FROM dbo.tb_Message AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.MessageID=MR.ID AND MR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(commandText, this.dgv_Message);
        }

        private void MessageReply_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataFill();            
        }

        private void dgv_Announcement_Click(object sender, EventArgs e)
        {
            DataFill();
        }

        private void dgv_Message_Click(object sender, EventArgs e)
        {
            DataFill();
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            DataFill();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataFill();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataFill();
        }
    }
}
