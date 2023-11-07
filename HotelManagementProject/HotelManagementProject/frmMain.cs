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
    public partial class FrmMain : Form
    {
        PhongBLL phongBLL;
        RoomPanel panelroom;

        public FrmMain()
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
            flowLayoutPanel1.AutoScroll = true;

            foreach (phong phong in phongList)
            {
                string idphong = phong.id_phong;
                string tenphong = phong.ten;
                string loaiphong = "abc";
                string sotang = phong.id_tang.ToString();
                string trangthai = phong.trang_thai;
                panelroom = new RoomPanel(tenphong, sotang, loaiphong, trangthai, idphong);
                flowLayoutPanel1.Controls.Add(panelroom);
                Button btn3 = panelroom.Controls.Find("btnDonPhong", true).FirstOrDefault() as Button;
                if (btn3 != null)
                    btn3.Click += btnDonPhong_Click;
            }
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            //Label tenphong_label = panelroom.Controls.Find("label1", true).FirstOrDefault() as Label;
            //if (tenphong_label != null)
            //{
            //    string str = tenphong_label.Text;
            //    MessageBox.Show(str);
            //}    
            
        }
    }
}
