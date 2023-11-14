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
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using DTO;

namespace HotelManagementProject
{
    public partial class FrmMain : Form
    {
        PhongBLL phongBLL;
        RoomPanel panelroom;
        private Timer opacityTimer = new Timer();
        List<PhongDTO> phongList;
        public static string idphongfrmMain;

        public FrmMain()
        {
            InitializeComponent();
            InitializeBtnFromLabel();
            phongBLL = new PhongBLL();
            label4.Text = frmLogin.tentaikhoan;
            DesignLayoutFormMain();
            this.Opacity = 0;
            opacityTimer.Interval = 5;
            opacityTimer.Tick += new EventHandler(OnTimerTick);
            opacityTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
                this.Opacity += 0.1;
            else
                opacityTimer.Stop();
        }

        string str;
        private void DesignLayoutFormMain()
        {
            phongList = phongBLL.GetPhongListCoTenLoaiPhong();
            flowLayoutPanel1.AutoScroll = true;

            foreach (PhongDTO phong in phongList)
            {
                str = phong.TenPhong;
                string idphong = phong.IdPhong;
                string tenphong = phong.TenPhong.ToUpper();
                string loaiphong = phong.TenLoaiPhong;
                string sotang = phong.SoTang.ToString();
                string trangthai = phong.TrangThai;
                panelroom = new RoomPanel(tenphong, sotang, loaiphong, trangthai, idphong);
                flowLayoutPanel1.Controls.Add(panelroom);
                Button btn3 = panelroom.Controls.Find("btnDonPhong", true).FirstOrDefault() as Button;
                if (btn3 != null)
                    btn3.Click += btnDonPhong_Click;
                Button btn4 = panelroom.Controls.Find("btnHuyDonPhong", true).FirstOrDefault() as Button;
                if (btn4 != null)
                    btn4.Click += btnHuyDonPhong_Click;
                Button btn5 = panelroom.Controls.Find("btnCheckIn", true).FirstOrDefault() as Button;
                if (btn5 != null)
                    btn5.Click += (sender, e) =>
                    {
                        idphongfrmMain = idphong;
                        frmBooking frm = new frmBooking();
                        frm.Show();
                        this.Visible = false;
                        //MessageBox.Show(idphong);
                    };
            }
        }

        private void btnHuyDonPhong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

        public void InitializeBtnFromLabel()
        {
            //--------------------------------------------------
            btnXemDonDatPhong.MouseEnter += (sender, e) =>
            {
                btnXemDonDatPhong.BackColor = Color.DarkGreen;
            };
            btnXemDonDatPhong.MouseLeave += (sender, e) =>
            {
                btnXemDonDatPhong.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLKhachHang.MouseEnter += (sender, e) =>
            {
                btnQLKhachHang.BackColor = Color.DarkGreen;
            };
            btnQLKhachHang.MouseLeave += (sender, e) =>
            {
                btnQLKhachHang.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLDichVu.MouseEnter += (sender, e) =>
            {
                btnQLDichVu.BackColor = Color.DarkGreen;
            };
            btnQLDichVu.MouseLeave += (sender, e) =>
            {
                btnQLDichVu.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLThietBi.MouseEnter += (sender, e) =>
            {
                btnQLThietBi.BackColor = Color.DarkGreen;
            };
            btnQLThietBi.MouseLeave += (sender, e) =>
            {
                btnQLThietBi.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLPhong.MouseEnter += (sender, e) =>
            {
                btnQLPhong.BackColor = Color.DarkGreen;
            };
            btnQLPhong.MouseLeave += (sender, e) =>
            {
                btnQLPhong.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLHoaDon.MouseEnter += (sender, e) =>
            {
                btnQLHoaDon.BackColor = Color.DarkGreen;
            };
            btnQLHoaDon.MouseLeave += (sender, e) =>
            {
                btnQLHoaDon.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLNhanVien.MouseEnter += (sender, e) =>
            {
                btnQLNhanVien.BackColor = Color.DarkGreen;
            };
            btnQLNhanVien.MouseLeave += (sender, e) =>
            {
                btnQLNhanVien.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnQLQuyen.MouseEnter += (sender, e) =>
            {
                btnQLQuyen.BackColor = Color.DarkGreen;
            };
            btnQLQuyen.MouseLeave += (sender, e) =>
            {
                btnQLQuyen.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnThongKeDoanhThu.MouseEnter += (sender, e) =>
            {
                btnThongKeDoanhThu.BackColor = Color.DarkGreen;
            };
            btnThongKeDoanhThu.MouseLeave += (sender, e) =>
            {
                btnThongKeDoanhThu.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnDoiMatKhau.MouseEnter += (sender, e) =>
            {
                btnDoiMatKhau.BackColor = Color.DarkGreen;
            };
            btnDoiMatKhau.MouseLeave += (sender, e) =>
            {
                btnDoiMatKhau.BackColor = Color.Green;
            };
            //--------------------------------------------------
            btnThoat.MouseEnter += (sender, e) =>
            {
                btnThoat.BackColor = Color.DarkGreen;
            };
            btnThoat.MouseLeave += (sender, e) =>
            {
                btnThoat.BackColor = Color.Green;
            };

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                Program.loginForm = new frmLogin();
                Program.loginForm.Show();
            }
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.customerForm = new frmCustomer();
            Program.customerForm.Show();
        }

        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.serviceForm = new frmService();
            Program.serviceForm.Show();
        }

        private void btnQLThietBi_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.deviceForm = new frmDevice();
            Program.deviceForm.Show();
        }
    }
}
