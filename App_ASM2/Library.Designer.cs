namespace App_ASM2
{
    partial class Library
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uc_Book1 = new App_ASM2.Uc_Book();
            this.uc_Issuebook1 = new App_ASM2.Uc_Issuebook();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookStripMenu,
            this.issueBookStripMenu,
            this.logOutStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookStripMenu
            // 
            this.bookStripMenu.Image = global::App_ASM2.Properties.Resources.book_icon;
            this.bookStripMenu.Name = "bookStripMenu";
            this.bookStripMenu.Size = new System.Drawing.Size(125, 34);
            this.bookStripMenu.Text = "Book ";
            this.bookStripMenu.Click += new System.EventHandler(this.bookStripMenu_Click);
            // 
            // issueBookStripMenu
            // 
            this.issueBookStripMenu.Image = global::App_ASM2.Properties.Resources.borrow_book_icon;
            this.issueBookStripMenu.Name = "issueBookStripMenu";
            this.issueBookStripMenu.Size = new System.Drawing.Size(190, 34);
            this.issueBookStripMenu.Text = "Issue Book";
            this.issueBookStripMenu.Click += new System.EventHandler(this.issueBookStripMenu_Click);
            // 
            // logOutStripMenu
            // 
            this.logOutStripMenu.Image = global::App_ASM2.Properties.Resources.icon_logout;
            this.logOutStripMenu.Name = "logOutStripMenu";
            this.logOutStripMenu.Size = new System.Drawing.Size(148, 34);
            this.logOutStripMenu.Text = "Log out";
            this.logOutStripMenu.Click += new System.EventHandler(this.logOutStripMenu_Click);
            // 
            // uc_Book1
            // 
            this.uc_Book1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uc_Book1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Book1.Location = new System.Drawing.Point(0, 38);
            this.uc_Book1.Margin = new System.Windows.Forms.Padding(5);
            this.uc_Book1.Name = "uc_Book1";
            this.uc_Book1.Size = new System.Drawing.Size(1500, 891);
            this.uc_Book1.TabIndex = 2;
            // 
            // uc_Issuebook1
            // 
            this.uc_Issuebook1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uc_Issuebook1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Issuebook1.Location = new System.Drawing.Point(0, 38);
            this.uc_Issuebook1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uc_Issuebook1.Name = "uc_Issuebook1";
            this.uc_Issuebook1.Size = new System.Drawing.Size(1500, 891);
            this.uc_Issuebook1.TabIndex = 1;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1578, 1050);
            this.Controls.Add(this.uc_Book1);
            this.Controls.Add(this.uc_Issuebook1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Library";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookStripMenu;
        private System.Windows.Forms.ToolStripMenuItem issueBookStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutStripMenu;
        private Uc_Issuebook uc_Issuebook1;
        private Uc_Book uc_Book1;
    }
}