using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteClientes : Form
    {
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        public DataTable ProductosDataSet(DataTable dt)
        {
            dt = NClientes.ListarClientes(1);
            return dt;
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            dtt = ProductosDataSet(dtt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("DataSet", dtt);
            reportViewer1.LocalReport.DataSources.Add(rpts);            
            reportViewer1.RefreshReport();
        }
    }
}
