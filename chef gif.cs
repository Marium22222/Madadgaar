using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class chef_gif : Form
    {
        public chef_gif()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval==2000)
            {
                timer1.Stop();
                chef_form caf = new chef_form();
                caf.Show();
                this.Hide();

            }
        }
    }
}
