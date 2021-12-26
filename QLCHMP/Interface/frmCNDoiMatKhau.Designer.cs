
namespace QLCHMP.Interface
{
    partial class frmCNDoiMatKhau
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
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cài đặt";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.CheckedState.Parent = this.btnDoiMK;
            this.btnDoiMK.CustomImages.Parent = this.btnDoiMK;
            this.btnDoiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMK.DisabledState.Parent = this.btnDoiMK;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.HoverState.Parent = this.btnDoiMK;
            this.btnDoiMK.Location = new System.Drawing.Point(2, 100);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.ShadowDecoration.Parent = this.btnDoiMK;
            this.btnDoiMK.Size = new System.Drawing.Size(212, 45);
            this.btnDoiMK.TabIndex = 19;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // frmCNDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(215, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoiMK);
            this.Name = "frmCNDoiMatKhau";
            this.Text = "frmCNDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDoiMK;
    }
}