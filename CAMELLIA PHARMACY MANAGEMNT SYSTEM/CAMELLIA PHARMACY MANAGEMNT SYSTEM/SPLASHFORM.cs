using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMELLIA_PHARMACY_MANAGEMNT_SYSTEM
{
    public partial class SPLASHFORM : Form
    {
        public SPLASHFORM()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            progressivebar.Value = startpoint;
            if (progressivebar.Value == 100)
            {
                progressivebar.Value = 0;
                timer1.Stop();
                LOGINFORM login = new LOGINFORM();
                this.Hide();
                login.Show();
            }
        }
        private void SPLASHFORM_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
