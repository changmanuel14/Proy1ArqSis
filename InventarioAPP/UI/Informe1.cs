using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Informe1 : Form
    {
        public Informe1()
        {
            InitializeComponent();
        }

        private void Informe1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.InformeInventario' Puede moverla o quitarla según sea necesario.
            this.InformeInventarioTableAdapter.Fill(this.inventarioDBDataSet.InformeInventario);

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }
    }
}
