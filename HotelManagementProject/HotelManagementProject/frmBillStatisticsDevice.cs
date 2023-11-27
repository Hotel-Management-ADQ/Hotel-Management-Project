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
    public partial class frmBillStatisticsDevice : Form
    {
        ThongKeThietBiBLL tktbbll;

        public frmBillStatisticsDevice()
        {
            InitializeComponent();
            tktbbll = new ThongKeThietBiBLL();
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
            tblDatPhong.DataSource = tktbbll.GetThongTinSuDungThietBi();
            tblDatPhong.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblDatPhong.Columns[1].HeaderText = "Tên thiết bị";
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
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng?";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng?";
                    label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                    label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    break;
                case 1:
                    label6.Text = "Tổng số hóa đơn trong tháng 1";
                    label7.Text = "Tổng doanh thu trong tháng 1";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 1";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 2";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(1) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(1);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(1) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(1);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }

                    break;
                case 2:
                    label6.Text = "Tổng số hóa đơn trong tháng 2";
                    label7.Text = "Tổng doanh thu trong tháng 2";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 2";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 2";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(2) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(2);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(2) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(2);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }

                    break;
                case 3:
                    label6.Text = "Tổng số hóa đơn trong tháng 3";
                    label7.Text = "Tổng doanh thu trong tháng 3";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 3";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 3";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(3) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(3);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(3) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(3);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }

                    break;
                case 4:
                    label6.Text = "Tổng số hóa đơn trong tháng 4";
                    label7.Text = "Tổng doanh thu trong tháng 4";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 4";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 4";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(4) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(4);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(4) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(4);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 5:
                    label6.Text = "Tổng số hóa đơn trong tháng 5";
                    label7.Text = "Tổng doanh thu trong tháng 5";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 5";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 5";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(5) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(5);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(5) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(5);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 6:
                    label6.Text = "Tổng số hóa đơn trong tháng 6";
                    label7.Text = "Tổng doanh thu trong tháng 6";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 6";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 6";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(6) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(6);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(6) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(6);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 7:
                    label6.Text = "Tổng số hóa đơn trong tháng 7";
                    label7.Text = "Tổng doanh thu trong tháng 7";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 7";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 7";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(7) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(7);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(7) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(7);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 8:
                    label6.Text = "Tổng số hóa đơn trong tháng 8";
                    label7.Text = "Tổng doanh thu trong tháng 8";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 8";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 8";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(8) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(8);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(8) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(8);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 9:
                    label6.Text = "Tổng số hóa đơn trong tháng 9";
                    label7.Text = "Tổng doanh thu trong tháng 9";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 9";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 9";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(9) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(9);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(9) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(9);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 10:
                    label6.Text = "Tổng số hóa đơn trong tháng 10";
                    label7.Text = "Tổng doanh thu trong tháng 10";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 10";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 10";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(10) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(10);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(10) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(10);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 11:
                    label6.Text = "Tổng số hóa đơn trong tháng 11";
                    label7.Text = "Tổng doanh thu trong tháng 11";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 11";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 11";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(11) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(11);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(11) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(11);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
                case 12:
                    label6.Text = "Tổng số hóa đơn trong tháng 12";
                    label7.Text = "Tổng doanh thu trong tháng 12";
                    label10.Text = "Thiết bị được đặt nhiều nhất trong tháng 12";
                    label22.Text = "Thiết bị được đặt ít nhất trong tháng 12";
                    label9.Text = tktbbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tktbbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    try
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(12) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhat(12);
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(12) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhat(12);
                    }
                    catch (Exception)
                    {
                        label25.Text = tktbbll.TenThietBiDuocDatNhieuNhat(0) + " số lượng: " + 0;
                        label26.Text = tktbbll.TenThietBiDuocDatItNhat(0) + " số lượng: " + 0;
                    }
                    break;
            }
        }

        
        private void label21_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
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
                    label24.Text = "Thiết bị được đặt nhiều nhất trong quý?";
                    label23.Text = "Thiết bị được đặt ít nhất trong quý?";
                    label16.Text = "Không có dữ liệu, số lượng: 0";
                    label11.Text = "Không có dữ liệu, số lượng: 0";
                    break;
                case 1:
                    label15.Text = "Tổng số hóa đơn trong quý 1";
                    label14.Text = "Tổng doanh thu trong quý 1";
                    label13.Text = tktbbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tktbbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Thiết bị được đặt nhiều nhất trong quý 1";
                    label23.Text = "Thiết bị được đặt ít nhất trong quý 1";
                    try
                    {
                        label16.Text = tktbbll.TenThietBiDuocDatNhieuNhatTheoQuy(1) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhatTheoQuy(1);
                        label11.Text = tktbbll.TenThietBiDuocDatItNhatTheoQuy(1) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhatTheoQuy(1);
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
                    label13.Text = tktbbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tktbbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Thiết bị được đặt nhiều nhất trong quý 2";
                    label23.Text = "Thiết bị được đặt ít nhất trong quý 2";
                    try
                    {
                        label16.Text = tktbbll.TenThietBiDuocDatNhieuNhatTheoQuy(2) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhatTheoQuy(2);
                        label11.Text = tktbbll.TenThietBiDuocDatItNhatTheoQuy(2) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhatTheoQuy(2);
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
                    label13.Text = tktbbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tktbbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Thiết bị được đặt nhiều nhất trong quý 3";
                    label23.Text = "Thiết bị được đặt ít nhất trong quý 3";
                    try
                    {
                        label16.Text = tktbbll.TenThietBiDuocDatNhieuNhatTheoQuy(3) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhatTheoQuy(3);
                        label11.Text = tktbbll.TenThietBiDuocDatItNhatTheoQuy(3) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhatTheoQuy(3);
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
                    label13.Text = tktbbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tktbbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    label24.Text = "Thiết bị được đặt nhiều nhất trong quý 4";
                    label23.Text = "Thiết bị được đặt ít nhất trong quý 4";
                    try
                    {
                        label16.Text = tktbbll.TenThietBiDuocDatNhieuNhatTheoQuy(4) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhatTheoQuy(4);
                        label11.Text = tktbbll.TenThietBiDuocDatItNhatTheoQuy(4) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhatTheoQuy(4);
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
                label29.Text = "Thiết bị được đặt ít nhất trong năm?";
                label30.Text = "Thiết bị được đặt nhiều nhất trong năm?";
            }
            else
            {
                label20.Text = "Tổng số hóa đơn trong năm " + cboNam.Text;
                label19.Text = "Tổng doanh thu trong năm " + cboNam.Text;
                label18.Text = tktbbll.SoLuongHoaDonTheoNam(int.Parse(cboNam.Text)).ToString() + " đơn";
                label17.Text = tktbbll.TongTienTheoNam(int.Parse(cboNam.Text)).ToString("N0") + " đ";
                label29.Text = "Thiết bị được đặt ít nhất trong " + cboNam.Text;
                label30.Text = "Thiết bị được đặt nhiều nhất trong " + cboNam.Text;
                try
                {
                    label28.Text = tktbbll.TenThietBiDuocDatNhieuNhatTheoNam(int.Parse(cboNam.Text)) + " số lượng: " + tktbbll.LaySoLuongThietBiNhieuNhatTheoNam(int.Parse(cboNam.Text));
                    label27.Text = tktbbll.TenThietBiDuocDatItNhatTheoNam(int.Parse(cboNam.Text)) + " số lượng: " + tktbbll.LaySoLuongThietBiItNhatTheoNam(int.Parse(cboNam.Text));
                }
                catch (Exception)
                {
                    label28.Text = "Không có dữ liệu, số lượng: 0";
                    label27.Text = "Không có dữ liệu, số lượng: 0";
                }
            }
        }
    }
}
