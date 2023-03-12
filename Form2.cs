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
    public partial class loginForm : Form
    {
        queryconnection qc = new queryconnection();
        string query;
        public loginForm()
        {
            InitializeComponent();
        }
        public static string username = "";
        public static int id;
        
        
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            username = guna2TextBox1.Text;
            
            
            query = "select * from loginform where username like '" + guna2TextBox1.Text + "' AND passwordd like '" + txtpassword.Text + "'";
            DataSet ds = qc.GetData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Invalid Information","LOGIN ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                id =Convert.ToInt32( ds.Tables[0].Rows[0]["id"]);
                services s = new services();
                s.Show();
                this.Hide();

            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            CreateAccount f4 = new CreateAccount();
            f4.Show();
            this.Hide();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminform af = new adminform();
            af.Show();
            this.Hide();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
