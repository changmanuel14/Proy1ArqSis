using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sfDataGridQustomize;
using BusinessLogicLayer;
using Models;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace UI.Mobiliario
{
    public partial class frmMobiliarioListar : Form
    {
        sfDataGridQustomize_ sfDG = new sfDataGridQustomize_();
        public frmMobiliarioListar()
        {
            InitializeComponent();
        }

        private void filter_KeyUp(object sender, KeyEventArgs e)
        {
            //listaMobiliario = sfDG.TBXFilter(listaMobiliario, filter.Text);
        }

        private void frmMobiliarioListar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            ClassMobiliario LG = new ClassMobiliario();
            listaMobiliario.DataSource = LG.ListarMobiliario();
            listaMobiliario = sfDG.FillColumns(listaMobiliario, 1);
        }

        private void listaMobiliario_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            int index = listaMobiliario.CurrentCell.RowIndex;
            var rowData = listaMobiliario.GetRecordAtRowIndex(index);
            var propertyCollection = this.listaMobiliario.View.GetPropertyAccessProvider();
            DataTable dt = new DataTable();
            dt.Columns.Add("MobiliarioId");
            dt.Columns.Add("EstadomobiliarioId");
            dt.Columns.Add("TipomobiliarioId");
            dt.Columns.Add("UbicacionId");
            dt.Columns.Add("descripcion_mobiliario");
            dt.Columns.Add("numero_serie");
            dt.Columns.Add("observacion");
            dt.Columns.Add("fecha_creacion");

            string mbid = "", emid = "", tmid = "", ubid = "", dmb = "", ns = "", obs = "", fc="";

            try
            {
                mbid = (propertyCollection.GetValue(rowData, "MobiliarioId") as Object).ToString();
                emid = (propertyCollection.GetValue(rowData, "EstadomobiliarioId") as Object).ToString();
                tmid = (propertyCollection.GetValue(rowData, "TipomobiliarioId") as Object).ToString();
                ubid = (propertyCollection.GetValue(rowData, "UbicacionId") as Object).ToString();
                dmb = (propertyCollection.GetValue(rowData, "descripcion_mobiliario") as Object).ToString();
                ns = (propertyCollection.GetValue(rowData, "numero_serie") as Object).ToString();
                obs = (propertyCollection.GetValue(rowData, "observacion") as Object).ToString();
                fc = (propertyCollection.GetValue(rowData, "fecha_creacion") as Object).ToString();
            }
            catch(Exception ex)
            {

            }

            dt.Rows.Add(mbid, emid, tmid, ubid, dmb, ns, obs, fc);

            frmMobiliarioAgregar editar = new frmMobiliarioAgregar("EDIT", dt);
            editar.ShowDialog();
            Cargar();

            //codigoEdificio.Text = (propertyCollection.GetValue(rowData, "EdificioId") as Object).ToString();
        }
    }
}
