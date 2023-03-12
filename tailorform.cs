using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;
using Microsoft.Win32;


namespace OOP_PROJECT
{
    public partial class tailorform : Form
    {
        public tailorform()
        {
            InitializeComponent();
        }
        queryconnection qc = new queryconnection();
        string query;
        int id;
        private void tailorform_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the id of tailor"));
            query = "select name from tailor where id='" + id + "'";
            DataSet ds = qc.GetData(query);
            label32.Text = ds.Tables[0].Rows[0]["name"].ToString();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Show();

        }
        Bitmap memoryimages;
        private void capturescreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryimages = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memorygraphics = Graphics.FromImage(memoryimages);
            memorygraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            capturescreen();
            printDocument1.Print();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            services ss = new services();
            ss.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryimages, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
