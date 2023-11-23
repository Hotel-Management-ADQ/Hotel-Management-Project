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
    public partial class frmBill : Form
    {
        HoaDonBLL hdbll;
        private BindingList<datphong> datahoadon = new BindingList<datphong>();
        public frmBill()
        {
            hdbll = new HoaDonBLL();

            InitializeComponent();
        }

        public void loadtablehoadon()
        {
            List<HoaDonDTO> dataFromDatabase = hdbll.GetHoaDonList();
            tblHoaDon.DataSource = dataFromDatabase;
            tblHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblHoaDon.Columns[1].HeaderText = "Mã Nhân Viên";
            tblHoaDon.Columns[2].HeaderText = "Mã Khách Hàng";
            tblHoaDon.Columns[3].HeaderText = "Mã Phòng";
            tblHoaDon.Columns[4].HeaderText = "Check-In";
            tblHoaDon.Columns[5].HeaderText = "Check-Out";
            tblHoaDon.Columns[6].HeaderText = "Tiền Đặt Cọc";
            tblHoaDon.Columns[7].HeaderText = "Tiền Phòng";
            tblHoaDon.Columns[8].HeaderText = "Phụ Thu Check-In";
            tblHoaDon.Columns[9].HeaderText = "Phụ Thu Check-Out";
            tblHoaDon.Columns[10].HeaderText = "Tổng Tiền Dịch Vụ";
            tblHoaDon.Columns[11].HeaderText = "Tổng Tiền Thiết Bị";
            tblHoaDon.Columns[12].HeaderText = "Tổng Tiền Hóa Đơn";
            tblHoaDon.Columns[13].HeaderText = "Tiền Thanh Toán";
            tblHoaDon.Columns[14].HeaderText = "Số Người Ở";
            tblHoaDon.Columns[15].HeaderText = "Loại Thuê";
            tblHoaDon.Columns[16].HeaderText = "Trạng Thái";

            tblHoaDon.AllowUserToResizeRows = false;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            loadtablehoadon();
        }
        

        private void tblHoaDon_Click(object sender, EventArgs e)
        {
            int i = tblHoaDon.CurrentRow.Index;
            txtTenKH.Text = hdbll.LayTenTuKhachHang(tblHoaDon.Rows[i].Cells[2].Value.ToString());
            dateNgaySinhKH.Value = hdbll.LayNgaySinhTuKhachHang(tblHoaDon.Rows[i].Cells[2].Value.ToString());
        }
    }
}
