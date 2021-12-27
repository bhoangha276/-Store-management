
namespace QLCHMP.Interface
{
    partial class frmBCTK_NhanVien
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
            System.Windows.Forms.Button btnInBC;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCTK_NhanVien));
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartNhanVien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            btnInBC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhanVien.Location = new System.Drawing.Point(860, 92);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 30;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(830, 625);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "DiaChi";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DoanhThu";
            this.Column6.HeaderText = "Doanh thu";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // chartNhanVien
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNhanVien.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNhanVien.Legends.Add(legend1);
            this.chartNhanVien.Location = new System.Drawing.Point(24, 92);
            this.chartNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartNhanVien.Name = "chartNhanVien";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartNhanVien.Series.Add(series1);
            this.chartNhanVien.Size = new System.Drawing.Size(830, 625);
            this.chartNhanVien.TabIndex = 1;
            this.chartNhanVien.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "THỐNG KÊ DOANH THU NHÂN VIÊN";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(726, 62);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(98, 25);
            this.btnHienThi.TabIndex = 27;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnInBC
            // 
            btnInBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnInBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            btnInBC.Location = new System.Drawing.Point(1559, 736);
            btnInBC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnInBC.Name = "btnInBC";
            btnInBC.Size = new System.Drawing.Size(131, 50);
            btnInBC.TabIndex = 28;
            btnInBC.Text = "In báo báo";
            btnInBC.UseVisualStyleBackColor = true;
            // 
            // frmBCTK_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(btnInBC);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartNhanVien);
            this.Controls.Add(this.dgvNhanVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBCTK_NhanVien";
            this.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBCTK_NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCTK_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}