namespace App_ASM2
{
    partial class Uc_Book
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
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.groupBoxId = new System.Windows.Forms.GroupBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.bookDataView = new System.Windows.Forms.DataGridView();
            this.searchgrbox = new System.Windows.Forms.GroupBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.importbtn = new System.Windows.Forms.Button();
            this.dategrbox = new System.Windows.Forms.GroupBox();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.exportbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.groupBoxId.SuspendLayout();
            this.groupBoxTitle.SuspendLayout();
            this.groupBoxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataView)).BeginInit();
            this.searchgrbox.SuspendLayout();
            this.dategrbox.SuspendLayout();
            this.SuspendLayout();
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
            // groupBoxId
            // 
            this.groupBoxId.Controls.Add(this.Idtxt);
            this.groupBoxId.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxId.Location = new System.Drawing.Point(130, 7);
            this.groupBoxId.Name = "groupBoxId";
            this.groupBoxId.Size = new System.Drawing.Size(234, 73);
            this.groupBoxId.TabIndex = 4;
            this.groupBoxId.TabStop = false;
            this.groupBoxId.Text = "ID";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(8, 27);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(214, 29);
            this.Idtxt.TabIndex = 6;
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Controls.Add(this.titletxt);
            this.groupBoxTitle.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitle.Location = new System.Drawing.Point(458, 7);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(292, 73);
            this.groupBoxTitle.TabIndex = 7;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Name";
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(10, 29);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(269, 29);
            this.titletxt.TabIndex = 7;
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.authortxt);
            this.groupBoxAuthor.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuthor.Location = new System.Drawing.Point(130, 86);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(234, 73);
            this.groupBoxAuthor.TabIndex = 8;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Author";
            // 
            // authortxt
            // 
            this.authortxt.Location = new System.Drawing.Point(10, 29);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(212, 29);
            this.authortxt.TabIndex = 0;
            // 
            // bookDataView
            // 
            this.bookDataView.AllowUserToAddRows = false;
            this.bookDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataView.Location = new System.Drawing.Point(130, 176);
            this.bookDataView.Name = "bookDataView";
            this.bookDataView.RowHeadersWidth = 62;
            this.bookDataView.RowTemplate.Height = 28;
            this.bookDataView.Size = new System.Drawing.Size(843, 252);
            this.bookDataView.TabIndex = 10;
            this.bookDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataView_CellClick);
            // 
            // searchgrbox
            // 
            this.searchgrbox.Controls.Add(this.searchtxt);
            this.searchgrbox.Controls.Add(this.Refreshbtn);
            this.searchgrbox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgrbox.Location = new System.Drawing.Point(140, 434);
            this.searchgrbox.Name = "searchgrbox";
            this.searchgrbox.Size = new System.Drawing.Size(404, 56);
            this.searchgrbox.TabIndex = 11;
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
            // importbtn
            // 
            this.importbtn.Location = new System.Drawing.Point(744, 514);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(226, 41);
            this.importbtn.TabIndex = 13;
            this.importbtn.Text = "Book in Library";
            this.importbtn.UseVisualStyleBackColor = true;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // dategrbox
            // 
            this.dategrbox.Controls.Add(this.datepick);
            this.dategrbox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dategrbox.Location = new System.Drawing.Point(458, 86);
            this.dategrbox.Name = "dategrbox";
            this.dategrbox.Size = new System.Drawing.Size(292, 73);
            this.dategrbox.TabIndex = 9;
            this.dategrbox.TabStop = false;
            this.dategrbox.Text = "Publish Date";
            // 
            // datepick
            // 
            this.datepick.Location = new System.Drawing.Point(10, 27);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(269, 29);
            this.datepick.TabIndex = 0;
            // 
            // exportbtn
            // 
            this.exportbtn.Location = new System.Drawing.Point(546, 514);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(148, 41);
            this.exportbtn.TabIndex = 19;
            this.exportbtn.Text = "Save";
            this.exportbtn.UseVisualStyleBackColor = true;
            this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(346, 514);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(148, 41);
            this.updatebtn.TabIndex = 18;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(143, 514);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(148, 41);
            this.addbtn.TabIndex = 17;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Uc_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.exportbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.dategrbox);
            this.Controls.Add(this.importbtn);
            this.Controls.Add(this.searchgrbox);
            this.Controls.Add(this.bookDataView);
            this.Controls.Add(this.groupBoxAuthor);
            this.Controls.Add(this.groupBoxTitle);
            this.Controls.Add(this.groupBoxId);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Uc_Book";
            this.Size = new System.Drawing.Size(1500, 891);
            this.Load += new System.EventHandler(this.Book_Load);
            this.groupBoxId.ResumeLayout(false);
            this.groupBoxId.PerformLayout();
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            this.groupBoxAuthor.ResumeLayout(false);
            this.groupBoxAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataView)).EndInit();
            this.searchgrbox.ResumeLayout(false);
            this.searchgrbox.PerformLayout();
            this.dategrbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.GroupBox groupBoxId;
        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxAuthor;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.DataGridView bookDataView;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.GroupBox searchgrbox;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button importbtn;
        private System.Windows.Forms.GroupBox dategrbox;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.Button exportbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
    }
}
