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
    public partial class frmLogin : Form
    {
        //private Timer opacityTimer = new Timer();
        public frmLogin()
        {
            InitializeComponent();
            //this.Opacity = 0;
            //opacityTimer.Interval = 5;
            //opacityTimer.Tick += new EventHandler(OnTimerTick);
            //opacityTimer.Start();
        }

        //private void OnTimerTick(object sender, EventArgs e)
        //{
        //    if (this.Opacity < 1.0)
        //    {
        //        this.Opacity += 0.05;
        //    }
        //    else
        //    {
        //        opacityTimer.Stop();
        //    }
        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void picVisible_Click(object sender, EventArgs e)
        {
            picHidden.Visible = true;
            picVisible.Visible = false;
            txtPassword.PasswordChar = '\0';
        }

        private void picHidden_Click(object sender, EventArgs e)
        {
            picHidden.Visible = false;
            picVisible.Visible = true;
            txtPassword.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //TaiKhoanBLL tk = new TaiKhoanBLL();
            //if (tk.CheckTaiKhoanTonTai(txtUsername.Text))
            //{
            //    if (tk.CheckHoatDong(txtUsername.Text) == 0)
            //    {
            //        MessageBox.Show("Tài khoản đã bị khóa");
            //    }
            //    else
            //    {
            //        string username = tk.GetTenDangNhap(txtUsername.Text.Trim());
            //        string password = tk.GetMatKhau(txtUsername.Text.Trim());

            //        if (!(username.Equals(txtUsername.Text.Trim()) && password.Equals(txtPassword.Text.Trim())))
            //        {
            //            MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //else
            //    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TaiKhoanBLL tk = new TaiKhoanBLL();
            if (tk.CheckHoatDong(txtUsername.Text) == 0)
            {
                MessageBox.Show("Tài khoản đã bị khóa");
            }
            else
            {
                string username = tk.GetTenDangNhap(txtUsername.Text.Trim());
                string password = tk.GetMatKhau(txtUsername.Text.Trim());

                if (!(username.Equals(txtUsername.Text.Trim()) && password.Equals(txtPassword.Text.Trim())))
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.mainForm = new frmMain();
                    Program.mainForm.Show();
                    this.Visible = false;
                }
            }
        }
    }
}
