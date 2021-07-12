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
    public partial class MessageReply : Form
    {
        string No;
        public MessageReply()
        {
            InitializeComponent();
        }
        public MessageReply(string no,string title,string content) : this()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_title.Text += title;
            lbl_content.Text += content;
            No = no;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_reply.Text=="")
            {
                MessageBox.Show("已取消回复！");
                Close();
                return;
            }
            string commandText = $@"UPDATE dbo.tb_MessageRecord
                                    SET Reply='{txt_reply.Text}'
                                    WHERE StudentNo='{Student.newStudent.StudentNo}' AND ID='{No}'";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickSubmit(commandText);
            if (result!=0)
            {
                MessageBox.Show("回复成功！");
                Close();
            }
        }
    }
}
