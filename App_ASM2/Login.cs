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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void usertxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (usertxt.Text == "User Name")
            {
                usertxt.Clear();
            }
        }

        private void pwtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (pwtxt.Text == "Password")
            {
                pwtxt.Clear();
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "hoa" && pwtxt.Text == "123")
            {
                Library f = new Library();
                this.Hide();
                f.Show();
            }
            else if (usertxt.Text != "hoa" || pwtxt.Text != "123")
            {
                MessageBox.Show("Invalid User or Password!! \n Please enter correct User and password!");
                this.Show();

            }
        }

        private void Github_pic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bong1102/1618-Programming-cs");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/maihoa.lethi.735");
        }
    }
}
