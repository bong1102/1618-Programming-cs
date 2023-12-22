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

namespace App_ASM2
{
    public partial class Uc_Issuebook : UserControl
    {

        public Uc_Issuebook()
        {
            InitializeComponent();
            Uc_Issuebook_Load();
            
        }
        DataTable issuedata = new DataTable();
        int selectRow;
        private void Uc_Issuebook_Load()
        {
            // read book.txt
            List<string> bookfile = ReadTextFile(@"C:\Users\PC\source\repos\bong1102\1618-Programming-cs\App_ASM2\book1.txt");
             bookcbb.Items.Clear();
             bookcbb.Items.AddRange(bookfile.ToArray());
            
            //add column to issueBookdata
            issuedata.Columns.Add("ID Student", typeof (string));
            issuedata.Columns.Add("Name's Student", typeof(string));
            issuedata.Columns.Add("Title", typeof(string));
            issuedata.Columns.Add("Issue Date", typeof(DateTime));
            issuedata.Columns.Add("Return Date", typeof(DateTime));
            IssueBookdataView.DataSource = issuedata;
        }

        private List<string> ReadTextFile(string filePath)
        {
            List<string> linesList = new List<string>();
            try
            {
                linesList = File.ReadAllLines(filePath).ToList();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error while reading file: " + ex.Message);
            }
            return linesList;
        }
        private void issueBookbtn_Click(object sender, EventArgs e)
        {
            // get book from book combobox
            string selectedBook = bookcbb.SelectedItem?.ToString();
            if(selectedBook != null)
            {
                if (isBookBorrowed(selectedBook))
                {
                    MessageBox.Show($"The book '{selectedBook}' is already borrowed and not returned yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);                }
                else 
                {
                    issuedata.Rows.Add(stdIDtxt.Text, stdNametxt.Text, bookcbb.SelectedItem.ToString(), issueDatepick.Text.ToString(), returnDatepick.Text.ToString());
                    IssueBookdataView.DataSource = issuedata;
                }
            }
            
                         
        }
        private bool isBookBorrowed(string Title)
        {
            foreach(DataGridViewRow row in IssueBookdataView.Rows)
            {
                if (row.Cells["Title"].Value != null && row.Cells["Return Date"].Value != null)
                {
                    string title = row.Cells["Title"].Value.ToString();
                    DateTime returnDate;
                    if (title.Equals(Title) && DateTime.TryParse(row.Cells["Return Date"].Value.ToString(),out returnDate))
                    {
                        //check the book is borrowed or not
                        if ( returnDate >= DateTime.Now.Date)
                        {
                            //book had borrowed
                            return true;    
                        }
                    }
                }
            }
            return false;   
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = IssueBookdataView.Rows[selectRow];
            newData.Cells[0].Value = stdIDtxt.Text;
            newData.Cells[1].Value = stdNametxt.Text;
            newData.Cells[2].Value = bookcbb.SelectedItem.ToString();
            newData.Cells[3].Value = issueDatepick.Text;
            newData.Cells[4].Value = returnDatepick.Text;

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            selectRow = IssueBookdataView.CurrentCell.RowIndex;
            IssueBookdataView.Rows.RemoveAt(selectRow);
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\PC\source\repos\bong1102\1618-Programming-cs\App_ASM2\issuebook.txt");

            for (int i = 0; i < IssueBookdataView.Rows.Count - 1; i++)//row
            {
                for (int j = 0; j < IssueBookdataView.Columns.Count; j++)//column
                {
                    if (j == IssueBookdataView.Columns.Count - 1)// if the last line
                    {
                        writer.Write("\t" + IssueBookdataView.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        writer.Write("\t" + IssueBookdataView.Rows[i].Cells[j].Value.ToString() + "\t" + ",");
                    }
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Save to history issue book successfull!!");
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            (IssueBookdataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Title like '%{0}%' OR [Name's Student] like '%{0}%' OR [ID Student] like '%{0}%' ", searchtxt.Text);
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            searchtxt.Clear();
        }

        private void IssueBookdataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            DataGridViewRow rowcelected = IssueBookdataView.Rows[selectRow];
            stdIDtxt.Text = rowcelected.Cells[0].Value.ToString();
            stdNametxt.Text = rowcelected.Cells[1].Value.ToString();
            bookcbb.Text = rowcelected.Cells[2].Value.ToString();
            issueDatepick.Text = rowcelected.Cells[3].Value.ToString();
            returnDatepick.Text = rowcelected.Cells[4].Value.ToString();

        }

        private void importbtn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\PC\source\repos\bong1102\1618-Programming-cs\App_ASM2\issuebook.txt");
            string[] data;

            for (int i = 0; i < lines.Length; i++)
            {
                data = lines[i].ToString().Split(',');
                string[] row = new string[data.Length];

                for (int j = 0; j < data.Length; j++)
                {
                    row[j] = data[j].Trim();
                }
                issuedata.Rows.Add(row);
            }
        }
    }
}
