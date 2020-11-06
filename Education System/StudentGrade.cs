using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_System
{
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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
            Data data = new Data();
            data.Show();
            
        }
    }
}
