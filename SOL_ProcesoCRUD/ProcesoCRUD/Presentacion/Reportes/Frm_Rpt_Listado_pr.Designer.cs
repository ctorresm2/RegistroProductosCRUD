namespace ProcesoCRUD.Presentacion.Reportes
{
    partial class Frm_Rpt_Listado_pr
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
            this.text_01 = new System.Windows.Forms.TextBox();
            this.uSPLISTADOPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new ProcesoCRUD.Presentacion.Reportes.DS_Reportes();
            this.uSP_LISTADO_PRTableAdapter = new ProcesoCRUD.Presentacion.Reportes.DS_ReportesTableAdapters.USP_LISTADO_PRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPLISTADOPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPLISTADOPRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProcesoCRUD.Presentacion.Reportes.RPP_Listado_pr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1093, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // text_01
            // 
            this.text_01.Location = new System.Drawing.Point(68, 87);
            this.text_01.Name = "text_01";
            this.text_01.Size = new System.Drawing.Size(100, 20);
            this.text_01.TabIndex = 1;
            this.text_01.Visible = false;
            // 
            // uSPLISTADOPRBindingSource
            // 
            this.uSPLISTADOPRBindingSource.DataMember = "USP_LISTADO_PR";
            this.uSPLISTADOPRBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSP_LISTADO_PRTableAdapter
            // 
            this.uSP_LISTADO_PRTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rpt_Listado_pr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 623);
            this.Controls.Add(this.text_01);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rpt_Listado_pr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Listado_pr";
            this.Load += new System.EventHandler(this.Frm_Rpt_Listado_pr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPLISTADOPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPLISTADOPRBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.USP_LISTADO_PRTableAdapter uSP_LISTADO_PRTableAdapter;
        internal System.Windows.Forms.TextBox text_01;
    }
}