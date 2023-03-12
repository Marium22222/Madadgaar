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
    public partial class prime_practice : UserControl
    {
        public prime_practice()
        {
            InitializeComponent();
        }

        int score = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = true;
            if (guna2RadioButton11.Checked == true)

            {
                score++;
              

            }
            if (guna2RadioButton1.Checked == true)

            {
                score++;
                

            }

            if (guna2RadioButton6.Checked == true)

            {
                score++;
                

            }
            label6.Text = Convert.ToString(score);

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
            guna2RadioButton11.Checked = false;
            guna2RadioButton12.Checked = false;
            guna2RadioButton13.Checked = false;
            guna2RadioButton14.Checked = false;
         
        }

        private void prime_practice_Load(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
        }
    }
}
