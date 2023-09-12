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

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usertxt_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            passtxt.BackColor = SystemColors.Control;
        }

        private void passtxt_Click(object sender, EventArgs e)
        {
            passtxt.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
        //ẩn pass
        private void eyehide_Click(object sender, EventArgs e)
        {
            if(passtxt.PasswordChar == '•')
            {
                eyeshow.BringToFront();
                passtxt.PasswordChar = '\0';
            }
        }
        //hiện pass
        private void eyeshow_Click(object sender, EventArgs e)
        {
            if (passtxt.PasswordChar == '\0')
            {
                eyehide.BringToFront();
                passtxt.PasswordChar = '•';
            }
        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            // ẩn form login sau khi đăng nhập
            this.Hide();
            // Hiển thị Home form
            Home home = Home.GetInstance();
            //hiển thị màu khi chuyển từ login sang
            home.SetColor(Color.DarkCyan);
            home.Show();
            // Đóng cửa sổ đăng nhập (LoginForm)
            //this.Close();
        }
        // liên kết link github
        private void linklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bong1102/1618-Programming-cs");
        }
    }
}
