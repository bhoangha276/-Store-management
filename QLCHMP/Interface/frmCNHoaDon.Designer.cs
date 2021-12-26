
namespace QLCHMP.Interface
{
    partial class frmCNHoaDon
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
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTietHD = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.CheckedState.Parent = this.btnHoaDon;
            this.btnHoaDon.CustomImages.Parent = this.btnHoaDon;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.DisabledState.Parent = this.btnHoaDon;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.HoverState.Parent = this.btnHoaDon;
            this.btnHoaDon.Location = new System.Drawing.Point(2, 100);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ShadowDecoration.Parent = this.btnHoaDon;
            this.btnHoaDon.Size = new System.Drawing.Size(212, 45);
            this.btnHoaDon.TabIndex = 15;
            this.btnHoaDon.Text = "Thông hóa đơn";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnChiTietHD
            // 
            this.btnChiTietHD.CheckedState.Parent = this.btnChiTietHD;
            this.btnChiTietHD.CustomImages.Parent = this.btnChiTietHD;
            this.btnChiTietHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTietHD.DisabledState.Parent = this.btnChiTietHD;
            this.btnChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChiTietHD.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHD.HoverState.Parent = this.btnChiTietHD;
            this.btnChiTietHD.Location = new System.Drawing.Point(2, 160);
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.ShadowDecoration.Parent = this.btnChiTietHD;
            this.btnChiTietHD.Size = new System.Drawing.Size(212, 45);
            this.btnChiTietHD.TabIndex = 17;
            this.btnChiTietHD.Text = "Chi tiết hóa đơn";
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // frmCNHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(215, 519);
            this.Controls.Add(this.btnChiTietHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHoaDon);
            this.Name = "frmCNHoaDon";
            this.Text = "frmCNHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnChiTietHD;
    }
}