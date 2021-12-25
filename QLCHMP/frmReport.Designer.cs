
namespace QLCHMP
{
    partial class frmReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_CHMPDataSet = new QLCHMP.QL_CHMPDataSet();
            this.ChiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHDTableAdapter = new QLCHMP.QL_CHMPDataSetTableAdapters.ChiTietHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_CHMPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHMP.Interface.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(241, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(662, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_CHMPDataSet
            // 
            this.QL_CHMPDataSet.DataSetName = "QL_CHMPDataSet";
            this.QL_CHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHDBindingSource
            // 
            this.ChiTietHDBindingSource.DataMember = "ChiTietHD";
            this.ChiTietHDBindingSource.DataSource = this.QL_CHMPDataSet;
            // 
            // ChiTietHDTableAdapter
            // 
            this.ChiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 722);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_CHMPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHDBindingSource;
        private QL_CHMPDataSet QL_CHMPDataSet;
        private QL_CHMPDataSetTableAdapters.ChiTietHDTableAdapter ChiTietHDTableAdapter;
    }
}