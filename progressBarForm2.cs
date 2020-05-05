using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSys
{
    public partial class progressBarForm2 : Form
    {
        public progressBarForm2()
        {
            InitializeComponent();
        }

        private void progressBarForm2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if(progressBar1.Value >= 99)
            {
                mainForm2 m = new mainForm2();
                this.Hide();
                m.Show();

                timer1.Enabled = false;

                progressBar1.Value = progressBar1.Value - 1;

            }

        }
    }
}
