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
    public partial class frmService : Form
    {
        DichVuBLL dvbll;
        private BindingList<dichvu> datadichvu = new BindingList<dichvu>();


        public frmService()
        {
            InitializeComponent();
            dvbll = new DichVuBLL();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            LoadTableDichVu();
        }

        public void LoadTableDichVu()
        {
            List<dichvu> dataFromDatabase = dvbll.GetDichVuList();
            tblDichVu.DataSource = dataFromDatabase;
            tblDichVu.Columns[0].HeaderText = "Mã Dịch Vụ";
            tblDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            tblDichVu.Columns[2].HeaderText = "Giá";

            tblDichVu.AllowUserToResizeRows = false;
        }

        private void tblDichVu_Click(object sender, EventArgs e)
        {
            if (tblDichVu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tblDichVu.SelectedRows[0];
                txtTenDichVu.Text = selectedRow.Cells[1].Value.ToString();
                txtGiaDichVu.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenDichVu.Enabled = true; txtGiaDichVu.Enabled = true;
            txtGiaDichVu.Text = string.Empty; txtTenDichVu.Text = string.Empty;
            txtTenDichVu.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = tblDichVu.CurrentRow.Index;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dvbll.XoaDichVu(tblDichVu.Rows[i].Cells[0].Value.ToString().Trim());
                LoadTableDichVu();
            }
            //MessageBox.Show(tblDichVu.Rows[i].Cells[0].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dvbll.ThemDichVu(txtTenDichVu.Text.Trim(), int.Parse(txtGiaDichVu.Text.Trim()));
                LoadTableDichVu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật lại dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int i = tblDichVu.CurrentRow.Index;
            if (result == DialogResult.Yes)
            {
                dvbll.CapNhatDichVu(tblDichVu.Rows[i].Cells[0].Value.ToString().Trim(), txtTenDichVu.Text.Trim(), int.Parse(txtGiaDichVu.Text.Trim()));
                LoadTableDichVu();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtNhapTimKiem.Text.Trim().Equals(""))
                LoadTableDichVu();
            else
            {
                List<dichvu> lstTimKiem = dvbll.TimKiemDichVu(txtNhapTimKiem.Text.Trim());
                if (lstTimKiem.Count > 0)
                {
                    tblDichVu.DataSource = lstTimKiem;
                }
                else
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.serviceForm = new frmService();
            Program.serviceForm.Show();
        }
    }
}
