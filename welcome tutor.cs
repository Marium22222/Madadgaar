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
    public partial class welcome_tutor : Form
    {
        public welcome_tutor()
        {
            InitializeComponent();
        }
        int num = 0;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval==1000)
            {
                timer1.Stop();
                tutorform tf = new tutorform();
                tf.Show();
                this.Hide();
            }
        }
    }
}
