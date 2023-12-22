using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ASM2
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void issueBookStripMenu_Click(object sender, EventArgs e)
        {
            uc_Book1.Hide();
            uc_Issuebook1.Show();
            uc_Issuebook1.BringToFront();
        }

        private void bookStripMenu_Click(object sender, EventArgs e)
        {
            uc_Issuebook1.Hide();
            uc_Book1.Show();
            uc_Book1.BringToFront();
        }

        private void logOutStripMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
