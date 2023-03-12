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
    public partial class tutorform : Form
    {
        public tutorform()
        {
            InitializeComponent();
        }
        bool bodd= false;
        bool beven = false;
        bool bprime = false;
        bool bnon = false;
        bool bl = false;
        bool eva = false;
        bool vow = false;
        bool con = false;
        bool vocab = false;

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void tutorform_Load(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.Black;
            evapor_prac1.Hide();
            panel1.Hide();
            maths_practice1.Hide();
            odd_practice1.Hide();
            prime_practice1.Hide();
            living_pr1.Hide();
            non_live_pr1.Hide();
            vocabpr1.Hide();
            vowpr1.Hide();
            conpr1.Hide();


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            vowpr1.Hide();
            conpr1.Hide();
            vocabpr1.Hide();
            evapor_prac1.Hide();
            odd_practice1.Hide();
            maths_practice1.Hide();
            prime_practice1.Hide();
            living_pr1.Hide();
            non_live_pr1.Hide();
            listBox1.Items.Clear();
            panel1.Show();
            listBox1.Items.Add("EVEN NUMBERS");
            listBox1.Items.Add("ODD NUMBERS");
            listBox1.Items.Add("PRIME NUMBERS");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            vowpr1.Hide();
            conpr1.Hide();
            vocabpr1.Hide();
            evapor_prac1.Hide();
            prime_practice1.Hide();
            odd_practice1.Hide();
            maths_practice1.Hide();
            living_pr1.Hide();
            non_live_pr1.Hide();
            panel1.Show();
            listBox1.Items.Clear();
            listBox1.Items.Add("VOWELS");
            listBox1.Items.Add("CONSONANTS");
            listBox1.Items.Add("VOCABULARY");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            vowpr1.Hide();
            conpr1.Hide();
            vocabpr1.Hide();
            evapor_prac1.Hide();
            prime_practice1.Hide();
            odd_practice1.Hide();
            maths_practice1.Hide();
            living_pr1.Hide();
            non_live_pr1.Hide();
            panel1.Show();
            listBox1.Items.Clear();
            listBox1.Items.Add("LIVING THINGS");
            listBox1.Items.Add("NON LIVING THINGS");
            listBox1.Items.Add("EVAPORATION");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vowpr1.Hide();
            conpr1.Hide();
            vocabpr1.Hide();
            prime_practice1.Hide();
            odd_practice1.Hide();
            maths_practice1.Hide();
            living_pr1.Hide();
            non_live_pr1.Hide();
            evapor_prac1.Hide();
            if (listBox1.SelectedItem == "EVEN NUMBERS")
            {
                bnon = false;
                 bl = false;
                 eva = false;
                beven = true;
                bodd = false;
                bprime = false;
                vocab = false;
                vow = false;
                con = false;
                label3.Text = "EVEN NUMBERS";
                label4.Text = " DEFINITION :Any integer that can be divided exactly by 2 is an even number.";
                label5.Text = "HINT: The last digit is 0,2,4,6,8";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\even numbers.jpg";
            }

            if (listBox1.SelectedItem == "ODD NUMBERS")
            {
                 bnon = false;
                 bl = false;
                 eva = false;
                bodd = true;
                beven = false;
                bprime = false;
                vocab = false;
                vow = false;
                con = false;
                label3.Text = "ODD NUMBERS";
                label4.Text = " DEFINITION :Odd Numbers are those integers that are not divisible by 2";
                label5.Text = "HINT: The last digit is 1,3,5,7,9";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\odd numbers.jpg";
            }
            if (listBox1.SelectedItem == "PRIME NUMBERS")
            {
                 bnon = false;
                 bl = false;
                 eva = false;
                bodd = false;
                beven = false;
                bprime = true;
                vocab = false;
                vow = false;
                con = false;
                label3.Text = "PRIME NUMBERS";
                label4.Text = " DEFINITION :Prime Numbers are those numbers that are divisible by themselves and 1.";
                label5.Text = "HINT: Take a number, say, 26577.The unit digit of this number is not 0, 2, 4, 6 or 8.\nNow, take the sum of digits which will be: 2 + 6 + 5 + 7 + 7 = 27.Since 27 is divisible by 3,\n 26577 is not a prime number.";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\prime numbers.jpg";
            }
            if (listBox1.SelectedItem == "LIVING THINGS")
            {
                bnon = false;
                eva = false;

                 bl = true;
                bodd = false;
                beven = false;
                bprime = false;
                vocab = false;
                vow = false;
                con = false;
                label3.Text = "LIVING THINGS";
                label4.Text = " DEFINITION :Living things move, respond to stimuli, reproduce and grow, respire, \nand are dependent on their environment. Most living things need food, water, light,\n temperatures within defined limits, and oxygen\n";
                label5.Text = " FOR EXAMPLE :Birds, insects, animals, trees, human beings, are a few examples of \nliving things";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\LIVING THINGS.jpg";
            }
            if (listBox1.SelectedItem == "NON LIVING THINGS")
            {
                bnon = true;
                 bl = false;
                eva = false;
                bodd = false;
                beven = false;
                bprime = false;
                vocab = false;
                vow = false;
                con = false;
                label3.Text = "NON LIVING THINGS";
                label4.Text = " DEFINITION :Non-living things do not eat, grow, breathe, move and reproduce.\n They do not have senses.";
                label5.Text = " FOR EXAMPLE :Chair, book, table, rock, bag  are a few examples of \nnon living  things";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\non living things.jpg";
            }
            if (listBox1.SelectedItem == "EVAPORATION")
            {
                 bnon = false;
                 bl = false;
                 eva = true;
                bodd = false;
                beven = false;
                bprime = false;
                vocab = false;
                vow = false;
                con = false;
                label3.Text = "EVAPORATION";
                label4.Text = " DEFINITION :Evaporation is defined as the process of a liquid changing into a gas.";
                label5.Text = " FOR EXAMPLE :An example of evaporation is water turning into steam.";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\evaporation.jpg";
            }
            if (listBox1.SelectedItem == "VOWELS")
            {
                bnon = false;
                bl = false;
                eva = false;
                bodd = false;
                beven = false;
                bprime = false;
                vow = true;
                vocab = false;
                con = false;
                label3.Text = "VOWELS";
                label4.Text = " DEFINITION :Alphabets link 'a','e','i','o'and 'u' are known as vowels";
                label5.Text = " HINT: A vowel is a letter that represents an open sound.";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\vowelimg.jpg";
            }
            if (listBox1.SelectedItem == "CONSONANTS")
            {
                bnon = false;
                bl = false;
                eva = false;
                bodd = false;
                beven = false;
                bprime = false;
                con = true;
                vow = false;
                vocab = false;
                label3.Text = "CONSONANTS";
                label4.Text = " DEFINITION :A consonat is a speech sound that is not a vowel(A,E,I,O,U)consonant\n are all the non-vowel sounds , or their corresponding letters :A,E,I,O,U and sometimes \nY are not consonants   ";
                label5.Text = " HINT: It also refers to letters of the alphabet that represent those sounds :Z,B,T,G \nand H are all consonants";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\conimg.jpg";
            }
            if (listBox1.SelectedItem == "VOCABULARY")
            {
                bnon = false;
                bl = false;
                eva = false;
                bodd = false;
                beven = false;
                bprime = false;
                vocab = true;
                vow = false;
                con = false;
                label3.Text = "VOCABULARY";
                label4.Text = " DEFINITION :A list or collection of words or of words and phrases usually \nalphabetically arranged and explained or defined";
                label5.Text = " IN SIMPLE WORDS:A vocabulary is a set of familiar words within a person's language.";
                guna2PictureBox1.ImageLocation = @"C:\Users\HP-650\OneDrive\Desktop\dresses designs\vocabimg.jpg";
            }


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            if (beven == true)
            {
                maths_practice1.Show();
            }
            if (bodd == true)
            {
                odd_practice1.Show();
            }
            if (bprime == true)
            {
                prime_practice1.Show();
            }
            if(bl == true)
            {
                living_pr1.Show();
            }
            if(bnon==true)
            {
                non_live_pr1.Show();
            }
            if (eva == true)
            {
                evapor_prac1.Show();
            }
            if(vocab==true)
            {
                vocabpr1.Show();
            }
            if(vow==true)
            {
                vowpr1.Show();

            }
            if(con==true)
            {
                conpr1.Show();
            }

        }

        private void prime_practice1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            services ss = new services();
            ss.Show();
            this.Hide();
        }

        private void living_pr1_Load(object sender, EventArgs e)
        {

        }
    }
}
