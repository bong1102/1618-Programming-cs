using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ASM2
{
    public partial class Home : Form
    {
        // Tạo một biến singleton cho FormHome
        private static Home instance;
        // background for home
        private List<string> imageNames = new List<string>();
        private int currentImageIndex = 0;
        //khai báo cho thời gian chuyển đến nền tiếp theo 
        private Timer timer = new Timer();
        public Home()
        {
            InitializeComponent();
            InitializeImageNames();
            

            // Thiết lập Timer để thay đổi hình nền sau một khoảng thời gian
            timer.Interval = 3000; // Đặt khoảng thời gian 5 giây (đơn vị là mili giây)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Hiển thị hình nền đầu tiên
            ShowCurrentImage();
        }
        private void InitializeImageNames()
        {
            // Thêm tên các hình ảnh vào danh sách
            imageNames.Add("logo_of_GW_Vietnam(2)(2)");
            imageNames.Add("logo_of_GW_Vietnam (1)(1)");
            imageNames.Add("logo_of_GW_Vietnam(4)(4)");
            imageNames.Add("logo_of_GW_Vietnam(3)(3)");
            // Thêm các tên hình ảnh khác nếu cần
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Chuyển đổi sang hình ảnh tiếp theo khi Timer kích hoạt
            currentImageIndex++;
            if (currentImageIndex >= imageNames.Count)
            {
                currentImageIndex = 0; // Quay lại hình ảnh đầu tiên nếu đã hiển thị tất cả
            }
            ShowCurrentImage();
        }

        private void ShowCurrentImage()
        {
            if (currentImageIndex < imageNames.Count)
            {
                string imageName = imageNames[currentImageIndex];

                // Truy cập hình ảnh từ tài nguyên và đặt nó cho PictureBox
                backgroundpic.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            }
        }

        public static Home GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Home();
            }
            return instance;
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homelb_Click(object sender, EventArgs e)
        {
            homelb.ForeColor = Color.DarkCyan;            
        }

        public void SetColor(Color color)
        {
            homelb.ForeColor = color;
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
