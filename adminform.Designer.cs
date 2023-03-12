
namespace OOP_PROJECT
{
    partial class adminform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtcategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labpass = new System.Windows.Forms.Label();
            this.labuser = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::OOP_PROJECT.Properties.Resources.check_image;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(143, -3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(202, 222);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtcategory
            // 
            this.txtcategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcategory.DefaultText = "";
            this.txtcategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcategory.DisabledState.Parent = this.txtcategory;
            this.txtcategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategory.FocusedState.Parent = this.txtcategory;
            this.txtcategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcategory.ForeColor = System.Drawing.Color.Black;
            this.txtcategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategory.HoverState.Parent = this.txtcategory;
            this.txtcategory.Location = new System.Drawing.Point(184, 329);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.PasswordChar = '\0';
            this.txtcategory.PlaceholderText = "Enter category";
            this.txtcategory.SelectedText = "";
            this.txtcategory.ShadowDecoration.Parent = this.txtcategory;
            this.txtcategory.Size = new System.Drawing.Size(191, 36);
            this.txtcategory.TabIndex = 12;
            this.txtcategory.TextChanged += new System.EventHandler(this.txtcategory_TextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(184, 279);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Enter username";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(191, 36);
            this.txtname.TabIndex = 11;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(143, 458);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "LOGIN";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpass.Location = new System.Drawing.Point(79, 329);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(99, 18);
            this.labpass.TabIndex = 9;
            this.labpass.Text = "CATEGORY";
            // 
            // labuser
            // 
            this.labuser.AutoSize = true;
            this.labuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labuser.Location = new System.Drawing.Point(77, 288);
            this.labuser.Name = "labuser";
            this.labuser.Size = new System.Drawing.Size(101, 18);
            this.labuser.TabIndex = 8;
            this.labuser.Text = "USERNAME";
            // 
            // txtid
            // 
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.Parent = this.txtid;
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.FocusedState.Parent = this.txtid;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.HoverState.Parent = this.txtid;
            this.txtid.Location = new System.Drawing.Point(184, 379);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "Enter ID";
            this.txtid.SelectedText = "";
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(191, 36);
            this.txtid.TabIndex = 17;
            this.txtid.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 26;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(433, -3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(52, 54);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 582);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtcategory;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.Label labuser;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}