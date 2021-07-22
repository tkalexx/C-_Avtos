namespace Avtoservis2
{
    partial class Rep1
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
            this.AvtoservisDataSet = new Avtoservis2.AvtoservisDataSet();
            this.f1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f1TableAdapter = new Avtoservis2.AvtoservisDataSetTableAdapters.f1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AvtoservisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.f1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Avtoservis2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(648, 276);
            this.reportViewer1.TabIndex = 0;
            // 
            // AvtoservisDataSet
            // 
            this.AvtoservisDataSet.DataSetName = "AvtoservisDataSet";
            this.AvtoservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f1BindingSource
            // 
            this.f1BindingSource.DataMember = "f1";
            this.f1BindingSource.DataSource = this.AvtoservisDataSet;
            // 
            // f1TableAdapter
            // 
            this.f1TableAdapter.ClearBeforeFill = true;
            // 
            // Rep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(662, 279);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rep1";
            this.Text = "Сумма продаж моделей каждой марки";
            this.Load += new System.EventHandler(this.Rep1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvtoservisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource f1BindingSource;
        private AvtoservisDataSet AvtoservisDataSet;
        private AvtoservisDataSetTableAdapters.f1TableAdapter f1TableAdapter;
    }
}