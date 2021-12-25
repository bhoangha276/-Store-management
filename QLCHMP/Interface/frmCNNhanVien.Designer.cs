
namespace QLCHMP.Interface
{
    partial class frmCNNhanVien
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
            this.btnTinhLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.CheckedState.Parent = this.btnTinhLuong;
            this.btnTinhLuong.CustomImages.Parent = this.btnTinhLuong;
            this.btnTinhLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhLuong.DisabledState.Parent = this.btnTinhLuong;
            this.btnTinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.HoverState.Parent = this.btnTinhLuong;
            this.btnTinhLuong.Location = new System.Drawing.Point(2, 220);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ShadowDecoration.Parent = this.btnTinhLuong;
            this.btnTinhLuong.Size = new System.Drawing.Size(212, 45);
            this.btnTinhLuong.TabIndex = 6;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.CheckedState.Parent = this.btnChamCong;
            this.btnChamCong.CustomImages.Parent = this.btnChamCong;
            this.btnChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChamCong.DisabledState.Parent = this.btnChamCong;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.HoverState.Parent = this.btnChamCong;
            this.btnChamCong.Location = new System.Drawing.Point(2, 160);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.ShadowDecoration.Parent = this.btnChamCong;
            this.btnChamCong.Size = new System.Drawing.Size(212, 45);
            this.btnChamCong.TabIndex = 5;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
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
            this.btnNhanVien.Location = new System.Drawing.Point(2, 100);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ShadowDecoration.Parent = this.btnNhanVien;
            this.btnNhanVien.Size = new System.Drawing.Size(212, 45);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Thông tin nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // frmCNNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(215, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.btnNhanVien);
            this.Name = "frmCNNhanVien";
            this.Text = "frmCNNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTinhLuong;
        private Guna.UI2.WinForms.Guna2Button btnChamCong;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
    }
}