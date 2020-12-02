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
    public partial class TrainingManagement : Form
    {
        string commandText;
        SqlHelper sqlHelper = new SqlHelper();
        public void FormLoad()//学生选课中心
        {
            commandText = $@"SELECT
		                    S.CourseNo AS 课程号,S.CourseName AS 课程,S.FacultyName AS 教师,IIF(SS.StudentNo IS NOT  NULL,'已选','未选') AS 状态
		                    FROM dbo.vw_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		                    WHERE S.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(commandText, dgv_AllCourses);
            commandText = $@"SELECT
		                    S.CourseNo AS 课程号,S.CourseName AS 课程,S.FacultyName AS 教师,IIF(SS.Score IS  NULL,'可退选','不可退选') AS 状态
		                    FROM dbo.vw_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		                    WHERE S.StudentNo='{Student.newStudent.StudentNo}' AND SS.StudentNo IS NOT NULL";
            sqlHelper.QuickFill(commandText, dgv_SelectedCourse);

        }
        public TrainingManagement()
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

        private void button___Search_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();

        }

        private void TrainingManagement_Load(object sender, EventArgs e)
        {
            //学生选课中心
            FormLoad();
        }

        private void btn_SelectCoures_Click(object sender, EventArgs e)
        {
            if (dgv_AllCourses.CurrentRow.Cells["状态"].Value.ToString().Equals("已选"))
            {
                MessageBox.Show("该课程已选");
                return;
            }
            string no = dgv_AllCourses.CurrentRow.Cells["课程号"].Value.ToString();
            commandText = $@"INSERT dbo.tb_ScoreStatus(StudentNo,CourseNo,Score)
                                VALUES( '{Student.newStudent.StudentNo}','{no}',NULL)";

            sqlHelper.QuickSubmit(commandText);
            FormLoad();
        }

        private void btn_DropClass_Click(object sender, EventArgs e)
        {
            if (dgv_SelectedCourse.CurrentRow.Cells["状态"].Value.ToString().Equals("不可退选"))
            {
                MessageBox.Show("该课程已有成绩，不可退选");
                return;
            }
            string no = dgv_SelectedCourse.CurrentRow.Cells["课程号"].Value.ToString();
            commandText = $@"DELETE dbo.tb_ScoreStatus
                            WHERE CourseNo='{no}' AND StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickSubmit(commandText);
            FormLoad();

        }
    }
}
