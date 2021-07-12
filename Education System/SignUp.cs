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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"INSERT dbo.tb_StudentLogIn(No,Password)
                    VALUES({txt_StudentNo.Text},HASHBYTES('MD5','{this.txt_PassWord.Text.Trim()}'))";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功。");
                Close();
            }
            else
            {
                MessageBox.Show("注册失败！");
            }

        }
    }
}
