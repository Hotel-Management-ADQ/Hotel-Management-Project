using AllControl;
using BLL;
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
        RoomPanel panelroom;
        CustomButton customButton;

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
            //List<phong> phongList = phongBLL.GetPhongList();
            //flowLayoutPanel1.AutoScroll = true;

            //foreach (phong phong in phongList)
            //{


            //    if (phong.trang_thai.Equals("Còn trống"))
            //    {
            //        Button phongButton = new Button();
            //        phongButton.Click += Panelroom_Click;
            //        phongButton.Text = phong.id_phong + "\nPhòng: " + phong.ten + "\nTầng: " + phong.id_tang;
            //        phongButton.Size = new Size(230, 300);
            //        phongButton.BackColor = Color.Green;
            //        flowLayoutPanel1.Controls.Add(phongButton);
            //    }
            //    else if (phong.trang_thai.Equals("Đang sử dụng"))
            //    {
            //        Button phongButton = new Button();
            //        phongButton.Click += Panelroom_Click;
            //        phongButton.Text = phong.id_phong + "\nPhòng: " + phong.ten + "\nTầng: " + phong.id_tang;
            //        phongButton.Size = new Size(130, 200);
            //        phongButton.BackColor = Color.Red;
            //        flowLayoutPanel1.Controls.Add(phongButton);
            //    }

            //}

            List<phong> phongList = phongBLL.GetPhongList();
            flowLayoutPanel1.AutoScroll = true;

            foreach (phong phong in phongList)
            {
                string tenphong = phong.ten;
                string loaiphong = "abc";
                string sotang = phong.id_tang.ToString();
                string trangthai = phong.trang_thai;
                panelroom = new RoomPanel(tenphong, sotang, loaiphong, trangthai);
                panelroom.Click += Panelroom_Click;
                flowLayoutPanel1.Controls.Add(panelroom);

            }

            //List<phong> phongList = phongBLL.GetPhongList();
            //flowLayoutPanel1.AutoScroll = true;

            //foreach (phong phong in phongList)
            //{
            //    string tenphong = phong.ten;
            //    string loaiphong = "abc";
            //    string sotang = phong.id_tang.ToString();
            //    string trangthai = phong.trang_thai;
            //    customButton = new CustomButton(tenphong);
            //    customButton.Click += CustomButton_Click;
            //    flowLayoutPanel1.Controls.Add(customButton);

            //}
        }

        private void Panelroom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sadasdasd");
        }
    }
}
