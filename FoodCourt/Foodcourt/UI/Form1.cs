using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodcourt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnKFC_Click(object sender, EventArgs e)
        {
            FormKFC fhu = new FormKFC();
            fhu.Show();
            this.Hide();
        }

     

        private void btnAsen_Click(object sender, EventArgs e)
        {
            FormAsen fhu = new FormAsen();
            fhu.Show();
            this.Hide();
        }

        private void btnRumahMakanUdaSayang_Click(object sender, EventArgs e)
        {
            FormRumahMakanUdaSayang fhu = new FormRumahMakanUdaSayang();
            fhu.Show();
            this.Hide();
        }

        private void btnSatePadangPariaman_Click(object sender, EventArgs e)
        {
            FormSatePadangPariaman fhu = new FormSatePadangPariaman();
            fhu.Show();
            this.Hide();
        }
    }
}
