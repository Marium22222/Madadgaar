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
    public partial class services : Form
    {
        queryconnection qc = new queryconnection();
        string query;
        public services()
        {
            InitializeComponent();
        }
        bool btncap = false;
        bool btntail = false;
        bool btnelec = false;
        bool btnplum = false;


        private void carpenter_Click(object sender, EventArgs e)
        {
            label1.Show();
            guna2TextBox1.Show();
            guna2Button1.Show();
            guna2TextBox2.Show();
            guna2ComboBox1.Show();
            label2.Show();
            label3.Show();
            btncap = true;
            btntail = false;
            btnplum = false;
            btnelec = false;
            query = "select * from carpenter";
            DataSet ds = qc.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        //search city
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string query2 = "select * from tailor where address like '" + guna2TextBox1.Text + "%'";
            string query1 = "select * from carpenter where address like '" + guna2TextBox1.Text + "%'";
            string query4 = "select * from Electrician where address like '" + guna2TextBox1.Text + "%'";
            string query5 = "select * from plumber where address like '" + guna2TextBox1.Text + "%'";
            if (btncap == true)
            {
                query = query1;

            }
            else if (btntail == true)
            {
                query = query2;
            }
         
            else if (btnelec== true)
            {
                query = query4;
            }
            else if (btnplum == true)
            {
                query = query5;
            }
            DataSet ds = qc.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int index;
        
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            index = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);
            
            if (btntail == true|| btnelec == true|| btnplum == true|| btncap == true)
            {
                string g = Convert.ToString(guna2ComboBox1.SelectedItem);
                MessageBox.Show("Enter the timeslot", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            }
            /*else if (btnelec == true)
            {
                MessageBox.Show("Enter the timeslot", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
            }
            else if (btnplum == true)
            {
                MessageBox.Show("Enter the timeslot", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }

            else if (btncap == true)
            {
                MessageBox.Show("Enter the timeslot", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();

        }

        private void services_Load(object sender, EventArgs e)
        {
            guna2Button1.Hide();
            guna2TextBox2.Hide();
            guna2ComboBox1.Hide();
            label1.Hide();
            guna2TextBox1.Hide();
            label2.Hide();
            label3.Hide();
            guna2Panel1.Hide();
        }

        private void tailor_Click(object sender, EventArgs e)
        {
            label1.Show();
            guna2TextBox1.Show();
            label2.Show();
            label3.Show();
            guna2Button1.Show();
            guna2TextBox2.Show();
            guna2ComboBox1.Show();
            btntail = true;
            btncap = false;
            btnelec = false;
            btnplum = false;
            query = "select * from tailor";
            DataSet ds = qc.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void chef_Click(object sender, EventArgs e)
        {
            chef_gif cf = new chef_gif();
            cf.Show();
            this.Hide();
        }

        private void plumber_Click(object sender, EventArgs e)
        {
            label1.Show();
            guna2TextBox1.Show();
            guna2Button1.Show();
            guna2TextBox2.Show();
            guna2ComboBox1.Show();
            label2.Show();
            label3.Show();
            btncap = false;
            btntail = false;
            btnelec = false;
            btnplum = true;
            query = "select * from plumber";
            DataSet ds = qc.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void electrician_Click(object sender, EventArgs e)
        {
            label1.Show();
            guna2TextBox1.Show();
            guna2Button1.Show();
            guna2TextBox2.Show();
            guna2ComboBox1.Show();
            label2.Show();
            label3.Show();
            btncap = false;
            btntail = false;
            btnelec = true;
            btnplum = false;
            query = "select * from Electrician";
            DataSet ds = qc.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
       
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (btncap==true)
            {

                query = "update loginform set Bookedslot='" + guna2TextBox2.Text + "',carpenter='" + index + "'where id='" + loginForm.id + "'";
                qc.setData(query);
                string d = "";
                //bookedslot k time ko add krne k liye 
                string query3=" select * from loginform where carpenter ='"+index+"'";
                DataSet dse = qc.GetData(query3);
                int c = dse.Tables[0].Rows.Count;
                for(int i=0;i<=c-1;i++)
                {
                    string v = Convert.ToString(dse.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;

                }
                string query4 = "update carpenter set Bookedslot ='" + d + "'where id='" + index + "'";
                qc.setData(query4);
                string query1 = "select * from carpenter ";
                DataSet ds = qc.GetData(query1);
                guna2DataGridView1.DataSource = ds.Tables[0];
  
            }
            else if (btnelec == true)
            {
                query = "update loginform set Bookedslot='" + guna2TextBox2.Text + "',Electrician=' " + index + "'where id='" + loginForm.id + "'";
                qc.setData(query);
                string d = "";
                string query3 = " select * from loginform where Electrician ='" + index + "'";
                DataSet dse = qc.GetData(query3);
                int c = dse.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(dse.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;

                }
                string query8 = "update Electrician set Bookedslot='" + d + "'where id='" + index + "'";
                qc.setData(query8);
                string query1 = "select * from Electrician ";
                DataSet ds = qc.GetData(query1);
                guna2DataGridView1.DataSource = ds.Tables[0];

            }
            else if (btnplum== true)
            {
                query = "update loginform set Bookedslot='" + guna2TextBox2.Text + "',plumber=' " + index + "'where id='" + loginForm.id + "'";
                qc.setData(query);
                string d = "";
                string query3 = " select * from loginform where plumber ='" + index + "'";
                DataSet dse = qc.GetData(query3);
                int c = dse.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(dse.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;

                }
                string query7 = "update plumber set Bookedslot='" + d + "'where id='" + index + "'";
                qc.setData(query7);
                string query1 = "select * from plumber ";
                DataSet ds = qc.GetData(query1);
                guna2DataGridView1.DataSource = ds.Tables[0];

            }
            else if (btntail== true)
            {
                query = "update loginform set Bookedslot='" + guna2TextBox2.Text + "',tailor=' " + index + "'where id='" + loginForm.id + "'";
                qc.setData(query);
                string d = "";
                string query3 = " select * from loginform where tailor ='" + index + "'";
                DataSet dse = qc.GetData(query3);
                int c = dse.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(dse.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;

                }
                string query6  = "update tailor set Bookedslot='" + d + "'where id='" + index + "'";
                qc.setData(query6);
                string query1 = "select * from tailor ";
                DataSet ds = qc.GetData(query1);
                guna2DataGridView1.DataSource = ds.Tables[0];
                tailorform sf = new tailorform();
                sf.Show();
                this.Hide();

            }
        }

        private void tutor_Click(object sender, EventArgs e)
        {
            welcome_tutor wt = new welcome_tutor();
            wt.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           
        }

    

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(guna2Panel1.Visible==true)
            {
                guna2Panel1.Hide();
            }
            else
            {
                guna2Panel1.Show();
            }
            string q;
            q = "select * from loginform where id='" + loginForm.id + "'";
            DataSet ds = qc.GetData(q);
            label6.Text = ds.Tables[0].Rows[0]["username"].ToString();
            label8.Text = ds.Tables[0].Rows[0]["address"].ToString();
            label10.Text= ds.Tables[0].Rows[0]["phoneNo"].ToString();
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView2.Visible==false)
            {
                guna2DataGridView2.Visible = true;
                query = "select * from loginform where id='" + loginForm.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];

            }
            else
            {
                guna2DataGridView2.Visible = false;
            }
        }
    }
}
