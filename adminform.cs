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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }
        queryconnection qc = new queryconnection();
        string query;
        public static string category = "";
        public static string id;
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            category = txtcategory.Text;
            id = txtid.Text;
            query = " select * from " +txtcategory.Text+ " where id='" +txtid.Text+ "'And name ='"+txtname.Text+"'";
            DataSet ds = qc.GetData(query);
            if(ds.Tables[0].Rows.Count!=0)
            {
                admintime s = new admintime();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
        }
    }
}
