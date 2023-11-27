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
    public partial class frmBillStatisticsService : Form
    {
        ThongKeDichVuBLL tkdvbll;
        public frmBillStatisticsService()
        {
            InitializeComponent();
            tkdvbll = new ThongKeDichVuBLL();
            LoadTableHoaDonDatPhong();
            LoadComboxboxNam();
            cboLuaChon.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;
            cboQuy.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
        }
        public void LoadComboxboxNam()
        {
            int namhientai = DateTime.Now.Year;
            for (int year = namhientai; year >= 1900; year--)
                cboNam.Items.Add(year);
        }
        public void LoadTableHoaDonDatPhong()
        {
            tblDatPhong.DataSource = tkdvbll.GetThongTinSuDungDichVu();
            tblDatPhong.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblDatPhong.Columns[1].HeaderText = "Tên dịch vụ";
            tblDatPhong.Columns[2].HeaderText = "Ngày thuê";
            tblDatPhong.Columns[3].HeaderText = "Số Lượng";
            tblDatPhong.Columns[4].HeaderText = "Tổng tiền";
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboThang.SelectedIndex)
            {
                case 0:
                    label6.Text = "Tổng số hóa đơn trong tháng?";
                    label7.Text = "Tổng doanh thu trong tháng?";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng?";
                    label9.Text = "0 đơn";
                    label8.Text = "0 đ";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng?";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng?";
                    label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                    label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    break;
                case 1:
                    label6.Text = "Tổng số hóa đơn trong tháng 1";
                    label7.Text = "Tổng doanh thu trong tháng 1";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 1";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 2";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(1) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(1);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(1) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(1);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }

                    break;
                case 2:
                    label6.Text = "Tổng số hóa đơn trong tháng 2";
                    label7.Text = "Tổng doanh thu trong tháng 2";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 2";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 2";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(2) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(2);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(2) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(2);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    
                    break;
                case 3:
                    label6.Text = "Tổng số hóa đơn trong tháng 3";
                    label7.Text = "Tổng doanh thu trong tháng 3";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 3";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 3";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(3) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(3);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(3) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(3);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    
                    break;
                case 4:
                    label6.Text = "Tổng số hóa đơn trong tháng 4";
                    label7.Text = "Tổng doanh thu trong tháng 4";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 4";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 4";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(4) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(4);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(4) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(4);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 5:
                    label6.Text = "Tổng số hóa đơn trong tháng 5";
                    label7.Text = "Tổng doanh thu trong tháng 5";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 5";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 5";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(5) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(5);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(5) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(5);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 6:
                    label6.Text = "Tổng số hóa đơn trong tháng 6";
                    label7.Text = "Tổng doanh thu trong tháng 6";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 6";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 6";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(6) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(6);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(6) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(6);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 7:
                    label6.Text = "Tổng số hóa đơn trong tháng 7";
                    label7.Text = "Tổng doanh thu trong tháng 7";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 7";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 7";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(7) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(7);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(7) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(7);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 8:
                    label6.Text = "Tổng số hóa đơn trong tháng 8";
                    label7.Text = "Tổng doanh thu trong tháng 8";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 8";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 8";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(8) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(8);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(8) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(8);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 9:
                    label6.Text = "Tổng số hóa đơn trong tháng 9";
                    label7.Text = "Tổng doanh thu trong tháng 9";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 9";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 9";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(9) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(9);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(9) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(9);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 10:
                    label6.Text = "Tổng số hóa đơn trong tháng 10";
                    label7.Text = "Tổng doanh thu trong tháng 10";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 10";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 10";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(10) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(10);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(10) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(10);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 11:
                    label6.Text = "Tổng số hóa đơn trong tháng 11";
                    label7.Text = "Tổng doanh thu trong tháng 11";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 11";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 11";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(11) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(11);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(11) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(11);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 12:
                    label6.Text = "Tổng số hóa đơn trong tháng 12";
                    label7.Text = "Tổng doanh thu trong tháng 12";
                    label10.Text = "Dịch vụ được đặt nhiều nhất trong tháng 12";
                    label22.Text = "Dịch vụ được đặt ít nhất trong tháng 12";
                    label9.Text = tkdvbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdvbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(12) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhat(12);
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(12) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhat(12);
                    }
                    catch (Exception)
                    {
                        label25.Text = tkdvbll.TenDichVuDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tkdvbll.TenDichVuDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
            }
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboLuaChon.SelectedIndex)
            {
                case 0:
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    break;
                case 1:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel1.Enabled = true;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    break;
                case 2:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel1.Enabled = false;
                    panel2.Enabled = true;
                    panel3.Enabled = false;
                    break;
                case 3:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = true;
                    break;
            }
        }

        private void cboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboQuy.SelectedIndex)
            {
                case 0:
                    label15.Text = "Tổng số hóa đơn trong quý?";
                    label14.Text = "Tổng doanh thu trong quý?";
                    label13.Text = "0 đơn";
                    label12.Text = "0 đ";
                    label24.Text = "Dịch vụ được đặt nhiều nhất trong quý?";
                    label23.Text = "Dịch vụ được đặt ít nhất trong quý?";
                    label16.Text = "Không có dữ liệu, số lượng: 0";
                    label11.Text = "Không có dữ liệu, số lượng: 0";
                    break;
                case 1:
                    label15.Text = "Tổng số hóa đơn trong quý 1";
                    label14.Text = "Tổng doanh thu trong quý 1";
                    label13.Text = tkdvbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdvbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Dịch vụ được đặt nhiều nhất trong quý 1";
                    label23.Text = "Dịch vụ được đặt ít nhất trong quý 1";
                    try
                    {
                        label16.Text = tkdvbll.TenDichVuDuocDatNhieuNhatTheoQuy(1) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhatTheoQuy(1);
                        label11.Text = tkdvbll.TenDichVuDuocDatItNhatTheoQuy(1) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhatTheoQuy(1);
                    }
                    catch (Exception)
                    {
                        label16.Text = "Không có dữ liệu, số lượng: 0";
                        label11.Text = "Không có dữ liệu, số lượng: 0";
                    }
                    
                    break;
                case 2:
                    label15.Text = "Tổng số hóa đơn trong quý 2";
                    label14.Text = "Tổng doanh thu trong quý 2";
                    label13.Text = tkdvbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdvbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Dịch vụ được đặt nhiều nhất trong quý 2";
                    label23.Text = "Dịch vụ được đặt ít nhất trong quý 2";
                    try
                    {
                        label16.Text = tkdvbll.TenDichVuDuocDatNhieuNhatTheoQuy(2) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhatTheoQuy(2);
                        label11.Text = tkdvbll.TenDichVuDuocDatItNhatTheoQuy(2) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhatTheoQuy(2);
                    }
                    catch (Exception)
                    {
                        label16.Text = "Không có dữ liệu, số lượng: 0";
                        label11.Text = "Không có dữ liệu, số lượng: 0";
                    }
                    break;
                case 3:
                    label15.Text = "Tổng số hóa đơn trong quý 3";
                    label14.Text = "Tổng doanh thu trong quý 3";
                    label13.Text = tkdvbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdvbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Dịch vụ được đặt nhiều nhất trong quý 3";
                    label23.Text = "Dịch vụ được đặt ít nhất trong quý 3";
                    try
                    {
                        label16.Text = tkdvbll.TenDichVuDuocDatNhieuNhatTheoQuy(3) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhatTheoQuy(3);
                        label11.Text = tkdvbll.TenDichVuDuocDatItNhatTheoQuy(3) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhatTheoQuy(3);
                    }
                    catch (Exception)
                    {
                        label16.Text = "Không có dữ liệu, số lượng: 0";
                        label11.Text = "Không có dữ liệu, số lượng: 0";
                    }
                    break;
                case 4:
                    label15.Text = "Tổng số hóa đơn trong quý 4";
                    label14.Text = "Tổng doanh thu trong quý 4";
                    label13.Text = tkdvbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdvbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Dịch vụ được đặt nhiều nhất trong quý 4";
                    label23.Text = "Dịch vụ được đặt ít nhất trong quý 4";
                    try
                    {
                        label16.Text = tkdvbll.TenDichVuDuocDatNhieuNhatTheoQuy(4) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhatTheoQuy(4);
                        label11.Text = tkdvbll.TenDichVuDuocDatItNhatTheoQuy(4) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhatTheoQuy(4);
                    }
                    catch (Exception)
                    {
                        label16.Text = "Không có dữ liệu, số lượng: 0";
                        label11.Text = "Không có dữ liệu, số lượng: 0";
                    }
                    break;
            }
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNam.SelectedIndex == 0)
            {
                label20.Text = "Tổng số hóa đơn trong năm?";
                label19.Text = "Tổng doanh thu trong năm?";
                label18.Text = "0 đơn";
                label17.Text = "0 đ";
                label29.Text = "Dịch vụ được đặt ít nhất trong năm?";
                label30.Text = "Dịch vụ được đặt nhiều nhất trong năm?";
            }
            else
            {
                label20.Text = "Tổng số hóa đơn trong năm " + cboNam.Text;
                label19.Text = "Tổng doanh thu trong năm " + cboNam.Text;
                label18.Text = tkdvbll.SoLuongHoaDonTheoNam(int.Parse(cboNam.Text)).ToString() + " đơn";
                label17.Text = tkdvbll.TongTienTheoNam(int.Parse(cboNam.Text)).ToString("N0") + " đ";
                label29.Text = "Dịch vụ được đặt ít nhất trong " + cboNam.Text;
                label30.Text = "Dịch vụ được đặt nhiều nhất trong " + cboNam.Text;
                try
                {
                    label28.Text = tkdvbll.TenDichVuDuocDatNhieuNhatTheoNam(int.Parse(cboNam.Text)) + " số lượng: " + tkdvbll.LaySoLuongDichVuNhieuNhatTheoNam(int.Parse(cboNam.Text));
                    label27.Text = tkdvbll.TenDichVuDuocDatItNhatTheoNam(int.Parse(cboNam.Text)) + " số lượng: " + tkdvbll.LaySoLuongDichVuItNhatTheoNam(int.Parse(cboNam.Text));
                }
                catch (Exception)
                {
                    label28.Text = "Không có dữ liệu, số lượng: 0";
                    label27.Text = "Không có dữ liệu, số lượng: 0";
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }

    }
}

