using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using sfDataGridQustomize;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace UI.Edificio
{
    public partial class frmEdificioEditar : Form
    {
        sfDataGridQustomize_ sfDG = new sfDataGridQustomize_();
        public frmEdificioEditar()
        {
            InitializeComponent();
        }

        private void frmEdificioEditar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            LimpiarGB();
        }

        private void actualizarBTN_Click(object sender, EventArgs e)
        {
            string resp = "";
            ClassEdificio Logica = new ClassEdificio();
            Models.Edificio EDF = new Models.Edificio();
            EDF.nombre_edificio = nombreEdificio.Text;
            EDF.EdificioId = Convert.ToInt32(codigoEdificio.Text);
            EDF.observacion = observacionEdificio.Text;
            if (activo.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                EDF.estado_edificio = true;
            else
                EDF.estado_edificio = false;

            resp = Logica.EditarEdificio(EDF);

            if (resp.ToUpper().Contains("ERROR"))
                MessageBox.Show(resp, "Edicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(resp, "Se ha hecho la edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar();
                LimpiarGB();
            }
        }

        private void Cargar()
        {
            ClassEdificio logica = new ClassEdificio();
            listaEdificios.DataSource = logica.ListarEdificios();
            listaEdificios = sfDG.FillColumns(listaEdificios, 1);
        }

        private void LimpiarGB()
        {
            codigoEdificio.Text = nombreEdificio.Text = observacionEdificio.Text = "";
            activo.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
            groupBox1.Enabled = false;
        }

        private void listaEdificios_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            groupBox1.Enabled = true;

            int index = listaEdificios.CurrentCell.RowIndex;
            var rowData = listaEdificios.GetRecordAtRowIndex(index);
            var propertyCollection = this.listaEdificios.View.GetPropertyAccessProvider();

            codigoEdificio.Text = (propertyCollection.GetValue(rowData, "EdificioId") as Object).ToString();
            nombreEdificio.Text = propertyCollection.GetValue(rowData, "nombre_edificio") as String;
            observacionEdificio.Text = propertyCollection.GetValue(rowData, "observacion") as String;


            if ((propertyCollection.GetValue(rowData, "estado_edificio") as Object).ToString() == "True")
                activo.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            else
                activo.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            listaEdificios = sfDG.TBXFilter(listaEdificios, filtro.Text);
        }
    }
}
