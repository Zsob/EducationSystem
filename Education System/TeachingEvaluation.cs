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
    public partial class TeachingEvaluation : Form
    {
        SqlHelper SqlHelper = new SqlHelper();
        string commandText,courseNo;
        int point=0;
        public TeachingEvaluation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void TeachingEvaluation_Load(object sender, EventArgs e)
        {
            DataUpdate();
        }

        private void DataUpdate()
        {
            commandText = $@"SELECT CourseNo AS 课程号,CourseName AS 课程名,FacultyName AS 教师,CourseType AS 课程类型,'未评教' AS 状态
                            FROM dbo.tb_StudentScore
                            WHERE StudentNo = '{Student.newStudent.StudentNo}' AND TotalScore IS NOT NULL AND FacultyRate IS NULL AND BeginningTime<GETDATE() AND EndingTime>GETDATE()";
            SqlHelper.QuickFill(commandText, dgv_Evaluate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gbx_Evaluate.Visible = !gbx_Evaluate.Visible;
            gbx_Teaching.Visible = !gbx_Teaching.Visible;
        }

        private void radioButton_1Point_CheckedChanged(object sender, EventArgs e)
        {
            point = 1;
        }

        private void dgv_Evaluate_DoubleClick(object sender, EventArgs e)
        {
            lbl_Title.Text="请为"+dgv_Evaluate.CurrentRow.Cells["课程名"].Value.ToString()+"课程进行评教";
            courseNo = dgv_Evaluate.CurrentRow.Cells["课程号"].Value.ToString();
            gbx_Evaluate.Visible = !gbx_Evaluate.Visible;
            gbx_Teaching.Visible = !gbx_Teaching.Visible;
        }

        private void radioButton_2Point_CheckedChanged(object sender, EventArgs e)
        {
            point = 2;
        }

        private void radioButton_3Point_CheckedChanged(object sender, EventArgs e)
        {
            point = 3;
        }

        private void radioButton_4Point_CheckedChanged(object sender, EventArgs e)
        {
            point = 4;
        }

        private void radioButton_5Point_CheckedChanged(object sender, EventArgs e)
        {
            point = 5;
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            gbx_Evaluate.Visible = !gbx_Evaluate.Visible;
            gbx_Teaching.Visible = !gbx_Teaching.Visible;
            DataUpdate();
            point = 0;
            lbl_Title.Text = null;
            radioButton_1Point.Checked = radioButton_2Point.Checked = radioButton_3Point.Checked = radioButton_4Point.Checked = radioButton_5Point.Checked = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (point==0)
            {
                MessageBox.Show("请进行评教！");
                return;
            }
            commandText = $@"UPDATE dbo.tb_StudentScore
                                SET FacultyRate={point}
                                WHERE StudentNo='{Student.newStudent.StudentNo}' AND CourseNo='{courseNo}'";
            int result = SqlHelper.QuickSubmit(commandText);
            if (result>0)
            {
                MessageBox.Show("评教成功！");
                gbx_Evaluate.Visible = !gbx_Evaluate.Visible;
                gbx_Teaching.Visible = !gbx_Teaching.Visible;

            }
            DataUpdate();
            point = 0;
            lbl_Title.Text = null;
            radioButton_1Point.Checked = radioButton_2Point.Checked = radioButton_3Point.Checked = radioButton_4Point.Checked = radioButton_5Point.Checked = false;
        }
    }
}
