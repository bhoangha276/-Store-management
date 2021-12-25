
namespace QLCHMP.Interface
{
    partial class frmCNBanHang
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
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản lý bán hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.CheckedState.Parent = this.btnThanhToan;
            this.btnThanhToan.CustomImages.Parent = this.btnThanhToan;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.DisabledState.Parent = this.btnThanhToan;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.Parent = this.btnThanhToan;
            this.btnThanhToan.Location = new System.Drawing.Point(2, 100);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(212, 45);
            this.btnThanhToan.TabIndex = 17;
            this.btnThanhToan.Text = "Thanh toán ";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmCNBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(215, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThanhToan);
            this.Name = "frmCNBanHang";
            this.Text = "frmCNBanHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
    }
}