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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT 1 
					FROM dbo.tb_StudentLogIn
					WHERE No='{this.txt_StudentNo.Text.Trim()}' AND Password='{this.txt_PassWord.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result=sqlHelper.QuickReturn<int>(commandText);
            if (result == 1)
            {
                Student.newStudent.StudentNo = txt_StudentNo.Text;
                MessageBox.Show("登录成功。");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txt_PassWord.Focus();
                this.txt_PassWord.SelectAll();
            }
        }
    }
}
