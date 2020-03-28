namespace rdlc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._I_LDS_Common_TestDataSet = new rdlc._I_LDS_Common_TestDataSet();
            this.SysDatabasePropsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SysDatabasePropsTableAdapter = new rdlc._I_LDS_Common_TestDataSetTableAdapters.SysDatabasePropsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._I_LDS_Common_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysDatabasePropsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SysDatabasePropsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "rdlc.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // _I_LDS_Common_TestDataSet
            // 
            this._I_LDS_Common_TestDataSet.DataSetName = "_I_LDS_Common_TestDataSet";
            this._I_LDS_Common_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SysDatabasePropsBindingSource
            // 
            this.SysDatabasePropsBindingSource.DataMember = "SysDatabaseProps";
            this.SysDatabasePropsBindingSource.DataSource = this._I_LDS_Common_TestDataSet;
            // 
            // SysDatabasePropsTableAdapter
            // 
            this.SysDatabasePropsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._I_LDS_Common_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysDatabasePropsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SysDatabasePropsBindingSource;
        private _I_LDS_Common_TestDataSet _I_LDS_Common_TestDataSet;
        private _I_LDS_Common_TestDataSetTableAdapters.SysDatabasePropsTableAdapter SysDatabasePropsTableAdapter;
    }
}

