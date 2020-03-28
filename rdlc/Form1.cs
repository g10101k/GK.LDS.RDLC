using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace rdlc
{
    public partial class Form1 : Form
    {

        public ReportDataSource rds = new ReportDataSource("DataSet1", getData());
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_I_LDS_Common_TestDataSet.SysDatabaseProps". При необходимости она может быть перемещена или удалена.
            //this.SysDatabasePropsTableAdapter.Fill(this._I_LDS_Common_TestDataSet.SysDatabaseProps);
            //reportViewer1.Refresh();


            RuntimeRDLC();
            //this.reportViewer1.RefreshReport();
        }

        private void rptGetDataset()
        {

            DataTable dataTable = new DataTable("SysdatabaseProps");
            dataTable.Columns.Add(new DataColumn("PropName", typeof(String)));
            dataTable.Columns.Add(new DataColumn("PropValue", typeof(String)));
            dataTable.Columns.Add(new DataColumn("PropDesc", typeof(String)));
            dataTable.Rows.Add(new object[] { "row1", "row1", "row1" });
            dataTable.Rows.Add(new object[] { "row2", "row2", "row2" });
            dataTable.Rows.Add(new object[] { "row3", "row3" });

            DataSet ds = new DataSet("DataSet1");
            ds.Tables.Add(dataTable);
            ds.GetXmlSchema();
            ds.WriteXmlSchema("/Ds.xsd");
            ds.WriteXml("Ds.xml");
        }

        private static DataTable getData()
        {
            DataTable dataTable = new DataTable("SysdatabaseProps");
            dataTable.Columns.Add(new DataColumn("PropName", typeof(string)));
            dataTable.Columns.Add(new DataColumn("PropValue", typeof(string)));
            dataTable.Columns.Add(new DataColumn("PropDesc", typeof(string)));
            dataTable.Rows.Add(new object[] { "row1", "row1", "row1" });
            dataTable.Rows.Add(new object[] { "row2", "row2", "row2" });
            dataTable.Rows.Add(new object[] { "row3", "row3", "row3" });
            return dataTable;
        }

        private void RuntimeRDLC()
        {
            reportViewer1.Reset();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", getData());
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "rdlc.Report1.rdlc";
            reportViewer1.RefreshReport();
        }


    }
}
