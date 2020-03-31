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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RuntimeRDLC();
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
            dataTable.Rows.Add(new object[] { "row4", "row4", "row4" });
            return dataTable;
        }


        private void RuntimeRDLC()
        {
            reportViewer1.Reset();
            ReportDataSource reportDataSource = new ReportDataSource("DSet1", getData());
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "rdlc.Report1.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
