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
    public partial class frmLogin : Form
    {
        private Timer opacityTimer = new Timer();
        public frmLogin()
        {
            InitializeComponent();
            this.Opacity = 0;
            opacityTimer.Interval = 5;
            opacityTimer.Tick += new EventHandler(OnTimerTick);
            opacityTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.05;
            }
            else
            {
                opacityTimer.Stop();
            }
        }

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
    }
}
