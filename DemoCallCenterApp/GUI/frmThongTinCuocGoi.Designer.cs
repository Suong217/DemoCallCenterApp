namespace DemoCallCenterApp
{
    partial class frmThongTinCuocGoi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboThanhPho = new System.Windows.Forms.ComboBox();
            this.cboQuan = new System.Windows.Forms.ComboBox();
            this.cboPhuong = new System.Windows.Forms.ComboBox();
            this.cboDuong = new System.Windows.Forms.ComboBox();
            this.txtSoNha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdGiaRe = new System.Windows.Forms.RadioButton();
            this.rdVIP = new System.Windows.Forms.RadioButton();
            this.rd7Cho = new System.Windows.Forms.RadioButton();
            this.rd4Cho = new System.Windows.Forms.RadioButton();
            this.lstDiaChiDiNhieuNhat = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lstCuocGoiGanNhat = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDieuPhoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ đón";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboThanhPho);
            this.groupBox1.Controls.Add(this.cboQuan);
            this.groupBox1.Controls.Add(this.cboPhuong);
            this.groupBox1.Controls.Add(this.cboDuong);
            this.groupBox1.Controls.Add(this.txtSoNha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(420, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cboThanhPho
            // 
            this.cboThanhPho.FormattingEnabled = true;
            this.cboThanhPho.Items.AddRange(new object[] {
            "TPHCM"});
            this.cboThanhPho.Location = new System.Drawing.Point(102, 271);
            this.cboThanhPho.Name = "cboThanhPho";
            this.cboThanhPho.Size = new System.Drawing.Size(313, 28);
            this.cboThanhPho.TabIndex = 2;
            // 
            // cboQuan
            // 
            this.cboQuan.FormattingEnabled = true;
            this.cboQuan.Items.AddRange(new object[] {
            "Bình Thành",
            "Quận 1",
            "Quận 3",
            "Phú Nhuận",
            "Quận 5",
            "Tân Bình"});
            this.cboQuan.Location = new System.Drawing.Point(102, 229);
            this.cboQuan.Name = "cboQuan";
            this.cboQuan.Size = new System.Drawing.Size(313, 28);
            this.cboQuan.TabIndex = 2;
            // 
            // cboPhuong
            // 
            this.cboPhuong.FormattingEnabled = true;
            this.cboPhuong.Items.AddRange(new object[] {
            "Phường 1",
            "Phường 2",
            "Phường 3",
            "Phường 4"});
            this.cboPhuong.Location = new System.Drawing.Point(102, 188);
            this.cboPhuong.Name = "cboPhuong";
            this.cboPhuong.Size = new System.Drawing.Size(313, 28);
            this.cboPhuong.TabIndex = 2;
            this.cboPhuong.SelectedIndexChanged += new System.EventHandler(this.cboPhuong_SelectedIndexChanged);
            // 
            // cboDuong
            // 
            this.cboDuong.FormattingEnabled = true;
            this.cboDuong.Items.AddRange(new object[] {
            "Trần Phú",
            "Lê Hồng Phong",
            "Điện Biên Phủ",
            "Hai Bà Trưng",
            "Nguyễn Thị Minh Khai",
            "Lê Văn Sỹ"});
            this.cboDuong.Location = new System.Drawing.Point(103, 149);
            this.cboDuong.Name = "cboDuong";
            this.cboDuong.Size = new System.Drawing.Size(313, 28);
            this.cboDuong.TabIndex = 2;
            // 
            // txtSoNha
            // 
            this.txtSoNha.Location = new System.Drawing.Point(103, 107);
            this.txtSoNha.Name = "txtSoNha";
            this.txtSoNha.Size = new System.Drawing.Size(313, 27);
            this.txtSoNha.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành phố";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phường";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số nhà";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(103, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(313, 27);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "SDT";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(103, 31);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(313, 27);
            this.txtTenKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdGiaRe);
            this.groupBox2.Controls.Add(this.rdVIP);
            this.groupBox2.Controls.Add(this.rd7Cho);
            this.groupBox2.Controls.Add(this.rd4Cho);
            this.groupBox2.Location = new System.Drawing.Point(420, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại xe";
            // 
            // rdGiaRe
            // 
            this.rdGiaRe.AutoSize = true;
            this.rdGiaRe.Location = new System.Drawing.Point(303, 24);
            this.rdGiaRe.Name = "rdGiaRe";
            this.rdGiaRe.Size = new System.Drawing.Size(89, 24);
            this.rdGiaRe.TabIndex = 0;
            this.rdGiaRe.Tag = "2";
            this.rdGiaRe.Text = "Xe giá rẻ";
            this.rdGiaRe.UseVisualStyleBackColor = true;
            // 
            // rdVIP
            // 
            this.rdVIP.AutoSize = true;
            this.rdVIP.Location = new System.Drawing.Point(231, 24);
            this.rdVIP.Name = "rdVIP";
            this.rdVIP.Size = new System.Drawing.Size(51, 24);
            this.rdVIP.TabIndex = 0;
            this.rdVIP.Tag = "1";
            this.rdVIP.Text = "VIP";
            this.rdVIP.UseVisualStyleBackColor = true;
            // 
            // rd7Cho
            // 
            this.rd7Cho.AutoSize = true;
            this.rd7Cho.Location = new System.Drawing.Point(84, 24);
            this.rd7Cho.Name = "rd7Cho";
            this.rd7Cho.Size = new System.Drawing.Size(66, 24);
            this.rd7Cho.TabIndex = 0;
            this.rd7Cho.Tag = "7";
            this.rd7Cho.Text = "7 chỗ";
            this.rd7Cho.UseVisualStyleBackColor = true;
            // 
            // rd4Cho
            // 
            this.rd4Cho.AutoSize = true;
            this.rd4Cho.Checked = true;
            this.rd4Cho.Location = new System.Drawing.Point(12, 24);
            this.rd4Cho.Name = "rd4Cho";
            this.rd4Cho.Size = new System.Drawing.Size(66, 24);
            this.rd4Cho.TabIndex = 0;
            this.rd4Cho.TabStop = true;
            this.rd4Cho.Tag = "4";
            this.rd4Cho.Text = "4 chỗ";
            this.rd4Cho.UseVisualStyleBackColor = true;
            // 
            // lstDiaChiDiNhieuNhat
            // 
            this.lstDiaChiDiNhieuNhat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDiaChiDiNhieuNhat.FullRowSelect = true;
            this.lstDiaChiDiNhieuNhat.GridLines = true;
            this.lstDiaChiDiNhieuNhat.Location = new System.Drawing.Point(12, 80);
            this.lstDiaChiDiNhieuNhat.MultiSelect = false;
            this.lstDiaChiDiNhieuNhat.Name = "lstDiaChiDiNhieuNhat";
            this.lstDiaChiDiNhieuNhat.Size = new System.Drawing.Size(402, 352);
            this.lstDiaChiDiNhieuNhat.TabIndex = 3;
            this.lstDiaChiDiNhieuNhat.UseCompatibleStateImageBehavior = false;
            this.lstDiaChiDiNhieuNhat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DiaChiDon";
            this.columnHeader2.Width = 250;
            // 
            // lstCuocGoiGanNhat
            // 
            this.lstCuocGoiGanNhat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstCuocGoiGanNhat.FullRowSelect = true;
            this.lstCuocGoiGanNhat.GridLines = true;
            this.lstCuocGoiGanNhat.Location = new System.Drawing.Point(12, 473);
            this.lstCuocGoiGanNhat.MultiSelect = false;
            this.lstCuocGoiGanNhat.Name = "lstCuocGoiGanNhat";
            this.lstCuocGoiGanNhat.Size = new System.Drawing.Size(830, 148);
            this.lstCuocGoiGanNhat.TabIndex = 4;
            this.lstCuocGoiGanNhat.UseCompatibleStateImageBehavior = false;
            this.lstCuocGoiGanNhat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STT";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ThoiGian";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DiaChiDon";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "LoaiXe";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TrangThai";
            this.columnHeader7.Width = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Các địa chỉ đi nhiều nhất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Các cuộc gọi gần nhất";
            // 
            // btnDieuPhoi
            // 
            this.btnDieuPhoi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDieuPhoi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDieuPhoi.Location = new System.Drawing.Point(355, 637);
            this.btnDieuPhoi.Name = "btnDieuPhoi";
            this.btnDieuPhoi.Size = new System.Drawing.Size(143, 63);
            this.btnDieuPhoi.TabIndex = 5;
            this.btnDieuPhoi.Text = "Điều phối";
            this.btnDieuPhoi.UseVisualStyleBackColor = true;
            this.btnDieuPhoi.Click += new System.EventHandler(this.btnDieuPhoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(639, 660);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongTinCuocGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 720);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDieuPhoi);
            this.Controls.Add(this.lstCuocGoiGanNhat);
            this.Controls.Add(this.lstDiaChiDiNhieuNhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "frmThongTinCuocGoi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboThanhPho;
        private ComboBox cboQuan;
        private ComboBox cboPhuong;
        private ComboBox cboDuong;
        private TextBox txtSoNha;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtTenKH;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rdGiaRe;
        private RadioButton rdVIP;
        private RadioButton rd7Cho;
        private RadioButton rd4Cho;
        private ListView lstDiaChiDiNhieuNhat;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView lstCuocGoiGanNhat;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label9;
        private Label label10;
        private Button btnDieuPhoi;
        private Button btnThoat;
    }
}