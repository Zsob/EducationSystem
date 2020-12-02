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
    public partial class StudentGrade : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        public StudentGrade()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //学籍信息
            sqlHelper.QuickRead("SELECT * FROM dbo.tb_Major");
            while (sqlHelper.HasRecord)
            {
                comboBox_Class.Items.Add(sqlHelper["Name"]);
            }
            sqlHelper.QuickRead($@"SELECT * FROM dbo.tb_StudentInformation WHERE StudentID='{Student.newStudent.StudentNo}'");
            if(sqlHelper.HasRecord)
            {
                txt_Name.Text = sqlHelper["StudentName"].ToString();
                txt_Phone.Text = sqlHelper["Phone"].ToString();
                txt_StudentNo.Text = sqlHelper["StudentID"].ToString();
                string gender = sqlHelper["Gender"].ToString();
                if (gender.Equals("男"))
                {
                    rdb_Male.Checked = true;
                }
                rdb_Female.Checked = !rdb_Male.Checked;
                dtp_Birthday.Value = (DateTime)sqlHelper["Birthday"];
                comboBox_Class.SelectedItem= sqlHelper["Class"].ToString();
            }
            //课程成绩查询
            sqlHelper.QuickRead($@"SELECT * FROM dbo.vw_StudentScore WHERE StudentNo='{Student.newStudent.StudentNo}'AND TotalScore IS NOT NULL");
            while (sqlHelper.HasRecord)
            {
                comboBox_StartTime.Items.Add(sqlHelper["Term"].ToString());
            }
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBoxProfession.Items.Clear();
            if (comboBoxDepartment.SelectedIndex==0)
            {
                comboBoxProfession.Items.Add("信息管理与信息系统");
                comboBoxProfession.Items.Add("健康管理");
                comboBoxProfession.Items.Add("公共事业管理");
            }
            else if(comboBoxDepartment.SelectedIndex==1)
            {
                comboBoxProfession.Items.Add("中医学");
                comboBoxProfession.Items.Add("中药学");

            }
            else if(comboBoxDepartment.SelectedIndex==2)
            {
                comboBoxProfession.Items.Add("针灸甲班");
                comboBoxProfession.Items.Add("针灸乙班");
            }
            else if(comboBoxDepartment.SelectedIndex==3)
            {
                comboBoxProfession.Items.Add("护理学");

            }
            else if (comboBoxDepartment.SelectedIndex == 4)
            {
                comboBoxProfession.Items.Add("中西医结合");

            }

        }

        private void buttonStudentStatusManagement_Click(object sender, EventArgs e)
        {
            

                MessageBox.Show("必选项未选！");
            
           
        }

        private void buttonInquire_Click(object sender, EventArgs e)
        {
            string commandText= $@"SELECT Term,CourseName AS 课程名称  
		                        ,BasicScore AS 平时成绩 
		                        ,FinalScore AS 期末成绩 
		                        ,TotalScore AS 总成绩 
                                FROM dbo.vw_StudentScore WHERE StudentNo = '3190707011' AND TotalScore IS NOT NULL";
            if (comboBox_StartTime.SelectedIndex!=-1)
            {
                commandText = commandText + $@"And Term='{comboBox_StartTime.SelectedItem.ToString()}";
            }
            DataForm data = new DataForm(commandText);
            data.Show();
            
        }
    }
}
