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
    public partial class displayform : Form
    {
        public displayform()
        {
            InitializeComponent();
        }
      
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            if (num == 0)
            {

                label2.Location = new Point(60,380);
                num++;
            }
            else if(num==1)
            {
                label2.Location = new Point(380,380);
                num++;
            }
            else if (num == 2)
            {
                label2.Location = new Point(610,380);
                num++;
            }
         
            else if(num==3)
            {
                timer1.Stop();
                loginForm lf = new loginForm();
                lf.Show();
                this.Hide();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
