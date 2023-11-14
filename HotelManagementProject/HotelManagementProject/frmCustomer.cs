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
using BLL;

namespace HotelManagementProject
{

    public partial class frmCustomer : Form
    {
        KhachHangBLL khbll;
        private BindingList<khachhang> datakhachhang = new BindingList<khachhang>();

        public frmCustomer()
        {
            khbll = new KhachHangBLL();
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadTableKhachHang();
            rdNam.Checked = true;
        }

        public void LoadTableKhachHang()
        {
            List<khachhang> dataFromDatabase = khbll.GetKhachHangList();
            tblKhachHang.DataSource = dataFromDatabase;
            tblKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            tblKhachHang.Columns[1].HeaderText = "Tên Khách Hang";
            tblKhachHang.Columns[2].HeaderText = "Ngày Sinh";
            tblKhachHang.Columns[3].HeaderText = "Địa chỉ";
            tblKhachHang.Columns[4].HeaderText = "Số điện thoại";
            tblKhachHang.Columns[5].HeaderText = "CMND";
            tblKhachHang.Columns[6].HeaderText = "Giới tính";

            tblKhachHang.AllowUserToResizeRows = false;
        }


        private void tblKhachHang_Click(object sender, EventArgs e)
        {
            if (tblKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tblKhachHang.SelectedRows[0];
                txtTen.Text = selectedRow.Cells[1].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells[2].Value);
                dateNgaySinh.Text = ngaySinh.ToShortDateString(); txtDiaChi.Text = selectedRow.Cells[3].Value.ToString();
                txtSdt.Text = selectedRow.Cells[4].Value.ToString();
                txtCmnd.Text = selectedRow.Cells[5].Value.ToString();

                string gioiTinh = selectedRow.Cells[6].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdNam.Checked = false;
                    rdNu.Checked = true;
                }
                else
                {
                    rdNam.Checked = false;
                    rdNu.Checked = false;
                }
            }
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtTen.Enabled = true; dateNgaySinh.Enabled = true; txtDiaChi.Enabled = true; txtSdt.Enabled = true; txtCmnd.Enabled = true;
            txtTen.Text = string.Empty; dateNgaySinh.Text = string.Empty; txtDiaChi.Text = string.Empty; txtSdt.Text = string.Empty; txtCmnd.Text = string.Empty;
            txtTen.Focus();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int i = tblKhachHang.CurrentRow.Index;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                khbll.XoaKhachHang(tblKhachHang.Rows[i].Cells[0].Value.ToString().Trim());
                LoadTableKhachHang();
            }
            txtTen.Text = string.Empty; dateNgaySinh.Text = string.Empty; txtDiaChi.Text = string.Empty; txtSdt.Text = string.Empty; txtCmnd.Text = string.Empty;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (rdNam.Checked)
                {
                    khbll.ThemKhachHang(txtTen.Text.Trim(), DateTime.Parse(dateNgaySinh.Text.Trim()), txtDiaChi.Text.Trim(), txtSdt.Text.Trim(), txtCmnd.Text.Trim(), rdNam.Text);

                }
                else if (rdNu.Checked)
                {
                    khbll.ThemKhachHang(txtTen.Text.Trim(), DateTime.Parse(dateNgaySinh.Text.Trim()), txtDiaChi.Text.Trim(), txtSdt.Text.Trim(), txtCmnd.Text.Trim(), rdNu.Text);

                }
                LoadTableKhachHang();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật lại khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int i = tblKhachHang.CurrentRow.Index;
            if (result == DialogResult.Yes)
            {
                khbll.CapNhatKhachHang(tblKhachHang.Rows[i].Cells[0].Value.ToString().Trim(), txtTen.Text.Trim(), DateTime.Parse(dateNgaySinh.Text.Trim()), txtDiaChi.Text.Trim(), txtSdt.Text.Trim(), txtCmnd.Text.Trim(), rdNu.Text);
                LoadTableKhachHang();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtNhapTimKiem.Text.Trim().Equals(""))
                LoadTableKhachHang();
            else
            {
                List<khachhang> lstTimKiem = khbll.TimKiemKhachHang(txtNhapTimKiem.Text.Trim());
                if (lstTimKiem.Count > 0)
                {
                    tblKhachHang.DataSource = lstTimKiem;
                }
                else
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.customerForm = new frmCustomer();
            Program.customerForm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }
    }
}
