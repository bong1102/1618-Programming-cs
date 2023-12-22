using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace App_ASM2
{
    public partial class Uc_Book : UserControl
    {
        public Uc_Book()
        {
            InitializeComponent();
        }

        // khai báo table
        DataTable dt = new DataTable();
        int selectRow;
        private void Book_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));  
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("Publish Date", typeof(DateTime));
            bookDataView.DataSource = dt;
        }

        

        private void bookDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            DataGridViewRow selectedRow = bookDataView.Rows[selectRow];
            Idtxt.Text = selectedRow.Cells[0].Value.ToString();
            titletxt.Text = selectedRow.Cells[1].Value.ToString();
            authortxt.Text = selectedRow.Cells[2].Value.ToString();
            datepick.Text = selectedRow.Cells[3].Value.ToString();

        }

        private void importbtn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\PC\source\repos\bong1102\1618-Programming-cs\App_ASM2\book.txt");
            string[] data;

            for (int i = 0; i < lines.Length; i++)
            {
                data = lines[i].ToString().Split(',');
                string[] row = new string[data.Length];

                for (int j = 0; j < data.Length; j++)
                {
                    row[j] = data[j].Trim();
                }
                dt.Rows.Add(row);
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            searchtxt.Clear();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            (bookDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Title like '%{0}%' OR Author like '%{0}%' ", searchtxt.Text);
        }

        private bool IsBookExists(string title, string id)
        {
            DataRow[] foundRows = dt.Select($"Title = '{title}' OR ID = '{id}'");
            return foundRows.Length > 0;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            string newId = Idtxt.Text;
            string newTitle = titletxt.Text;
            string newAuthor = authortxt.Text;
            string newDate = datepick.Text.ToString();

            if (!IsBookExists(newTitle, newId))
            {
                dt.Rows.Add(newId, newTitle, newAuthor, newDate);
                bookDataView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Book with the same title or ID already exists! Please use a different title or ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = bookDataView.Rows[selectRow];
            newData.Cells[0].Value = Idtxt.Text;
            newData.Cells[1].Value = titletxt.Text;
            newData.Cells[2].Value = authortxt.Text;
            newData.Cells[3].Value = datepick.Text;
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\PC\source\repos\bong1102\1618-Programming-cs\App_ASM2\book.txt");

            for (int i = 0; i < bookDataView.Rows.Count - 1; i++)//row
            {
                for (int j = 0; j < bookDataView.Columns.Count; j++)//column
                {
                    if (j == bookDataView.Columns.Count - 1)// if the last line
                    {
                        writer.Write("\t" + bookDataView.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        writer.Write("\t" + bookDataView.Rows[i].Cells[j].Value.ToString() + "\t" + ",");
                    }
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Save to library successfull!!");
        }
    }
        
}
