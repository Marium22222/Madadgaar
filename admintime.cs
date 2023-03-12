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
    public partial class admintime : Form
    {
        public admintime()
        {
            InitializeComponent();
        }
        queryconnection qc = new queryconnection();
        string query;

        private void admintime_Load(object sender, EventArgs e)
        {
            guna2Panel1.Hide();
           
         if(adminform.category=="carpenter")
            {
                query = "select * from loginform where carpenter=' " + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (adminform.category == "plumber")
            {
                query = "select * from loginform where plumber=' " + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (adminform.category == "tailor")
            {
                query = "select * from loginform where tailor=' " + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (adminform.category == "Electrician")
            {
                query = "select * from loginform where Electrician=' " + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }
        int index;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2Panel1.Show();
            index = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (adminform.category == "carpenter")
            {
                query = "update loginform set Bookedslot='" + guna2TextBox1.Text + "' where id='" + index + "'";
                qc.setData(query);
                query = " select * from loginform where carpenter='" + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                string d = "";
                int c = ds.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(ds.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;
                }
                string query4 = "update carpenter set Bookedslot='" + d + "' where id='" + adminform.id + "'";
                qc.setData(query4);
            }
            if (adminform.category == "plumber")
            {
                query = "update loginform set Bookedslot='" + guna2TextBox1.Text + "' where id='" + index + "'";
                qc.setData(query);
                query = " select * from loginform where plumber='" + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                string d = "";
                int c = ds.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(ds.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;
                }
                string query4 = "update plumber set Bookedslot='" + d + "' where id='" + adminform.id + "'";
                qc.setData(query4);
            }
            if (adminform.category == "Electrician")
            {
                query = "update loginform set Bookedslot='" + guna2TextBox1.Text + "' where id='" + index + "'";
                qc.setData(query);
                query = " select * from loginform where Electrician='" + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                string d = "";
                int c = ds.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(ds.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;
                }
                string query4 = "update Electrician set Bookedslot='" + d + "' where id='" + adminform.id + "'";
                qc.setData(query4);
            }
            if (adminform.category == "tailor")
            {
                query = "update loginform set Bookedslot='" + guna2TextBox1.Text + "' where id='" + index + "'";
                qc.setData(query);
                query = " select * from loginform where tailor='" + adminform.id + "'";
                DataSet ds = qc.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                string d = "";
                int c = ds.Tables[0].Rows.Count;
                for (int i = 0; i <= c - 1; i++)
                {
                    string v = Convert.ToString(ds.Tables[0].Rows[i]["Bookedslot"]);
                    d = d + "," + v;
                }
                string query4 = "update tailor set Bookedslot='" + d + "' where id='" + adminform.id + "'";
                qc.setData(query4);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
        }
    }
}
