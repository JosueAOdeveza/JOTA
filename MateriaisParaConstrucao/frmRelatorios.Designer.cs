namespace MateriaisParaConstrucao
{
    partial class frmRelatorios
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
        private void InitializeComponent(Microsoft.Reporting.WinForms.ReportViewer reportViewer11)
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConstrucaoDataSet = new MateriaisParaConstrucao.ConstrucaoDataSet();
            Microsoft.Reporting.WinForms.ReportViewer reportViewer12 = this.reportViewer1;
            reportViewer12 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutosTableAdapter = new MateriaisParaConstrucao.ConstrucaoDataSetTableAdapters.ProdutosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstrucaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosBindingSource
            // 
            this.ProdutosBindingSource.DataMember = "Produtos";
            this.ProdutosBindingSource.DataSource = this.ConstrucaoDataSet;
            // 
            // ConstrucaoDataSet
            // 
            this.ConstrucaoDataSet.DataSetName = "ConstrucaoDataSet";
            this.ConstrucaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportViewer12.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetConstrução";
            reportDataSource1.Value = this.ProdutosBindingSource;
            reportViewer12.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer12.LocalReport.ReportEmbeddedResource = "MateriaisParaConstrucao.rpRelatorios.rdlc";
            reportViewer12.Location = new System.Drawing.Point(0, 0);
            reportViewer12.Name = "reportViewer1";
            reportViewer12.Size = new System.Drawing.Size(857, 541);
            reportViewer12.TabIndex = 0;
            // 
            // ProdutosTableAdapter
            // 
            this.ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 541);
            Microsoft.Reporting.WinForms.ReportViewer reportViewer11 = reportViewer12;
            this.Controls.Add(reportViewer11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstrucaoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private ConstrucaoDataSet ConstrucaoDataSet;
        private ConstrucaoDataSetTableAdapters.ProdutosTableAdapter ProdutosTableAdapter;
    }
}