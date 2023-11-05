using BLL;
using DAL;
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
    public partial class frmMain : Form
    {
        PhongBLL phongBLL;
        public frmMain()
        {
            InitializeComponent();
            phongBLL = new PhongBLL();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DesignLayoutFormMain();
        }

        private void DesignLayoutFormMain()
        {

            List<phong> phongList = phongBLL.GetPhongList();
            foreach (phong phong in phongList)
            {
                Button phongButton = new Button();
                phongButton.Text = phong.id_phong + "\nPhòng: " + phong.ten + "\nTầng: " + phong.id_tang;
                panel2.Controls.Add(phongButton);
            }
        }
    }
}
