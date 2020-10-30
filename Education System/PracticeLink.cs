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
    public partial class PracticeLink : Form
    {
        public PracticeLink()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.Show();

        }

        private void button_Reservation_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.Show();

        }
    }
}
