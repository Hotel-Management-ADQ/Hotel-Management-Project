using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagementProject
{
    public partial class frmStaff : Form
    {

        NhanVienBLL nvbll;
        private BindingList<nhanvien> datathietbi = new BindingList<nhanvien>();
        public frmStaff()
        {
            InitializeComponent();
            nvbll = new NhanVienBLL();

        }

        public void LoadTableNhanVien()
        {
            List<nhanvien> dataFromDatabase = nvbll.GetNhanVienList();
            tblNhanVien.DataSource = dataFromDatabase;
            tblNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            tblNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            tblNhanVien.Columns[2].HeaderText = "Ngày Sinh";
            tblNhanVien.Columns[3].HeaderText = "Số Điện Thoại";
            tblNhanVien.Columns[4].HeaderText = "Giới Tính";
            tblNhanVien.Columns[5].HeaderText = "Email";
            tblNhanVien.Columns[6].HeaderText = "Hình Ảnh";

            tblNhanVien.AllowUserToResizeRows = false;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadTableNhanVien();
        }

        private void tblNhanVien_Click(object sender, EventArgs e)
        {
            if (tblNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tblNhanVien.SelectedRows[0];
                txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
                NgaySinhNV.Text = selectedRow.Cells[2].Value.ToString();
                txtSdtNV.Text = selectedRow.Cells[3].Value.ToString();
                string gioiTinh = selectedRow.Cells[4].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdNam.Checked = true;

                }
                if (gioiTinh == "Nữ")
                {
            
                    rdNu.Checked = true;
                }
                

                txtEmailNV.Text = selectedRow.Cells[5].Value.ToString();
                txtHinhAnhNV.Text = selectedRow.Cells[6].Value.ToString();
            }
        }




        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int i = tblNhanVien.CurrentRow.Index;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nvbll.XoaNhanVien(tblNhanVien.Rows[i].Cells[0].Value.ToString().Trim());
                LoadTableNhanVien();
            }
            txtTenNV.Text = string.Empty;
            txtSdtNV.Text = string.Empty;
            txtEmailNV.Text = string.Empty;
            txtHinhAnhNV.Text = string.Empty;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            txtTenNV.Text = string.Empty;
            txtSdtNV.Text = string.Empty;
            NgaySinhNV.Value = DateTime.Now;
            rdNam.Checked = true;
            txtEmailNV.Text = string.Empty;
            txtHinhAnhNV.Text = string.Empty;
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật lại nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int i = tblNhanVien.CurrentRow.Index;
            if (result == DialogResult.Yes)
            {
                if(rdNu.Checked) {
                nvbll.CapNhatNhanVien(tblNhanVien.Rows[i].Cells[0].Value.ToString().Trim(), txtTenNV.Text.Trim(), NgaySinhNV.Value,  txtSdtNV.Text.Trim(), rdNu.Text, txtEmailNV.Text.Trim(), txtHinhAnhNV.Text.Trim());
                LoadTableNhanVien(); 
                }
                
                if (rdNam.Checked) {
                    nvbll.CapNhatNhanVien(tblNhanVien.Rows[i].Cells[0].Value.ToString().Trim(), txtTenNV.Text.Trim(), NgaySinhNV.Value,  txtSdtNV.Text.Trim(), rdNam.Text, txtEmailNV.Text.Trim(), txtHinhAnhNV.Text.Trim());
                    LoadTableNhanVien();
                }

            }
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm = new FrmMain();
            Program.mainForm.Show();
        }
    }
}
