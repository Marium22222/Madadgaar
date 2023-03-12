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
    public partial class living_pr : UserControl
    {
        public living_pr()
        {
            InitializeComponent();
        }
        int score = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = true;
            if (guna2RadioButton4.Checked == true)

            {
                score++;
               

            }
            if (guna2RadioButton5.Checked == true)

            {
                score++;
               

            }

            if (guna2RadioButton9.Checked == true)

            {
                score++;
               

            }
            label6.Text = Convert.ToString(score);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            score = 0;
            guna2RadioButton1.Checked = false;
            guna2RadioButton2.Checked = false;
            guna2RadioButton3.Checked = false;
            guna2RadioButton4.Checked = false;
            guna2RadioButton5.Checked = false;
            guna2RadioButton6.Checked = false;
            guna2RadioButton7.Checked = false;
            guna2RadioButton8.Checked = false;
            guna2RadioButton9.Checked = false;
            guna2RadioButton10.Checked = false;
            guna2RadioButton11.Checked = false;
            guna2RadioButton12.Checked = false;
    
        }

        private void living_pr_Load(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
        }
    }
}
