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
    public partial class DataForm : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        public DataForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public DataForm(string command) :this ()
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
            sqlHelper.QuickFill(command, dgv_Data);
        }
    }
}
