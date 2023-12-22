namespace App_ASM2
{
    partial class Uc_Issuebook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stdIDlb = new System.Windows.Forms.Label();
            this.booklb = new System.Windows.Forms.Label();
            this.issueDatelb = new System.Windows.Forms.Label();
            this.stdIDtxt = new System.Windows.Forms.TextBox();
            this.bookcbb = new System.Windows.Forms.ComboBox();
            this.returnDatepick = new System.Windows.Forms.DateTimePicker();
            this.issueDatepick = new System.Windows.Forms.DateTimePicker();
            this.IssueBookdataView = new System.Windows.Forms.DataGridView();
            this.returnDatelb = new System.Windows.Forms.Label();
            this.issueBookbtn = new System.Windows.Forms.Button();
            this.stdNamelb = new System.Windows.Forms.Label();
            this.stdNametxt = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.exportbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.searchgrbox = new System.Windows.Forms.GroupBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.importbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookdataView)).BeginInit();
            this.searchgrbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stdIDlb
            // 
            this.stdIDlb.AutoSize = true;
            this.stdIDlb.Location = new System.Drawing.Point(17, 21);
            this.stdIDlb.Name = "stdIDlb";
            this.stdIDlb.Size = new System.Drawing.Size(127, 25);
            this.stdIDlb.TabIndex = 0;
            this.stdIDlb.Text = "Student ID";
            // 
            // booklb
            // 
            this.booklb.AutoSize = true;
            this.booklb.Location = new System.Drawing.Point(17, 128);
            this.booklb.Name = "booklb";
            this.booklb.Size = new System.Drawing.Size(65, 25);
            this.booklb.TabIndex = 2;
            this.booklb.Text = "Book";
            // 
            // issueDatelb
            // 
            this.issueDatelb.AutoSize = true;
            this.issueDatelb.Location = new System.Drawing.Point(434, 20);
            this.issueDatelb.Name = "issueDatelb";
            this.issueDatelb.Size = new System.Drawing.Size(121, 25);
            this.issueDatelb.TabIndex = 3;
            this.issueDatelb.Text = "Issue Date";
            // 
            // stdIDtxt
            // 
            this.stdIDtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stdIDtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stdIDtxt.Location = new System.Drawing.Point(175, 21);
            this.stdIDtxt.Name = "stdIDtxt";
            this.stdIDtxt.Size = new System.Drawing.Size(202, 32);
            this.stdIDtxt.TabIndex = 5;
            // 
            // bookcbb
            // 
            this.bookcbb.FormattingEnabled = true;
            this.bookcbb.Location = new System.Drawing.Point(175, 128);
            this.bookcbb.Name = "bookcbb";
            this.bookcbb.Size = new System.Drawing.Size(202, 33);
            this.bookcbb.TabIndex = 7;
            // 
            // returnDatepick
            // 
            this.returnDatepick.Location = new System.Drawing.Point(609, 72);
            this.returnDatepick.Name = "returnDatepick";
            this.returnDatepick.Size = new System.Drawing.Size(296, 32);
            this.returnDatepick.TabIndex = 8;
            // 
            // issueDatepick
            // 
            this.issueDatepick.Location = new System.Drawing.Point(609, 17);
            this.issueDatepick.Name = "issueDatepick";
            this.issueDatepick.Size = new System.Drawing.Size(296, 32);
            this.issueDatepick.TabIndex = 9;
            // 
            // IssueBookdataView
            // 
            this.IssueBookdataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssueBookdataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueBookdataView.Location = new System.Drawing.Point(22, 215);
            this.IssueBookdataView.Name = "IssueBookdataView";
            this.IssueBookdataView.RowHeadersWidth = 62;
            this.IssueBookdataView.RowTemplate.Height = 28;
            this.IssueBookdataView.Size = new System.Drawing.Size(948, 266);
            this.IssueBookdataView.TabIndex = 10;
            this.IssueBookdataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssueBookdataView_CellClick);
            // 
            // returnDatelb
            // 
            this.returnDatelb.AutoSize = true;
            this.returnDatelb.Location = new System.Drawing.Point(434, 78);
            this.returnDatelb.Name = "returnDatelb";
            this.returnDatelb.Size = new System.Drawing.Size(141, 25);
            this.returnDatelb.TabIndex = 4;
            this.returnDatelb.Text = "Return Date";
            // 
            // issueBookbtn
            // 
            this.issueBookbtn.Location = new System.Drawing.Point(26, 490);
            this.issueBookbtn.Name = "issueBookbtn";
            this.issueBookbtn.Size = new System.Drawing.Size(148, 41);
            this.issueBookbtn.TabIndex = 11;
            this.issueBookbtn.Text = "Issue Book";
            this.issueBookbtn.UseVisualStyleBackColor = true;
            this.issueBookbtn.Click += new System.EventHandler(this.issueBookbtn_Click);
            // 
            // stdNamelb
            // 
            this.stdNamelb.AutoSize = true;
            this.stdNamelb.Location = new System.Drawing.Point(17, 71);
            this.stdNamelb.Name = "stdNamelb";
            this.stdNamelb.Size = new System.Drawing.Size(160, 25);
            this.stdNamelb.TabIndex = 12;
            this.stdNamelb.Text = "Student Name";
            // 
            // stdNametxt
            // 
            this.stdNametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stdNametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stdNametxt.Location = new System.Drawing.Point(175, 71);
            this.stdNametxt.Name = "stdNametxt";
            this.stdNametxt.Size = new System.Drawing.Size(202, 32);
            this.stdNametxt.TabIndex = 13;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(203, 490);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(148, 41);
            this.updatebtn.TabIndex = 14;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // exportbtn
            // 
            this.exportbtn.Location = new System.Drawing.Point(563, 490);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(148, 41);
            this.exportbtn.TabIndex = 15;
            this.exportbtn.Text = "Save";
            this.exportbtn.UseVisualStyleBackColor = true;
            this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(379, 490);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(148, 41);
            this.deletebtn.TabIndex = 16;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // searchgrbox
            // 
            this.searchgrbox.Controls.Add(this.searchtxt);
            this.searchgrbox.Controls.Add(this.Refreshbtn);
            this.searchgrbox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgrbox.Location = new System.Drawing.Point(483, 153);
            this.searchgrbox.Name = "searchgrbox";
            this.searchgrbox.Size = new System.Drawing.Size(404, 56);
            this.searchgrbox.TabIndex = 17;
            this.searchgrbox.TabStop = false;
            this.searchgrbox.Text = "Search";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(6, 20);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(267, 29);
            this.searchtxt.TabIndex = 0;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbtn.Location = new System.Drawing.Point(279, 16);
            this.Refreshbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(123, 35);
            this.Refreshbtn.TabIndex = 3;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // importbtn
            // 
            this.importbtn.Location = new System.Drawing.Point(744, 490);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(226, 41);
            this.importbtn.TabIndex = 18;
            this.importbtn.Text = "History issue book ";
            this.importbtn.UseVisualStyleBackColor = true;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // Uc_Issuebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.importbtn);
            this.Controls.Add(this.searchgrbox);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.exportbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.stdNametxt);
            this.Controls.Add(this.stdNamelb);
            this.Controls.Add(this.issueBookbtn);
            this.Controls.Add(this.IssueBookdataView);
            this.Controls.Add(this.issueDatepick);
            this.Controls.Add(this.returnDatepick);
            this.Controls.Add(this.bookcbb);
            this.Controls.Add(this.stdIDtxt);
            this.Controls.Add(this.returnDatelb);
            this.Controls.Add(this.issueDatelb);
            this.Controls.Add(this.booklb);
            this.Controls.Add(this.stdIDlb);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Uc_Issuebook";
            this.Size = new System.Drawing.Size(1500, 891);
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookdataView)).EndInit();
            this.searchgrbox.ResumeLayout(false);
            this.searchgrbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stdIDlb;
        private System.Windows.Forms.Label booklb;
        private System.Windows.Forms.Label issueDatelb;
        private System.Windows.Forms.TextBox stdIDtxt;
        private System.Windows.Forms.ComboBox bookcbb;
        private System.Windows.Forms.DateTimePicker returnDatepick;
        private System.Windows.Forms.DateTimePicker issueDatepick;
        private System.Windows.Forms.DataGridView IssueBookdataView;
        private System.Windows.Forms.Label returnDatelb;
        private System.Windows.Forms.Button issueBookbtn;
        private System.Windows.Forms.Label stdNamelb;
        private System.Windows.Forms.TextBox stdNametxt;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button exportbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.GroupBox searchgrbox;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button importbtn;
    }
}
