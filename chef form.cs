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
    public partial class chef_form : Form
    {
        public chef_form()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel3.Show();
            listBox1.Items.Clear();
            listBox1.Items.Add("Chinese Rice");
            listBox1.Items.Add("Chowmein" );

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel3.Show();
            listBox1.Items.Clear();
            listBox1.Items.Add("Seekh Kabab");
            listBox1.Items.Add("Karahi");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel3.Show();
            listBox1.Items.Clear();
            listBox1.Items.Add("Burger");
            listBox1.Items.Add("Club sandwitch");
        }

        private void chef_form_Load(object sender, EventArgs e)
        {
            guna2Panel3.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(listBox1.SelectedItem=="Chinese Rice")
            {
                label3.Text = "Chinese Rice";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\chinese rice.jpg";
                guna2PictureBox2.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\4.png";
                guna2PictureBox3.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\6.png";

                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\chinese rice.jpg";
            }
            if (listBox1.SelectedItem == "Chowmein")
            {
                label3.Text = "Chowmein";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\chowmein.jpg";
                guna2PictureBox2.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\10.png";
                guna2PictureBox3.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\9.png";
               
            }
            if (listBox1.SelectedItem == "Karahi")
            {
                label3.Text = "Karahi";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\karahi1.jpg";
                guna2PictureBox2.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\2.png";
                guna2PictureBox3.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\3.png";
            }
            if (listBox1.SelectedItem == "Seekh Kabab")
            {
                label3.Text = "Seekh Kabab";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\seekhimg.jpg";
                guna2PictureBox2.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\24.png";
                guna2PictureBox3.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\23.png";
               
            }
            if (listBox1.SelectedItem == "Burger")
            {
                label3.Text = "Burger";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\burgpic.jpg";
                guna2PictureBox2.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\13.png";
                guna2PictureBox3.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\14.png";


            }
            if (listBox1.SelectedItem == "Club sandwitch")
            {
                label3.Text = "Club sandwitch";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\clubimg.jpg";
                guna2PictureBox2.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\20.png";
                guna2PictureBox3.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\19.png";

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            services ss = new services();
            ss.Show();
            this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
