using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AllControl
{
    public partial class RoomPanel : UserControl
    {
        PhongBLL phongBLL;
        public string id_phong;
        public RoomPanel() { }
        public RoomPanel(string tenphong, string sotang, string loaiphong, string trangthai, string idphong)
        {
            InitializeComponent();
            phongBLL = new PhongBLL();
            id_phong = idphong;
            label1.Text.ToUpper();
            label1.Text = tenphong;
            label3.Text = sotang;
            label6.Text = loaiphong;
            label7.Text = trangthai;
            if (trangthai.Equals("Còn trống"))
            {
                tableLayoutPanel1.BackColor = Color.Green;
                tableLayoutPanel1.ForeColor = Color.White;
                btnCheckIn.Visible = true;
                btnCheckOut.Visible = false;
                btnHuyDonPhong.Visible = false;
            }
            else if (trangthai.Equals("Đang sử dụng"))
            {
                tableLayoutPanel1.BackColor = Color.Red;
                tableLayoutPanel1.ForeColor = Color.White;
                btnCheckOut.Visible = true;
                btnCheckIn.Visible = false;
                btnHuyDonPhong.Visible = false;
            }
            else if (trangthai.Equals("Đang dọn dẹp"))
            {
                tableLayoutPanel1.BackColor = Color.Yellow;
                tableLayoutPanel1.ForeColor = Color.Black;
                btnCheckOut.Visible = false;
                btnCheckIn.Visible = false;
                btnDonPhong.Visible = false;
                btnHuyDonPhong.Visible = true;
            }
            else if (trangthai.Equals("Đang dọn dẹp-used"))
            {
                tableLayoutPanel1.BackColor = Color.Yellow;
                tableLayoutPanel1.ForeColor = Color.Black;
                btnCheckOut.Visible = false;
                btnCheckIn.Visible = false;
                btnDonPhong.Visible = false;
                btnHuyDonPhong.Visible = true;
            }
        }

        private Color borderColor;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            phongBLL.UpdatePhongTrangThai(id_phong, "Đang dọn dẹp");
        }

        private void btnHuyDonPhong_Click(object sender, EventArgs e)
        {
            phongBLL.UpdatePhongTrangThai(id_phong, "Còn trống");
        }
    }
}
