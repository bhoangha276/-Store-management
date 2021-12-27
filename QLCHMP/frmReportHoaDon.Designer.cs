
namespace QLCHMP
{
    partial class frmReportHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportHoaDon));
            this.ChiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_CHMPDataSet = new QLCHMP.QL_CHMPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietHDTableAdapter = new QLCHMP.QL_CHMPDataSetTableAdapters.ChiTietHDTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_CHMPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietHDBindingSource
            // 
            this.ChiTietHDBindingSource.DataMember = "ChiTietHD";
            this.ChiTietHDBindingSource.DataSource = this.QL_CHMPDataSet;
            // 
            // QL_CHMPDataSet
            // 
            this.QL_CHMPDataSet.DataSetName = "QL_CHMPDataSet";
            this.QL_CHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHMP.Interface.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(111, 63);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(853, 627);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChiTietHDTableAdapter
            // 
            this.ChiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSearch.Location = new System.Drawing.Point(430, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1328, 840);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportHoaDon";
            this.Text = "frmReportHoaDon";
            this.Load += new System.EventHandler(this.frmReportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_CHMPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHDBindingSource;
        private QL_CHMPDataSet QL_CHMPDataSet;
        private QL_CHMPDataSetTableAdapters.ChiTietHDTableAdapter ChiTietHDTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}