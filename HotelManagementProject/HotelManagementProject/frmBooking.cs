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
        LoaiPhongBLL lpbll;
        KhachHangBLL khbll;
        DichVuBLL dvbll;
        ChiTietDichVuBLL ctdvbll;
        ThietBiBLL tbbll;
        ChiTietThietBiBLL cttbbll;
        NhanVienBLL nvbll;

        string idphong = FrmMain.idphongfrmMain;
        private Timer opacityTimer = new Timer();


        public frmBooking()
        {
            InitializeComponent();
            DesignAnimationForForm();
            dpbll = new DatPhongBLL();
            phbll = new PhongBLL();
            lpbll = new LoaiPhongBLL();
            khbll = new KhachHangBLL();
            dvbll = new DichVuBLL();
            tbbll = new ThietBiBLL();
            nvbll = new NhanVienBLL();
            ctdvbll = new ChiTietDichVuBLL();
            cttbbll = new ChiTietThietBiBLL();
            LoadDataForHeader();
            LoadDataForBody();
            if (FrmMain.trangthaifrmMain.Equals("Còn trống"))
            {
                btnCheckIn.Visible = true;
                btnCheckOut.Visible = false;
                panelDichVu.Visible = false;
                panelThietBi.Visible = false;
            }
            else if (FrmMain.trangthaifrmMain.Equals("Đang sử dụng"))
            {
                btnCheckIn.Visible = false;
                btnCheckOut.Visible = false;
                btnCheckOut.Enabled = true;
                cboKhachHang.Enabled = false;
                btnTimKiemKH.Enabled = false;
                txtCCCDTimKiemKH.Enabled = false;
                cboLoaiThue.Enabled = false;
                txtDatCoc.Enabled = false;
                dateCheckIn.Enabled = false;
                dateCheckOut.Enabled = false;
                label4.Visible = false;
                lblSoTienDatCoc.Visible = false;
                btnDatCoc.Enabled = false;
                btnCapNhat.Enabled = true;
                btnDoiPhong.Enabled = true;
                btnThanhToan.Enabled = true;
                LoadFormForCheckOutHaveIdDatPhong();
            }

        }
        private void LoadFormForCheckOutHaveIdDatPhong()
        {
            txtIDHoaDonBookingForm.Text = dpbll.LayIdDatPhongChuaThanhToan(idphong);

            txtNhanVien.Text = dpbll.GetTenNhanVienByIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong));
            cboKhachHang.Text = dpbll.GetTenKhachHangByIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong));
            cboLoaiThue.Text = dpbll.GetLoaiThueByIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong));
            txtSoNguoiO.Text = dpbll.GetSoNguoiOByIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong)).ToString();
            txtDatCoc.Text = dpbll.GetTienDatCocIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong)).ToString("N0") + " đ";
            dateCheckIn.Value = dpbll.GetCheckInIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong));
            dateCheckOut.Value = dpbll.GetCheckOutIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong));
            label13.Text = dpbll.GetTrangThaiHoaDonByIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong));
            label23.Text = dpbll.GetTienDatCocIDDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong)).ToString("N0") + " đ";


            double phuThuCheckIn = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tienPhuthu;
            double phuThuCheckOut = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tienPhuthu1;
            double tongTienPhuThuBaoGomTienPhong = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tongTien;
            double tongTienPhong = tongTienPhuThuBaoGomTienPhong - phuThuCheckIn - phuThuCheckOut;
            //int tienphong = int.Parse(lblTongThoiGianNgayVaGio.Text) * dpbll.LayGiaPhongByIDDatPhong(txtIDHoaDonBookingForm.Text.Trim());
            label27.Text = tongTienPhong.ToString("N0") + " đ";

            lblPhuThuCheckIn.Text = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tienPhuthu.ToString("N0") + " đ";
            lblPhuThuCheckOut.Text = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tienPhuthu1.ToString("N0") + " đ";


            if (ctdvbll.DemSoLuongIDDatPhongTrongChiTietSuDungDichVu(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
            {
                lblTongTienDV1.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                lblTongTienDV2.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
            }
            else
            {
                lblTongTienDV1.Text = "0";
                lblTongTienDV2.Text = "0";
            }

            if (cttbbll.DemSoLuongIDDatPhongTrongChiTietSuDungThietBi(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
            {
                lblTongTienTB1.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                lblTongTienTB2.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
            }
            else
            {
                lblTongTienTB1.Text = "0";
                lblTongTienTB2.Text = "0";
            }
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
            dateCheckIn.Value = DateTime.Now;
        }
        private void LoadDataForBody()
        {
            txtNhanVien.Text = frmLogin.tentaikhoan.ToUpper();
            txtLoaiPhong.Text = phbll.GetTenLoaiPhong(idphong.Trim());
            LoadDataForCboKhachHang();
            LoadDataPhieuDatPhong();
            LoadDataDichVu(); LoadDataChiTietDichVu();
            LoadDataThietBi(); LoadDataChiTietThietBi();
            cboLoaiThue.SelectedIndex = 0;

        }
        private void LoadDataForCboKhachHang()
        {
            cboKhachHang.DataSource = khbll.GetTenKhachHangList();
        }
        private void LoadDataPhieuDatPhong()
        {
            List<PhieuDatPhongDTO> lst = dpbll.GetPhieuDatPhong(phbll.GetTenPhongByIdPhong(idphong.Trim()).Trim());
            tblPhieuDatPhong.DataSource = lst;

            tblPhieuDatPhong.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            tblPhieuDatPhong.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            tblPhieuDatPhong.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblPhieuDatPhong.Columns[1].HeaderText = "Tên Phòng";
            tblPhieuDatPhong.Columns[2].HeaderText = "Tên Nhân Viên";
            tblPhieuDatPhong.Columns[3].HeaderText = "Tên Khách Hàng";
            tblPhieuDatPhong.Columns[4].HeaderText = "Loại Hình Đặt";
            tblPhieuDatPhong.Columns[5].HeaderText = "Check-in";
            tblPhieuDatPhong.Columns[6].HeaderText = "Check-out";
            tblPhieuDatPhong.Columns[7].HeaderText = "Tổng thời gian";
            tblPhieuDatPhong.Columns[8].HeaderText = "Trạng Thái HĐ";
            tblPhieuDatPhong.AllowUserToResizeRows = false;
        }

        private void LoadDataDichVu()
        {
            List<dichvu> lstDichVu = dvbll.GetDichVuList();
            tblDichVu.DataSource = lstDichVu;
            tblDichVu.Columns[0].HeaderText = "Mã Dịch Vụ";
            tblDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            tblDichVu.Columns[2].HeaderText = "Giá Dịch Vụ";
            tblDichVu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tblDichVu.AllowUserToResizeRows = false;
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

            tblHoaDonDichVu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tblHoaDonDichVu.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tblHoaDonDichVu.AllowUserToResizeRows = false;
        }
        private void LoadDataThietBi()
        {
            List<thietbi> lstThietBi = tbbll.GetThietBiList();
            tblThietBi.DataSource = lstThietBi;
            tblThietBi.Columns[0].HeaderText = "Mã Thiết Bị";
            tblThietBi.Columns[1].HeaderText = "Tên Thiết Bị";
            tblThietBi.Columns[2].HeaderText = "Giá Thiết Bị";
            tblThietBi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tblThietBi.AllowUserToResizeRows = false;
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

            tblHoaDonThietBi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tblHoaDonThietBi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tblHoaDonThietBi.AllowUserToResizeRows = false;
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
        }

        private void tblThietBi_Click(object sender, EventArgs e)
        {
            int i = tblThietBi.CurrentRow.Index;
            lblTenThietBi.Text = tblThietBi.Rows[i].Cells[1].Value.ToString();
            lblGiaThietBi.Text = int.Parse(tblThietBi.Rows[i].Cells[2].Value.ToString().Trim()).ToString("N0") + "đ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tblDichVu.DataSource = dvbll.GetDichVuList();
            tblHoaDonDichVu.DataSource = ctdvbll.GetThongTinSuDungDichVu();
            lblTenDichVu.Text = "";
            lblGiaDichVu.Text = "";
            txtSoLuongDV.Text = string.Empty;
            txtTimKiemDV.Text = string.Empty;
            btnXoaCTDichVu.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tblThietBi.DataSource = tbbll.GetThietBiList();
            tblHoaDonThietBi.DataSource = cttbbll.GetThongTinSuDungThietBi();
            lblTenThietBi.Text = "";
            lblGiaThietBi.Text = "";
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

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenkh = cboKhachHang.SelectedValue.ToString();
            lblTenKhInGroupbox.Text = cboKhachHang.SelectedValue.ToString().Trim();
            lblNgaySinhInGroupbox.Text = khbll.GetNgaySinhByTen(tenkh).ToString("dd/MM/yyyy");
            lblSdtInGroupbox.Text = khbll.GetSdtByTen(tenkh);
            lblCccdInGroupbox.Text = khbll.GetCccdByTen(tenkh);
            lblGioiTinhInGroupbox.Text = khbll.GetGioiTinhByTen(tenkh);
        }

        private void txtSoNguoiO_Leave(object sender, EventArgs e)
        {
            if (txtSoNguoiO.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNguoiO.Focus();
            }
            else
            {
                if (int.Parse(txtSoNguoiO.Text) > lpbll.GetSoNguoiOByIdPhong(idphong))
                {
                    MessageBox.Show("Số người ở vượt quá cho phép, " + lblTenPhong.Text + " tối đa chỉ được: " + lpbll.GetSoNguoiOByIdPhong(idphong) + " người",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoNguoiO.Focus();
                }
                else if (int.Parse(txtSoNguoiO.Text) == 0)
                {
                    MessageBox.Show("Không được nhập 0",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoNguoiO.Focus();
                }
            }
        }

        double tiendatcoc;
        private void btnDatCoc_Click(object sender, EventArgs e)
        {
            // result < 0 nếu dateCheckIn nhỏ hơn dateCheckOut
            // result == 0 nếu dateCheckIn bằng dateCheckOut
            // result > 0 nếu dateCheckIn lớn hơn dateCheckOut

            DateTime checkin = dateCheckIn.Value;
            DateTime checkout = dateCheckOut.Value;
            int kq = DateTime.Compare(checkin, checkout);
            if (kq > 0)
                MessageBox.Show("Ngày check-out phải lớn hơn ngày check-in", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TimeSpan duration = checkout - checkin;
                int songay = (int)duration.TotalDays;
                int giaphong = int.Parse(dpbll.GetGiaPhong(idphong.Trim()));
                tiendatcoc = (int.Parse(lblTongThoiGianNgayVaGio.Text.Trim()) * giaphong) / 2;
                string fmtiendatcoc = tiendatcoc.ToString("N0") + " đ";
                lblSoTienDatCoc.Text = fmtiendatcoc.ToString();
                btnCheckIn.Enabled = true;
                btnDatCoc.Enabled = false;
            }
        }

        private void dateCheckOut_ValueChanged(object sender, EventArgs e)
        {
            DateTime checkin = dateCheckIn.Value;
            DateTime checkout = dateCheckOut.Value;
            int kq = DateTime.Compare(checkin, checkout);

            if (cboLoaiThue.Text.Equals("Theo Ngày"))
            {
                if (kq > 0)
                {
                    MessageBox.Show("Ngày check-out phải lớn hơn ngày check-in", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateCheckOut.Focus();
                }
                else
                {
                    TimeSpan duration = checkout - checkin;
                    int songay = (int)duration.TotalDays;
                    lblTongThoiGianNgayVaGio.Text = (songay + 1).ToString();
                    label15.Visible = true;
                }
            }
            else if (cboLoaiThue.Text.Equals("Theo Giờ"))
            {
                if (kq > 0)
                {
                    MessageBox.Show("Ngày check-out phải lớn hơn ngày check-in", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateCheckOut.Focus();
                }
                else
                {
                    label48.Visible = true;
                    TimeSpan duration = checkout - checkin;
                    double sogio = duration.TotalHours;
                    if (sogio < 0)
                    {
                        lblTongThoiGianNgayVaGio.Text = "1";
                    }
                    else
                    {
                        int lamtronsogio = (int)Math.Round(sogio);
                        lblTongThoiGianNgayVaGio.Text = lamtronsogio.ToString();
                    }
                }
            }
        }

        private void cboLoaiThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTongThoiGianNgayVaGio.Text = "0 ngày/giờ";
            if (cboLoaiThue.Text.Equals("Theo Ngày"))
            {
                btnDatCoc.Enabled = true;
                btnCheckIn.Enabled = false;
                label15.Visible = false;
                label48.Visible = false;
            }
            else if (cboLoaiThue.Text.Equals("Theo Giờ"))
            {
                btnDatCoc.Enabled = false;
                btnCheckIn.Enabled = true;
                label15.Visible = false;
                label48.Visible = false;
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string idnv = nvbll.GetIdNhanVienByTen(frmLogin.tentaikhoan.Trim());
            string idkh = khbll.GetIdKHByTen(cboKhachHang.Text.Trim());
            //string idphong = idphong
            DateTime checkin = dateCheckIn.Value;
            DateTime checkout = dateCheckOut.Value;
            int songuoio = int.Parse(txtSoNguoiO.Text.Trim());
            string loaithue = cboLoaiThue.Text.Trim();
            double tiencoc = tiendatcoc;

            dpbll.DatPhong(idnv, idkh, idphong, checkin, checkout, songuoio, loaithue, tiencoc);
            dpbll.UpdateTrangThaiPhong(idphong);
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

        private void btnThemCTDichVu_Click(object sender, EventArgs e)
        {
            if (lblTenDichVu.Text == string.Empty)
                MessageBox.Show("Bạn chưa chọn dịch vụ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtSoLuongDV.Text == string.Empty)
                    MessageBox.Show("Chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int i = tblDichVu.CurrentRow.Index;
                    ctdvbll.ThemChiTietDichVu(txtIDHoaDonBookingForm.Text.Trim(), tblDichVu.Rows[i].Cells[0].Value.ToString(), DateTime.Now, int.Parse(txtSoLuongDV.Text.Trim()));
                    LoadDataChiTietDichVu();
                    lblTenDichVu.Text = string.Empty;
                    lblGiaDichVu.Text = string.Empty;
                    txtSoLuongDV.Text = string.Empty;
                    if (ctdvbll.DemSoLuongIDDatPhongTrongChiTietSuDungDichVu(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
                    {
                        lblTongTienDV1.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                        lblTongTienDV2.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                    }
                    else
                    {
                        lblTongTienDV1.Text = "0";
                        lblTongTienDV2.Text = "0";
                    }
                    lblTenDichVu.Text = "";
                    lblGiaDichVu.Text = "";
                    txtSoLuongDV.Text = "";
                }
            }
        }

        private void btnXoaCTDichVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = tblHoaDonDichVu.CurrentRow.Index;
                string iddv = dvbll.LayIDDichVuByTenDichVu(tblHoaDonDichVu.Rows[i].Cells[1].Value.ToString());
                string iddatphong = txtIDHoaDonBookingForm.Text.Trim();
                ctdvbll.XoaChiTietSuDungDichVu(iddatphong, iddv);
                LoadDataChiTietDichVu();
                if (ctdvbll.DemSoLuongIDDatPhongTrongChiTietSuDungDichVu(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
                {
                    lblTongTienDV1.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                    lblTongTienDV2.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                }
                else
                {
                    lblTongTienDV1.Text = "0";
                    lblTongTienDV2.Text = "0";
                }
                lblTenDichVu.Text = "";
                lblGiaDichVu.Text = "";
                txtSoLuongDV.Text = "";
            }
        }

        private void tblHoaDonDichVu_Click(object sender, EventArgs e)
        {
            int i = tblHoaDonDichVu.CurrentRow.Index;
            btnXoaCTDichVu.Enabled = true;
            lblTenDichVu.Text = tblHoaDonDichVu.Rows[i].Cells[1].Value.ToString();
            lblGiaDichVu.Text = dvbll.LayGiaByTenDichVu(tblHoaDonDichVu.Rows[i].Cells[1].Value.ToString()).ToString();
        }

        private void btnSuaCTDichVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có cập nhật hóa đơn dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (lblTenDichVu.Text != string.Empty)
                {
                    if (txtSoLuongDV.Text != string.Empty)
                    {
                        int i = tblHoaDonDichVu.CurrentRow.Index;
                        string iddv = dvbll.LayIDDichVuByTenDichVu(tblHoaDonDichVu.Rows[i].Cells[1].Value.ToString());
                        string iddatphong = txtIDHoaDonBookingForm.Text.Trim();
                        ctdvbll.SuaSoLuongChiTietSuDungDichVu(iddatphong, iddv, int.Parse(txtSoLuongDV.Text));
                        LoadDataChiTietDichVu();
                        if (ctdvbll.DemSoLuongIDDatPhongTrongChiTietSuDungDichVu(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
                        {
                            lblTongTienDV1.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                            lblTongTienDV2.Text = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                        }
                        else
                        {
                            lblTongTienDV1.Text = "0";
                            lblTongTienDV2.Text = "0";
                        }
                        lblTenDichVu.Text = "";
                        lblGiaDichVu.Text = "";
                        txtSoLuongDV.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập số lượng cho dịch vụ cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoLuongDV.Focus();
                    }
                }
                else
                    MessageBox.Show("Chưa chọn hóa đơn dịch vụ cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtTimKiemDV.Text == string.Empty)
            {
                LoadDataDichVu();
            }
            else
            {
                List<dichvu> lstNew = dvbll.TimKiemDichVu(txtTimKiemDV.Text.Trim());
                tblDichVu.DataSource = lstNew;
            }
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            if (lblTenThietBi.Text == string.Empty)
                MessageBox.Show("Bạn chưa chọn thiết bị nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtSoLuongTB.Text == string.Empty)
                    MessageBox.Show("Chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int i = tblThietBi.CurrentRow.Index;
                    cttbbll.ThemChiTietThietBi(txtIDHoaDonBookingForm.Text.Trim(), tblThietBi.Rows[i].Cells[0].Value.ToString(), DateTime.Now, int.Parse(txtSoLuongTB.Text.Trim()));
                    LoadDataChiTietThietBi();
                    lblTenThietBi.Text = string.Empty;
                    lblGiaThietBi.Text = string.Empty;
                    txtSoLuongTB.Text = string.Empty;
                    if (cttbbll.DemSoLuongIDDatPhongTrongChiTietSuDungThietBi(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
                    {
                        lblTongTienTB1.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                        lblTongTienTB2.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                    }
                    else
                    {
                        lblTongTienTB1.Text = "0";
                        lblTongTienTB2.Text = "0";
                    }
                    lblTenThietBi.Text = "";
                    lblGiaThietBi.Text = "";
                    txtSoLuongTB.Text = "";
                }
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn thiết bị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = tblHoaDonThietBi.CurrentRow.Index;
                string idtb = tbbll.LayIDThietBiByTenThietBi(tblHoaDonThietBi.Rows[i].Cells[1].Value.ToString());
                string iddatphong = txtIDHoaDonBookingForm.Text.Trim();
                cttbbll.XoaChiTietSuDungThietBi(iddatphong, idtb);
                LoadDataChiTietThietBi();
                if (cttbbll.DemSoLuongIDDatPhongTrongChiTietSuDungThietBi(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
                {
                    lblTongTienTB1.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                    lblTongTienTB2.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                }
                else
                {
                    lblTongTienTB1.Text = "0";
                    lblTongTienTB2.Text = "0";
                }
                lblTenThietBi.Text = "";
                lblGiaThietBi.Text = "";
                txtSoLuongTB.Text = "";
            }
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có cập nhật hóa đơn thiết bị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (lblTenThietBi.Text != string.Empty)
                {
                    if (txtSoLuongTB.Text != string.Empty)
                    {
                        int i = tblHoaDonThietBi.CurrentRow.Index;
                        string idtb = tbbll.LayIDThietBiByTenThietBi(tblHoaDonThietBi.Rows[i].Cells[1].Value.ToString());
                        string iddatphong = txtIDHoaDonBookingForm.Text.Trim();
                        cttbbll.SuaSoLuongChiTietSuDungThietBi(iddatphong, idtb, int.Parse(txtSoLuongTB.Text));
                        LoadDataChiTietThietBi();
                        if (cttbbll.DemSoLuongIDDatPhongTrongChiTietSuDungThietBi(dpbll.LayIdDatPhongChuaThanhToan(idphong)) > 0)
                        {
                            lblTongTienTB1.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                            lblTongTienTB2.Text = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim()).ToString("N0") + " đ";
                        }
                        else
                        {
                            lblTongTienTB1.Text = "0";
                            lblTongTienTB2.Text = "0";
                        }
                        lblTenThietBi.Text = "";
                        lblGiaThietBi.Text = "";
                        txtSoLuongTB.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập số lượng cho thiết bị cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoLuongDV.Focus();
                    }
                }
                else
                    MessageBox.Show("Chưa chọn hóa đơn thiết bị cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimTB_Click(object sender, EventArgs e)
        {
            if (txtTimKiemTB.Text == string.Empty)
            {
                LoadDataThietBi();
            }
            else
            {
                List<thietbi> lstNew = tbbll.TimKiemThietBi(txtTimKiemTB.Text.Trim());
                tblThietBi.DataSource = lstNew;
            }
        }

        private void tblHoaDonThietBi_Click(object sender, EventArgs e)
        {
            int i = tblHoaDonThietBi.CurrentRow.Index;
            btnXoaTB.Enabled = true;
            lblTenThietBi.Text = tblHoaDonThietBi.Rows[i].Cells[1].Value.ToString();
            lblGiaThietBi.Text = tbbll.LayGiaByTenThietBi(tblHoaDonThietBi.Rows[i].Cells[1].Value.ToString()).ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thanh toán hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                double phuThuCheckIn = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tienPhuthu;
                double phuThuCheckOut = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tienPhuthu1;
                double tongTienPhuThuBaoGomTienPhong = dpbll.TinhTongTienPhuThu(cboLoaiThue.Text.Trim(), dpbll.LayIdDatPhongChuaThanhToan(idphong)).tongTien;
                double tienDatCoc = dpbll.GetTienDatCocIDDatPhong(txtIDHoaDonBookingForm.Text.Trim());
                //double tongTienPhuThu = phuThuCheckIn + phuThuCheckOut;
                //double tongTienPhong = tongTienPhuThuBaoGomTienPhong - phuThuCheckIn - phuThuCheckOut;
                double tienDichVu = ctdvbll.TinhTongTienDichVuTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim());
                double tienThietBi = cttbbll.TinhTongTienThietBiTheoIDDatPhong(txtIDHoaDonBookingForm.Text.Trim());

                double thanhToanTong = tongTienPhuThuBaoGomTienPhong - tienDatCoc + tienDichVu + tienThietBi;
                lblTongTienThanhToan.Text = thanhToanTong.ToString("N0") + " đ";

                dpbll.CapNhatPhuThuThongTinDatPhong(dpbll.LayIdDatPhongChuaThanhToan(idphong), 
                    phuThuCheckIn, phuThuCheckOut, thanhToanTong);

                btnThoat.Visible = false;
                btnCheckOut.Visible = true;
                btnCheckOut.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
