
namespace QLCHMP.Interface
{
    partial class frmBCTK_TongChi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCTK_TongChi));
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.panelThoiGian = new System.Windows.Forms.Panel();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.chartChiTieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLuu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelDoanhThu = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBC = new System.Windows.Forms.Button();
            this.panelThoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiTieu)).BeginInit();
            this.btnLuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Checked = true;
            this.radioButtonNam.ForeColor = System.Drawing.Color.White;
            this.radioButtonNam.Location = new System.Drawing.Point(3, 2);
            this.radioButtonNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(58, 21);
            this.radioButtonNam.TabIndex = 22;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Năm";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // panelThoiGian
            // 
            this.panelThoiGian.Controls.Add(this.radioButtonThang);
            this.panelThoiGian.Controls.Add(this.radioButtonNam);
            this.panelThoiGian.Location = new System.Drawing.Point(483, 89);
            this.panelThoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThoiGian.Name = "panelThoiGian";
            this.panelThoiGian.Size = new System.Drawing.Size(236, 26);
            this.panelThoiGian.TabIndex = 53;
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.ForeColor = System.Drawing.Color.White;
            this.radioButtonThang.Location = new System.Drawing.Point(119, 2);
            this.radioButtonThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(70, 21);
            this.radioButtonThang.TabIndex = 23;
            this.radioButtonThang.Text = "Tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(737, 89);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(98, 25);
            this.btnHienThi.TabIndex = 52;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // chartChiTieu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChiTieu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChiTieu.Legends.Add(legend1);
            this.chartChiTieu.Location = new System.Drawing.Point(35, 118);
            this.chartChiTieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartChiTieu.Name = "chartChiTieu";
            this.chartChiTieu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Tổng chi tiêu";
            this.chartChiTieu.Series.Add(series1);
            this.chartChiTieu.Size = new System.Drawing.Size(829, 625);
            this.chartChiTieu.TabIndex = 51;
            this.chartChiTieu.Text = "chart1";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLuu.Controls.Add(this.label4);
            this.btnLuu.Controls.Add(this.btnReset);
            this.btnLuu.Controls.Add(this.labelDoanhThu);
            this.btnLuu.Controls.Add(this.dateTimePickerEnd);
            this.btnLuu.Controls.Add(this.dateTimePickerStart);
            this.btnLuu.Controls.Add(this.dgvSanPham);
            this.btnLuu.Controls.Add(this.label5);
            this.btnLuu.Controls.Add(this.label2);
            this.btnLuu.Controls.Add(this.btnSearch);
            this.btnLuu.Controls.Add(this.label6);
            this.btnLuu.Location = new System.Drawing.Point(869, 78);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(831, 665);
            this.btnLuu.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(624, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "VNĐ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(698, 8);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 27);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Chọn tất cả";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelDoanhThu
            // 
            this.labelDoanhThu.AutoSize = true;
            this.labelDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoanhThu.ForeColor = System.Drawing.Color.White;
            this.labelDoanhThu.Location = new System.Drawing.Point(443, 622);
            this.labelDoanhThu.Name = "labelDoanhThu";
            this.labelDoanhThu.Size = new System.Drawing.Size(153, 29);
            this.labelDoanhThu.TabIndex = 4;
            this.labelDoanhThu.Text = "000,000,000";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(380, 10);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerEnd.TabIndex = 22;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(84, 9);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerStart.TabIndex = 20;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.NgayBan,
            this.TenKH,
            this.TongTien,
            this.Column1});
            this.dgvSanPham.Location = new System.Drawing.Point(-1, 39);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 30;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvSanPham.Size = new System.Drawing.Size(830, 569);
            this.dgvSanPham.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaSP";
            this.MaHD.HeaderText = "Mã SP";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 170;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaLoaiSP";
            this.MaNV.HeaderText = "Mã loại SP";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 170;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "TenSP";
            this.NgayBan.HeaderText = "Tên SP";
            this.NgayBan.MinimumWidth = 8;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 180;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "SoLuong";
            this.TenKH.HeaderText = "Số lượng";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 170;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "NhaCungCap";
            this.TongTien.HeaderText = "Nhà cung cấp";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 180;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TongChiTieu";
            this.Column1.HeaderText = "Chi Tiêu";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "TỔNG CHI TIÊU";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(598, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 26);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(303, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "BÁO CÁO CHI TIÊU";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnThoat.Location = new System.Drawing.Point(1568, 763);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 50);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnInBC.Location = new System.Drawing.Point(869, 763);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(131, 50);
            this.btnInBC.TabIndex = 49;
            this.btnInBC.Text = "In báo báo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // frmBCTK_TongChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.panelThoiGian);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.chartChiTieu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInBC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBCTK_TongChi";
            this.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBCTK_TongChi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCTK_TongChi_Load);
            this.panelThoiGian.ResumeLayout(false);
            this.panelThoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiTieu)).EndInit();
            this.btnLuu.ResumeLayout(false);
            this.btnLuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.Panel panelThoiGian;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiTieu;
        private System.Windows.Forms.Panel btnLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelDoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}