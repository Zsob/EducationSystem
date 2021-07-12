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
        public void FormLoad()
        {
            //学生选课中心
            commandText = $@"SELECT
		                    S.CourseNo AS 课程号,S.CourseName AS 课程,S.FacultyName AS 教师,IIF(SS.StudentNo IS NOT  NULL,'已选','未选') AS 状态
		                    FROM dbo.tb_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		                    WHERE S.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(commandText, dgv_AllCourses);
            commandText = $@"SELECT
		                    S.CourseNo AS 课程号,S.CourseName AS 课程,S.FacultyName AS 教师,IIF(SS.Score IS  NULL,'可退选','不可退选') AS 状态
		                    FROM dbo.tb_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		                    WHERE S.StudentNo='{Student.newStudent.StudentNo}' AND SS.StudentNo IS NOT NULL";
            sqlHelper.QuickFill(commandText, dgv_SelectedCourse);
            //

        }

        //
        private int ClickCount = 0;

        private void AddTerm()
        {
            String TermCommand = "SELECT T.Name FROM dbo.tb_Term AS T";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(TermCommand);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Term.Items.Add(sqlHelper["Name"]);
            }
        }
            //
            private void BorrowClass()//教室借用
        {
            commandText = $@"SELECT
	                        Classroom AS 教室
	                        ,IIF(Monday IS NOT NULL,IIF(Monday='3190707011','√',IIF(Monday='0','●','▲')),'') AS 星期一
	                        ,IIF(Tuesday IS NOT NULL,IIF(Tuesday='3190707011','√',IIF(Tuesday='0','●','▲')),'') AS 星期二
	                        ,IIF(Wednesday IS NOT NULL,IIF(Wednesday='3190707011','√',IIF(Wednesday='0','●','▲')),'') AS 星期三
	                        ,IIF(Thursday IS NOT NULL,IIF(Thursday='3190707011','√',IIF(Thursday='0','●','▲')),'') AS 星期四
	                        ,IIF(Friday IS NOT NULL,IIF(Friday='3190707011','√',IIF(Friday='0','●','▲')),'') AS 星期五
                        FROM dbo.tb_ClassroomBorrow";
            sqlHelper.QuickFill(commandText, dgv_ClassroomBorrow);
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
            //教室借用
            BorrowClass();
            //
            gpb_BookPurchase.Visible = true;
            gpb_Record.Visible = false;
            this.ClickCount++;
            if (this.ClickCount == 1)
            {
                this.AddTerm();
            }

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



        private void btn_ClassroomBorrow_Click(object sender, EventArgs e)
        {
            if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("选择失败！");
                return;
            }
            else if (dgv_ClassroomBorrow.CurrentCell.Value.ToString() != "")
            {
                MessageBox.Show("该教室已被使用！");
                return;
            }
            else
            {
                if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 1)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                        SET Monday='{Student.newStudent.StudentNo}'
                                        WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 2)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                        SET Tuesday='{Student.newStudent.StudentNo}'
                                        WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 3)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                        SET Wednesday='{Student.newStudent.StudentNo}'
                                        WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 4)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                        SET Thursday='{Student.newStudent.StudentNo}'
                                        WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 5)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                        SET Friday='{Student.newStudent.StudentNo}'
                                        WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                int result = sqlHelper.QuickSubmit(commandText);
                if (result > 0)
                {
                    BorrowClass();
                    MessageBox.Show("借用成功！");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("退选失败！");
                return;
            }
            else if (dgv_ClassroomBorrow.CurrentCell.Value.ToString() == "")
            {
                MessageBox.Show("该教室未被借用！");
                return;
            }
            else if (dgv_ClassroomBorrow.CurrentCell.Value.ToString() == "√")
            {
                if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 1)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                    SET Monday=NULL
                                    WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 2)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                    SET Tuesday=NULL
                                    WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 3)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                    SET Wednesday=NULL
                                    WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 4)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                    SET Thursday=NULL
                                    WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                else if (dgv_ClassroomBorrow.CurrentCell.ColumnIndex == 5)
                {
                    commandText = $@"UPDATE dbo.tb_ClassroomBorrow
                                    SET Friday=NULL
                                    WHERE Classroom='{dgv_ClassroomBorrow.CurrentRow.Cells["教室"].Value.ToString()}'";
                }
                int result = sqlHelper.QuickSubmit(commandText);
                if (result > 0)
                {
                    BorrowClass();
                    MessageBox.Show("退借成功！");
                }

            }
            else
            {
                MessageBox.Show("该教室不为本人借用！");
                return;
            }
            //

        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            //
            SqlHelper sqlHelper = new SqlHelper();
            string CurrentMessegeBook = this.gv_Book.CurrentRow.Cells["教材名称"].Value.ToString();
            string CommandBookNo = $@"SELECT No FROM dbo.tb_Book WHERE Name='{CurrentMessegeBook}'";
            string Return = sqlHelper.QuickReturn<string>(CommandBookNo);
            string Insert = $@"INSERT dbo.tb_BookRecord(StudentNo,BookNo)VALUES('{Student.newStudent.StudentNo}','{Return}')";
            if ((int)MessageBox.Show($@"您确定要订购教材《{CurrentMessegeBook}》吗？", "教材订购提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == 1)
            {
                sqlHelper.QuickSubmit(Insert);
            }

            String Command = $@"SELECT T.Name AS 学期,TT.CourseNo AS 课程号,C.Name AS 课程名称,B.Isbn AS 书号,B.Name AS 教材名称,B.Press AS 出版社,B.Author AS 作者,B.Price AS 价格 
FROM dbo.tb_TeachingTask AS TT JOIN dbo.tb_Term AS T ON T.No = TT.TermNo JOIN dbo.tb_Book AS B ON B.No=TT.BookNo JOIN dbo.tb_Course AS C ON TT.CourseNo=C.No 
WHERE TT.BookNo NOT IN (SELECT BookNo FROM dbo.tb_BookRecord WHERE StudentNo='{Student.newStudent.StudentNo}') AND T.Name='{cmb_Term.SelectedItem}'";
            sqlHelper.QuickFill(Command, gv_Book);
            return;

        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            gpb_BookPurchase.Visible = false;
            gpb_Record.Visible = true;
            string Command = $@"SELECT DISTINCT BR.StudentNo, T.Name AS 学期,TT.CourseNo AS 课程号,C.Name AS 课程名称,B.Isbn AS 书号,B.Name AS 教材名称,B.Press AS 出版社,B.Author AS 作者,B.Price AS 价格 
FROM dbo.tb_TeachingTask AS TT JOIN dbo.tb_Term AS T ON T.No = TT.TermNo JOIN dbo.tb_Book AS B ON B.No=TT.BookNo JOIN dbo.tb_Course AS C ON TT.CourseNo=C.No JOIN dbo.tb_BookRecord AS BR ON BR.BookNo = TT.BookNo WHERE BR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(Command, gv_Record);

        }

        private void cmb_Term_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            String Command = $@"SELECT T.Name AS 学期,TT.CourseNo AS 课程号,C.Name AS 课程名称,B.Isbn AS 书号,B.Name AS 教材名称,B.Press AS 出版社,B.Author AS 作者,B.Price AS 价格 
FROM dbo.tb_TeachingTask AS TT JOIN dbo.tb_Term AS T ON T.No = TT.TermNo JOIN dbo.tb_Book AS B ON B.No=TT.BookNo JOIN dbo.tb_Course AS C ON TT.CourseNo=C.No 
WHERE TT.BookNo NOT IN (SELECT BookNo FROM dbo.tb_BookRecord WHERE StudentNo='{Student.newStudent.StudentNo}') AND T.Name='{cmb_Term.SelectedItem}'";
            sqlHelper.QuickFill(Command, gv_Book);
            return;

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            String CommandAll = $@"SELECT DISTINCT T.Name AS 学期,TT.CourseNo AS 课程号,C.Name AS 课程名称,B.Isbn AS 书号,B.Name AS 教材名称,B.Press AS 出版社,B.Author AS 作者,B.Price AS 价格 
FROM dbo.tb_TeachingTask AS TT JOIN dbo.tb_Term AS T ON T.No = TT.TermNo JOIN dbo.tb_Book AS B ON B.No=TT.BookNo JOIN dbo.tb_Course AS C ON TT.CourseNo=C.No 
WHERE TT.BookNo NOT IN (SELECT BookNo FROM dbo.tb_BookRecord WHERE StudentNo='{Student.newStudent.StudentNo}')";
            sqlHelper.QuickFill(CommandAll, gv_Book);
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpb_BookPurchase.Visible = true;
            gpb_Record.Visible = false;
            this.ClickCount++;
            if (this.ClickCount == 1)
            {
                this.AddTerm();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            string CurrentMessegeBook = this.gv_Record.CurrentRow.Cells["教材名称"].Value.ToString();
            string CommandBookNo = $@"SELECT No FROM dbo.tb_Book WHERE Name='{CurrentMessegeBook}'";
            string Return = sqlHelper.QuickReturn<string>(CommandBookNo);
            string Delete = $@"DELETE dbo.tb_BookRecord WHERE StudentNo='{Student.newStudent.StudentNo}' AND BookNo='{Return}'";
            if ((int)MessageBox.Show($@"您确定要退订教材《{CurrentMessegeBook}》吗？", "教材退订提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == 1)
            {
                sqlHelper.QuickSubmit(Delete);
            }

            string Command = $@"SELECT BR.StudentNo AS 学号, T.Name AS 学期,TT.CourseNo AS 课程号,C.Name AS 课程名称,B.Isbn AS 书号,B.Name AS 教材名称,B.Press AS 出版社,B.Author AS 作者,B.Price AS 价格 
FROM dbo.tb_TeachingTask AS TT JOIN dbo.tb_Term AS T ON T.No = TT.TermNo JOIN dbo.tb_Book AS B ON B.No=TT.BookNo JOIN dbo.tb_Course AS C ON TT.CourseNo=C.No JOIN dbo.tb_BookRecord AS BR ON BR.BookNo = TT.BookNo WHERE BR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(Command, gv_Record);

        }

        private void btn_CancelAll_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            string Delete = $@"DELETE dbo.tb_BookRecord WHERE StudentNo='{Student.newStudent.StudentNo}'";
            if ((int)MessageBox.Show($@"您确定要退订所有材吗？", "教材退订提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == 1)
            {
                sqlHelper.QuickSubmit(Delete);
            }

            string Command = $@"SELECT BR.StudentNo AS 学号, T.Name AS 学期,TT.CourseNo AS 课程号,C.Name AS 课程名称,B.Isbn AS 书号,B.Name AS 教材名称,B.Press AS 出版社,B.Author AS 作者,B.Price AS 价格 
FROM dbo.tb_TeachingTask AS TT JOIN dbo.tb_Term AS T ON T.No = TT.TermNo JOIN dbo.tb_Book AS B ON B.No=TT.BookNo JOIN dbo.tb_Course AS C ON TT.CourseNo=C.No JOIN dbo.tb_BookRecord AS BR ON BR.BookNo = TT.BookNo WHERE BR.StudentNo='{Student.newStudent.StudentNo}'";
            sqlHelper.QuickFill(Command, gv_Record);

        }
    }
}
