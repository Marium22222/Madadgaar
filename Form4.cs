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
    public partial class CreateAccount : Form
    {
        queryconnection qc = new queryconnection();
        string query;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || txtconfirmpass.Text == "" || txtaddress.Text == "" || txtphone.Text == "")
            {

                MessageBox.Show("Fill all the fields", "warning", MessageBoxButtons.OK);
            }
            else
            {
                if (txtpassword.Text == txtconfirmpass.Text)
                {
                    query = "insert into loginform (username,passwordd,address,phoneNo) values ('" + txtusername.Text + "','" + txtpassword.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "')";
                    qc.setData(query);
                    loginForm s = new loginForm();
                    s.Show();
                    this.Hide();


                }
                else
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "Incorrect password!";
                }
            }
        } 

        private void CreateAccount_Load(object sender, EventArgs e)
        {


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
