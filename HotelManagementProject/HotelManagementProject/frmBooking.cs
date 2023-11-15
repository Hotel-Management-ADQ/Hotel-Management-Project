using BLL;
using DTO;
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
        DatPhongBLL dpbll;
        PhongBLL phbll;
        KhachHangBLL khbll;
        DichVuBLL dvbll;
        ChiTietDichVuBLL ctdvbll;
        ThietBiBLL tbbll;
        ChiTietThietBiBLL cttbbll;

        string idphong = FrmMain.idphongfrmMain;
        private Timer opacityTimer = new Timer();

        public frmBooking()
        {
            InitializeComponent();
            DesignAnimationForForm();
            dpbll = new DatPhongBLL();
            phbll = new PhongBLL();
            khbll = new KhachHangBLL();
            dvbll = new DichVuBLL();
            tbbll = new ThietBiBLL();
            ctdvbll = new ChiTietDichVuBLL();
            cttbbll = new ChiTietThietBiBLL();
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
            dateTimePicker1.Value = DateTime.Now;
        }
        private void LoadDataForBody()
        {
            txtNhanVien.Text = frmLogin.tentaikhoan.ToUpper();
            txtLoaiPhong.Text = phbll.GetTenLoaiPhong(idphong.Trim());
            LoadDataForCboKhachHang();
            LoadDataPhieuDatPhong();
            LoadDataDichVu(); LoadDataChiTietDichVu();
            LoadDataThietBi(); LoadDataChiTietThietBi();

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
        private void LoadDataDichVu()
        {
            List<dichvu> lstDichVu = dvbll.GetDichVuList();
            tblDichVu.DataSource = lstDichVu;
            tblDichVu.Columns[0].HeaderText = "Mã Dịch Vụ";
            tblDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            tblDichVu.Columns[2].HeaderText = "Giá Dịch Vụ";
            tblDichVu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void LoadDataChiTietDichVu()
        {
            List<ChiTietSuDungDichVu> lstCTDichVu = ctdvbll.GetThongTinSuDungDichVu();
            tblHoaDonDichVu.DataSource = lstCTDichVu;
            tblHoaDonDichVu.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblHoaDonDichVu.Columns[1].HeaderText = "Dịch Vụ Đã Chọn";
            tblHoaDonDichVu.Columns[2].HeaderText = "Ngày Thuê DV";
            tblHoaDonDichVu.Columns[3].HeaderText = "Số Lượng";
            tblHoaDonDichVu.Columns[4].HeaderText = "Tổng Tiền";
        }
        private void LoadDataThietBi()
        {
            List<thietbi> lstThietBi = tbbll.GetThietBiList();
            tblThietBi.DataSource = lstThietBi;
            tblThietBi.Columns[0].HeaderText = "Mã Thiết Bị";
            tblThietBi.Columns[1].HeaderText = "Tên Thiết Bị";
            tblThietBi.Columns[2].HeaderText = "Giá Thiết Bị";
            tblThietBi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void LoadDataChiTietThietBi()
        {
            List<ChiTietSuDungThietBi> lstCTThietBi = cttbbll.GetThongTinSuDungThietBi();
            tblHoaDonThietBi.DataSource = lstCTThietBi;
            tblHoaDonThietBi.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblHoaDonThietBi.Columns[1].HeaderText = "Thiết Bị Đã Chọn";
            tblHoaDonThietBi.Columns[2].HeaderText = "Ngày Thuê TB";
            tblHoaDonThietBi.Columns[3].HeaderText = "Số Lượng";
            tblHoaDonThietBi.Columns[4].HeaderText = "Tổng Tiền";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            var tenkhbycmnd = khbll.GetTenKhachHangByCMND(txtCCCDTimKiemKH.Text);
            if (tenkhbycmnd == null)
                MessageBox.Show("Không kiếm thấy khách hàng");
            else
            {
                cboKhachHang.Text = tenkhbycmnd.ToString();
                txtCCCDTimKiemKH.Text = string.Empty;
            }
        }

        private void tblDichVu_Click(object sender, EventArgs e)
        {
            int i = tblDichVu.CurrentRow.Index;
            lblTenDichVu.Text = tblDichVu.Rows[i].Cells[1].Value.ToString();
            lblGiaDichVu.Text = int.Parse(tblDichVu.Rows[i].Cells[2].Value.ToString().Trim()).ToString("N0") + "đ";
            //label19.Text = lblGiaDichVu.Text.ToString().Replace(",","");
        }

        private void tblThietBi_Click(object sender, EventArgs e)
        {
            int i = tblThietBi.CurrentRow.Index;
            lblTenThietBi.Text = tblThietBi.Rows[i].Cells[1].Value.ToString();
            lblGiaThietBi.Text = int.Parse(tblThietBi.Rows[i].Cells[2].Value.ToString().Trim()).ToString("N0") + "đ";
            //label19.Text = lblGiaThietBi.Text.ToString().Replace(",","");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tblDichVu.DataSource = dvbll.GetDichVuList();
            tblHoaDonDichVu.DataSource = ctdvbll.GetThongTinSuDungDichVu();
            lblTenDichVu.Text = "Dịch vụ chọn là?";
            lblGiaDichVu.Text = "0đ";
            lblTongTienDV.Text = "0đ";
            txtSoLuongDV.Text = string.Empty;
            txtTimKiemDV.Text = string.Empty;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tblThietBi.DataSource = tbbll.GetThietBiList();
            tblHoaDonThietBi.DataSource = cttbbll.GetThongTinSuDungThietBi();
            lblTenThietBi.Text = "Thiết bị đang chọn?";
            lblGiaThietBi.Text = "0đ";
            lblTongTienTB.Text = "0đ";
            txtSoLuongTB.Text = string.Empty;
            txtTimKiemTB.Text = string.Empty;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            
            if (txtTienKhachDua.Text == string.Empty)
                lblTienKhachDua.Text = "0đ";
            else
            {
                lblTienKhachDua.Text = Int64.Parse(txtTienKhachDua.Text.Trim()).ToString("N0") + "đ";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenkh = cboKhachHang.SelectedValue.ToString();
            lblTenKhInGroupbox.Text = cboKhachHang.SelectedValue.ToString().Trim();
            lblNgaySinhInGroupbox.Text = khbll.GetNgaySinhByTen(tenkh).ToString("dd/MM/yyyy");
            lblSdtInGroupbox.Text = khbll.GetSdtByTen(tenkh);
            lblCccdInGroupbox.Text = khbll.GetCccdByTen(tenkh);
            lblGioiTinhInGroupbox.Text = khbll.GetGioiTinhByTen(tenkh);
        }
    }
}
