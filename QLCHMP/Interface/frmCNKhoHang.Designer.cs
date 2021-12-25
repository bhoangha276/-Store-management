
namespace QLCHMP.Interface
{
    partial class frmCNKhoHang
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
            this.btnLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanPham = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý kho hàng";
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.CheckedState.Parent = this.btnLoaiSP;
            this.btnLoaiSP.CustomImages.Parent = this.btnLoaiSP;
            this.btnLoaiSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoaiSP.DisabledState.Parent = this.btnLoaiSP;
            this.btnLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSP.HoverState.Parent = this.btnLoaiSP;
            this.btnLoaiSP.Location = new System.Drawing.Point(2, 160);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.ShadowDecoration.Parent = this.btnLoaiSP;
            this.btnLoaiSP.Size = new System.Drawing.Size(212, 45);
            this.btnLoaiSP.TabIndex = 7;
            this.btnLoaiSP.Text = "Loại sản phẩm";
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.CheckedState.Parent = this.btnSanPham;
            this.btnSanPham.CustomImages.Parent = this.btnSanPham;
            this.btnSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSanPham.DisabledState.Parent = this.btnSanPham;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.HoverState.Parent = this.btnSanPham;
            this.btnSanPham.Location = new System.Drawing.Point(2, 100);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.ShadowDecoration.Parent = this.btnSanPham;
            this.btnSanPham.Size = new System.Drawing.Size(212, 45);
            this.btnSanPham.TabIndex = 6;
            this.btnSanPham.Text = "Thông tin sản phẩm";
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // frmCNKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(215, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoaiSP);
            this.Controls.Add(this.btnSanPham);
            this.Name = "frmCNKhoHang";
            this.Text = "frmCNKhoHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnSanPham;
    }
}