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
    
    public partial class ExamRegistration : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        string commandText;
        string no;
        private void ExamEnroll()
        {
            commandText = $@"SELECT
                                 E.ExamNo AS 考试编号,E.ExamName AS 考试名称,IIF(EE.StudentNo IS NOT NULL,'已报名','未报名') AS 状态
                                 FROM dbo.tb_Exam AS E LEFT JOIN dbo.tb_ExamEnroll AS EE ON E.ExamNo=EE.ExamNo AND EE.StudentNo='{Student.newStudent.StudentNo}'
                                 WHERE MONTH(E.Time)>MONTH(GETDATE())-2";
            sqlHelper.QuickFill(commandText, dataGridViewExamEnroll);
        }
            

        public ExamRegistration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void button__Search_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void button___Search_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void button____Search_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void button_____Search_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void ExamRegistration_Load(object sender, EventArgs e)
        {
            //考试报名
            ExamEnroll();
        }

        private void buttonExamEnroll_Click(object sender, EventArgs e)
        {
            if (dataGridViewExamEnroll.CurrentRow.Cells["状态"].Value.ToString().Equals("已报名"))
            {
                MessageBox.Show("该考试已报名！");
                return;
            }
            no = dataGridViewExamEnroll.CurrentRow.Cells["考试编号"].Value.ToString();
            commandText = $@" INSERT dbo.tb_ExamEnroll (StudentNo,ExamNo ) VALUES('{Student.newStudent.StudentNo}', '{no}')";
            sqlHelper.QuickSubmit(commandText);
            ExamEnroll();
        }

        private void buttonExamWithdraw_Click(object sender, EventArgs e)
        {
            if (dataGridViewExamEnroll.CurrentRow.Cells["状态"].Value.ToString().Equals("未报名"))
            {
                MessageBox.Show("该考试未报名！");
                return;
            }
            no = dataGridViewExamEnroll.CurrentRow.Cells["考试编号"].Value.ToString();
            commandText = $@" DELETE dbo.tb_ExamEnroll
                                 WHERE StudentNo='{Student.newStudent.StudentNo}' AND ExamNo='{no}'";
            sqlHelper.QuickSubmit(commandText);
            ExamEnroll();
        }
    }
}
