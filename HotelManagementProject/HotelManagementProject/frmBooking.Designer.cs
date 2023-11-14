namespace HotelManagementProject
{
    partial class frmBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.layoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.currentTimeLabelApp1 = new AllControl.CurrentTimeLabelApp();
            this.currentDateLabelApp1 = new AllControl.CurrentDateLabelApp();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCCCD = new AllControl.TextBoxForIdentificationCard();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoNguoiO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDatCoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoaiThue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSoTienDatCoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDHoaDonBookingForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPhieuDatPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutContainer.SuspendLayout();
            this.layoutHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuDatPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutContainer
            // 
            this.layoutContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.layoutContainer.ColumnCount = 1;
            this.layoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutContainer.Controls.Add(this.layoutHeader, 0, 0);
            this.layoutContainer.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.layoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContainer.Location = new System.Drawing.Point(0, 0);
            this.layoutContainer.Name = "layoutContainer";
            this.layoutContainer.RowCount = 2;
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.2529F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.7471F));
            this.layoutContainer.Size = new System.Drawing.Size(1917, 1082);
            this.layoutContainer.TabIndex = 1;
            // 
            // layoutHeader
            // 
            this.layoutHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutHeader.BackColor = System.Drawing.Color.Green;
            this.layoutHeader.ColumnCount = 3;
            this.layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHeader.Controls.Add(this.currentTimeLabelApp1, 2, 0);
            this.layoutHeader.Controls.Add(this.currentDateLabelApp1, 0, 0);
            this.layoutHeader.Controls.Add(this.lblTenNhanVien, 1, 1);
            this.layoutHeader.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.layoutHeader.Location = new System.Drawing.Point(3, 3);
            this.layoutHeader.Name = "layoutHeader";
            this.layoutHeader.RowCount = 2;
            this.layoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutHeader.Size = new System.Drawing.Size(1911, 115);
            this.layoutHeader.TabIndex = 0;
            // 
            // currentTimeLabelApp1
            // 
            this.currentTimeLabelApp1.AutoSize = true;
            this.currentTimeLabelApp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTimeLabelApp1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabelApp1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentTimeLabelApp1.Location = new System.Drawing.Point(1531, 0);
            this.currentTimeLabelApp1.Name = "currentTimeLabelApp1";
            this.currentTimeLabelApp1.Size = new System.Drawing.Size(377, 69);
            this.currentTimeLabelApp1.TabIndex = 1;
            this.currentTimeLabelApp1.Text = "15:08:17";
            this.currentTimeLabelApp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentDateLabelApp1
            // 
            this.currentDateLabelApp1.AutoSize = true;
            this.currentDateLabelApp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentDateLabelApp1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabelApp1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentDateLabelApp1.Location = new System.Drawing.Point(3, 0);
            this.currentDateLabelApp1.Name = "currentDateLabelApp1";
            this.currentDateLabelApp1.Size = new System.Drawing.Size(376, 69);
            this.currentDateLabelApp1.TabIndex = 2;
            this.currentDateLabelApp1.Text = "14/11/2023";
            this.currentDateLabelApp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTenNhanVien.Location = new System.Drawing.Point(385, 69);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(1140, 46);
            this.lblTenNhanVien.TabIndex = 3;
            this.lblTenNhanVien.Text = "label2";
            this.lblTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTenPhong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGiaTien, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(385, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 63);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.Yellow;
            this.lblTenPhong.Location = new System.Drawing.Point(3, 0);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(564, 63);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = "label1";
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGiaTien.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.Crimson;
            this.lblGiaTien.Location = new System.Drawing.Point(573, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(564, 63);
            this.lblGiaTien.TabIndex = 1;
            this.lblGiaTien.Text = "label1";
            this.lblGiaTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 124);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1911, 955);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.24037F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.75963F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1525, 949);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtSoNguoiO);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDatCoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboLoaiThue);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblSoTienDatCoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIDHoaDonBookingForm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNhanVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTimKiemKH);
            this.panel1.Controls.Add(this.cboKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 214);
            this.panel1.TabIndex = 0;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(448, 57);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(235, 25);
            this.txtCCCD.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1252, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 25);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1252, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 25);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(1248, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 23);
            this.label15.TabIndex = 29;
            this.label15.Text = "0 Ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1130, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Check-Out";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1130, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tổng thời giờ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1130, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Check-In";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(1300, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Trạng thái hóa đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1130, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Trạng Thái Hóa Đơn";
            // 
            // txtSoNguoiO
            // 
            this.txtSoNguoiO.Enabled = false;
            this.txtSoNguoiO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoiO.Location = new System.Drawing.Point(850, 52);
            this.txtSoNguoiO.Name = "txtSoNguoiO";
            this.txtSoNguoiO.Size = new System.Drawing.Size(235, 25);
            this.txtSoNguoiO.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(728, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Số Người Ở";
            // 
            // txtDatCoc
            // 
            this.txtDatCoc.Enabled = false;
            this.txtDatCoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatCoc.Location = new System.Drawing.Point(850, 92);
            this.txtDatCoc.Name = "txtDatCoc";
            this.txtDatCoc.Size = new System.Drawing.Size(235, 25);
            this.txtDatCoc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(728, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đặt Cọc";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(448, 172);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(235, 25);
            this.txtLoaiPhong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Loại Phòng";
            // 
            // cboLoaiThue
            // 
            this.cboLoaiThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiThue.FormattingEnabled = true;
            this.cboLoaiThue.Items.AddRange(new object[] {
            "Theo Ngày",
            "Theo Giờ"});
            this.cboLoaiThue.Location = new System.Drawing.Point(850, 14);
            this.cboLoaiThue.Name = "cboLoaiThue";
            this.cboLoaiThue.Size = new System.Drawing.Size(235, 25);
            this.cboLoaiThue.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(728, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Loại Thuê";
            // 
            // lblSoTienDatCoc
            // 
            this.lblSoTienDatCoc.AutoSize = true;
            this.lblSoTienDatCoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienDatCoc.ForeColor = System.Drawing.Color.Crimson;
            this.lblSoTienDatCoc.Location = new System.Drawing.Point(908, 129);
            this.lblSoTienDatCoc.Name = "lblSoTienDatCoc";
            this.lblSoTienDatCoc.Size = new System.Drawing.Size(60, 23);
            this.lblSoTienDatCoc.TabIndex = 10;
            this.lblSoTienDatCoc.Text = "0 VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Tiền Phải Đặt Cọc:";
            // 
            // txtIDHoaDonBookingForm
            // 
            this.txtIDHoaDonBookingForm.Enabled = false;
            this.txtIDHoaDonBookingForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHoaDonBookingForm.Location = new System.Drawing.Point(448, 132);
            this.txtIDHoaDonBookingForm.Name = "txtIDHoaDonBookingForm";
            this.txtIDHoaDonBookingForm.Size = new System.Drawing.Size(235, 25);
            this.txtIDHoaDonBookingForm.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Hóa Đơn";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(448, 95);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(235, 25);
            this.txtNhanVien.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhân Viên";
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKH.Location = new System.Drawing.Point(330, 52);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(87, 30);
            this.btnTimKiemKH.TabIndex = 4;
            this.btnTimKiemKH.Text = "Tìm Kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(448, 15);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(235, 25);
            this.cboKhachHang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng Đặt Phòng";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.03292F));
            this.tableLayoutPanel4.Controls.Add(this.tblPhieuDatPhong, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.53719F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.46281F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1519, 723);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tblPhieuDatPhong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tblPhieuDatPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPhieuDatPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPhieuDatPhong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPhieuDatPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblPhieuDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPhieuDatPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblPhieuDatPhong.Location = new System.Drawing.Point(3, 3);
            this.tblPhieuDatPhong.Name = "tblPhieuDatPhong";
            this.tblPhieuDatPhong.RowHeadersVisible = false;
            this.tblPhieuDatPhong.Size = new System.Drawing.Size(1513, 209);
            this.tblPhieuDatPhong.TabIndex = 0;
            this.tblPhieuDatPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblPhieuDatPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPhieuDatPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblPhieuDatPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblPhieuDatPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblPhieuDatPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblPhieuDatPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblPhieuDatPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tblPhieuDatPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblPhieuDatPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPhieuDatPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblPhieuDatPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblPhieuDatPhong.ThemeStyle.HeaderStyle.Height = 35;
            this.tblPhieuDatPhong.ThemeStyle.ReadOnly = false;
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.Height = 22;
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblPhieuDatPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1534, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 949);
            this.panel2.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(16, 116);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(197, 20);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(16, 77);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(197, 20);
            this.textBox11.TabIndex = 10;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(16, 39);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(197, 20);
            this.textBox12.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1513, 112);
            this.panel3.TabIndex = 1;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1082);
            this.Controls.Add(this.layoutContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBooking";
            this.layoutContainer.ResumeLayout(false);
            this.layoutHeader.ResumeLayout(false);
            this.layoutHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuDatPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutContainer;
        private System.Windows.Forms.TableLayoutPanel layoutHeader;
        private AllControl.CurrentTimeLabelApp currentTimeLabelApp1;
        private AllControl.CurrentDateLabelApp currentDateLabelApp1;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDHoaDonBookingForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoNguoiO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaiThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSoTienDatCoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private AllControl.TextBoxForIdentificationCard txtCCCD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2DataGridView tblPhieuDatPhong;
        private System.Windows.Forms.Panel panel3;
    }
}