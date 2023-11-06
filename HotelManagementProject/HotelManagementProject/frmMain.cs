using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementProject
{
    public partial class frmMain : Form
    {
        PhongBLL phongBLL;
        private VScrollBar vScrollBar1;

        public frmMain()
        {
            InitializeComponent();
            phongBLL = new PhongBLL();
            label4.Text = frmLogin.tentaikhoan;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DesignLayoutFormMain();
        }

        private void DesignLayoutFormMain()
        {
            List<phong> phongList = phongBLL.GetPhongList();
            flowLayoutPanel1.AutoScroll = true; // Tắt chế độ tự động cuộn của flowLayoutPanel1

            foreach (phong phong in phongList)
            {
                Button phongButton = new Button();
                phongButton.Text = phong.id_phong + "\nPhòng: " + phong.ten + "\nTầng: " + phong.id_tang;
                phongButton.Size = new Size(230, 300);

                if (phong.trang_thai.Equals("Còn trống"))
                {
                    phongButton.BackColor = Color.Green;
                }
                else if (phong.trang_thai.Equals("Đang sử dụng"))
                {
                    phongButton.BackColor = Color.Red;
                }
                flowLayoutPanel1.Controls.Add(phongButton);
            }
        }
    }
}
