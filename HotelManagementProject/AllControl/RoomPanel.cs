using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllControl
{
    public partial class RoomPanel : UserControl
    {
        public RoomPanel(string tenphong, string sotang, string loaiphong, string trangthai)
        {
            InitializeComponent();
            label1.Text.ToUpper();
            label1.Text = tenphong;
            label3.Text = sotang;
            label6.Text = loaiphong;
            label7.Text = trangthai;
            if (trangthai.Equals("Còn trống"))
            {
                tableLayoutPanel1.BackColor = Color.Green;
                tableLayoutPanel1.ForeColor = Color.White;
            }
            else if (trangthai.Equals("Đang sử dụng"))
            {
                tableLayoutPanel1.BackColor = Color.Red;
                tableLayoutPanel1.ForeColor = Color.White;
            }
        }

        private Color borderColor;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

    }
}
