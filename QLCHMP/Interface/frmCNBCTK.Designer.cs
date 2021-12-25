
namespace QLCHMP.Interface
{
    partial class frmCNBCTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnSPHot = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lý kho hàng";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.CheckedState.Parent = this.btnNhanVien;
            this.btnNhanVien.CustomImages.Parent = this.btnNhanVien;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.DisabledState.Parent = this.btnNhanVien;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.HoverState.Parent = this.btnNhanVien;
            this.btnNhanVien.Location = new System.Drawing.Point(2, 280);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ShadowDecoration.Parent = this.btnNhanVien;
            this.btnNhanVien.Size = new System.Drawing.Size(212, 45);
            this.btnNhanVien.TabIndex = 13;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnSPHot
            // 
            this.btnSPHot.CheckedState.Parent = this.btnSPHot;
            this.btnSPHot.CustomImages.Parent = this.btnSPHot;
            this.btnSPHot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSPHot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSPHot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSPHot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSPHot.DisabledState.Parent = this.btnSPHot;
            this.btnSPHot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSPHot.ForeColor = System.Drawing.Color.White;
            this.btnSPHot.HoverState.Parent = this.btnSPHot;
            this.btnSPHot.Location = new System.Drawing.Point(2, 220);
            this.btnSPHot.Name = "btnSPHot";
            this.btnSPHot.ShadowDecoration.Parent = this.btnSPHot;
            this.btnSPHot.Size = new System.Drawing.Size(212, 45);
            this.btnSPHot.TabIndex = 12;
            this.btnSPHot.Text = "Sản phẩm Hot";
            this.btnSPHot.Click += new System.EventHandler(this.btnSPHot_Click);
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.CheckedState.Parent = this.btnChiTieu;
            this.btnChiTieu.CustomImages.Parent = this.btnChiTieu;
            this.btnChiTieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTieu.DisabledState.Parent = this.btnChiTieu;
            this.btnChiTieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChiTieu.ForeColor = System.Drawing.Color.White;
            this.btnChiTieu.HoverState.Parent = this.btnChiTieu;
            this.btnChiTieu.Location = new System.Drawing.Point(2, 160);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.ShadowDecoration.Parent = this.btnChiTieu;
            this.btnChiTieu.Size = new System.Drawing.Size(212, 45);
            this.btnChiTieu.TabIndex = 11;
            this.btnChiTieu.Text = "Chi tiêu";
            this.btnChiTieu.Click += new System.EventHandler(this.btnChiTieu_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.CheckedState.Parent = this.btnDoanhThu;
            this.btnDoanhThu.CustomImages.Parent = this.btnDoanhThu;
            this.btnDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoanhThu.DisabledState.Parent = this.btnDoanhThu;
            this.btnDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.HoverState.Parent = this.btnDoanhThu;
            this.btnDoanhThu.Location = new System.Drawing.Point(2, 100);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.ShadowDecoration.Parent = this.btnDoanhThu;
            this.btnDoanhThu.Size = new System.Drawing.Size(212, 45);
            this.btnDoanhThu.TabIndex = 10;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // frmCNBCTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(215, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnSPHot);
            this.Controls.Add(this.btnChiTieu);
            this.Controls.Add(this.btnDoanhThu);
            this.Name = "frmCNBCTK";
            this.Text = "frmCNBCTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnSPHot;
        private Guna.UI2.WinForms.Guna2Button btnChiTieu;
        private Guna.UI2.WinForms.Guna2Button btnDoanhThu;
    }
}