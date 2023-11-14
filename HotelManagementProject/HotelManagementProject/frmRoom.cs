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
using DTO;

namespace HotelManagementProject
{
    public partial class frmRoom : Form
    {
        PhongBLL pbll;
        private BindingList<phong> dataphong = new BindingList<phong>();

        public frmRoom()
        {
            pbll = new PhongBLL();
            InitializeComponent();
        }



        private void frmRoom_Load(object sender, EventArgs e)
        {
            LoadTablePhong();
        }

        public void LoadTablePhong()
        {
            List<PhongDTO1> dataFromDatabase = pbll.GetPhongDTO1();
            tblPhong.DataSource = dataFromDatabase;
            tblPhong.Columns[0].HeaderText = "ID Phòng";
            tblPhong.Columns[1].HeaderText = "ID Loại Phòng";
            tblPhong.Columns[2].HeaderText = "ID Tầng";
            tblPhong.Columns[3].HeaderText = "Tên Phòng";
            tblPhong.Columns[4].HeaderText = "Trạng Thái";
            tblPhong.Columns[5].HeaderText = "Giá";

            tblPhong.AllowUserToResizeRows = false;
        }
        
    }
}
