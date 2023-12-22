namespace App_ASM2
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_pic = new System.Windows.Forms.PictureBox();
            this.pw_pic = new System.Windows.Forms.PictureBox();
            this.Github_pic = new System.Windows.Forms.PictureBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.pwtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pw_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(84, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(190, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "System ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(151, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(151, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 1);
            this.panel2.TabIndex = 3;
            // 
            // user_pic
            // 
            this.user_pic.BackColor = System.Drawing.Color.Transparent;
            this.user_pic.Image = global::App_ASM2.Properties.Resources.user_icon;
            this.user_pic.Location = new System.Drawing.Point(95, 236);
            this.user_pic.Name = "user_pic";
            this.user_pic.Size = new System.Drawing.Size(50, 50);
            this.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pic.TabIndex = 4;
            this.user_pic.TabStop = false;
            // 
            // pw_pic
            // 
            this.pw_pic.BackColor = System.Drawing.Color.Transparent;
            this.pw_pic.Image = global::App_ASM2.Properties.Resources.pw_icon;
            this.pw_pic.Location = new System.Drawing.Point(95, 335);
            this.pw_pic.Name = "pw_pic";
            this.pw_pic.Size = new System.Drawing.Size(50, 50);
            this.pw_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pw_pic.TabIndex = 5;
            this.pw_pic.TabStop = false;
            // 
            // Github_pic
            // 
            this.Github_pic.BackColor = System.Drawing.Color.Transparent;
            this.Github_pic.Image = global::App_ASM2.Properties.Resources.github_icon;
            this.Github_pic.Location = new System.Drawing.Point(236, 486);
            this.Github_pic.Name = "Github_pic";
            this.Github_pic.Size = new System.Drawing.Size(80, 80);
            this.Github_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Github_pic.TabIndex = 6;
            this.Github_pic.TabStop = false;
            this.Github_pic.Click += new System.EventHandler(this.Github_pic_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(223, 404);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(105, 50);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(155, 251);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(280, 29);
            this.usertxt.TabIndex = 8;
            this.usertxt.Text = "User Name";
            this.usertxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usertxt_MouseClick);
            // 
            // pwtxt
            // 
            this.pwtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.pwtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwtxt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwtxt.Location = new System.Drawing.Point(155, 350);
            this.pwtxt.Name = "pwtxt";
            this.pwtxt.Size = new System.Drawing.Size(285, 29);
            this.pwtxt.TabIndex = 9;
            this.pwtxt.Text = "Password";
            this.pwtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pwtxt_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(401, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Created by";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(481, 666);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bong";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_ASM2.Properties.Resources.backgr;
            this.ClientSize = new System.Drawing.Size(543, 719);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Github_pic);
            this.Controls.Add(this.pw_pic);
            this.Controls.Add(this.user_pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pw_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox user_pic;
        private System.Windows.Forms.PictureBox pw_pic;
        private System.Windows.Forms.PictureBox Github_pic;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox pwtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}