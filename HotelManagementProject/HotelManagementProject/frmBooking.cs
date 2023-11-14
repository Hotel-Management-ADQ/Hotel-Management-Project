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
    public partial class frmBooking : Form
    {
        string idphong = FrmMain.idphongfrmMain;
        DatPhongBLL dpbll;
        PhongBLL phbll;
        KhachHangBLL khbll;
        private Timer opacityTimer = new Timer();
        public frmBooking()
        {
            InitializeComponent();
            DesignAnimationForForm();
            dpbll = new DatPhongBLL();
            phbll = new PhongBLL();
            khbll = new KhachHangBLL();
            LoadDataForHeader();
            LoadDataForBody();
            
        }
        private void DesignAnimationForForm()
        {
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
        private void LoadDataForHeader()
        {
            lblTenPhong.Text = dpbll.GetTenPhong(idphong.Trim()).ToUpper();
            lblGiaTien.Text = dpbll.GetGiaPhong(idphong.Trim()) + " VND";
            lblTenNhanVien.Text = "Nhân Viên: " + frmLogin.tentaikhoan.ToUpper();
            
        }
        private void LoadDataForBody()
        {
            txtNhanVien.Text = frmLogin.tentaikhoan.ToUpper();
            txtLoaiPhong.Text = phbll.GetTenLoaiPhong(idphong.Trim());
            LoadDataForCboKhachHang();
            LoadDataPhieuDatPhong();
        }
        private void LoadDataForCboKhachHang()
        {
            cboKhachHang.DataSource = khbll.GetTenKhachHangList();
        }
        private void LoadDataPhieuDatPhong()
        {
            List<view_datphong2> lst = dpbll.GetPhieuDatPhong(phbll.GetTenPhongByIdPhong(idphong.Trim()).Trim());
            tblPhieuDatPhong.DataSource = lst;
            tblPhieuDatPhong.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblPhieuDatPhong.Columns[1].HeaderText = "Tên Phòng";
            tblPhieuDatPhong.Columns[2].HeaderText = "Tên Khách Hàng";
            tblPhieuDatPhong.Columns[3].HeaderText = "Tên Nhân Viên";
            tblPhieuDatPhong.Columns[4].HeaderText = "Loại Hình Đặt";
            tblPhieuDatPhong.Columns[5].HeaderText = "Check-in";
            tblPhieuDatPhong.Columns[6].HeaderText = "Check-out";
            tblPhieuDatPhong.Columns[7].HeaderText = "Tổng thời gian";
            tblPhieuDatPhong.Columns[8].HeaderText = "Trạng Thái HĐ";
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            var tenkhbycmnd = khbll.GetTenKhachHangByCMND(txtCCCD.Text);
            if (tenkhbycmnd == null)
                MessageBox.Show("Không kiếm thấy khách hàng");
            else
                cboKhachHang.Text = tenkhbycmnd.ToString();
        }
    }
}
