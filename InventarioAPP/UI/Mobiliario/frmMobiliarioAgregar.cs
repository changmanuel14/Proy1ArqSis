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
using Models;

namespace UI.Mobiliario
{
    public partial class frmMobiliarioAgregar : Form
    {
        string accion;
        DataTable dt;
        int id;
        public frmMobiliarioAgregar(string accion = "", DataTable dt = null)
        {
            InitializeComponent();
            this.accion = accion;
            this.dt = dt;
            if (accion.ToUpper() == "EDIT")
            {
                this.Text = "Editar Mobiliario";
                agregarBTN.Text = "Actualizar";
                groupBox1.Text = "EDITAR MOBILIARIO";
            }
        }

        private void frmMobiliarioAgregar_Load(object sender, EventArgs e)
        {
            //Llenar combobox Tipo Mobiliario
            ClassTipoMobiliario logicaTM = new ClassTipoMobiliario();
            tipoMobiliarioCBX.DataSource = logicaTM.ListarTipoMobiliario();
            tipoMobiliarioCBX.DisplayMember = "descripcion";
            tipoMobiliarioCBX.ValueMember = "TipomobiliarioId";
            //Llenar combobox Ubicación
            ClassUbicacion logicaUB = new ClassUbicacion();
            ubicacionCBX.DataSource = logicaUB.ListarUbicaciones();
            ubicacionCBX.DisplayMember = "nombre_ubicacion";
            ubicacionCBX.ValueMember = "UbicacionId";
            //Llenar combobox Estado Mobiliario
            ClassEstadoMobiliario logicaEM = new ClassEstadoMobiliario();
            estadoCBX.DataSource = logicaEM.ListarEstadoMobiliario();
            estadoCBX.DisplayMember = "descripcion_estado";
            estadoCBX.ValueMember = "EstadomobiliarioId";

            if (accion.ToUpper() == "EDIT")
            {
                if (dt != null)
                {
                    numeroSTBX.Text = dt.Rows[0]["numero_serie"].ToString();
                    descripcionTBX.Text = dt.Rows[0]["descripcion_mobiliario"].ToString();
                    tipoMobiliarioCBX.SelectedValue = Convert.ToInt32(dt.Rows[0]["TipomobiliarioId"].ToString());
                    ubicacionCBX.SelectedValue = Convert.ToInt32(dt.Rows[0]["UbicacionId"].ToString());
                    estadoCBX.SelectedValue = Convert.ToInt32(dt.Rows[0]["EstadomobiliarioId"].ToString());
                    observacionTBX.Text = dt.Rows[0]["observacion"].ToString();
                    id = Convert.ToInt32(dt.Rows[0]["MobiliarioId"].ToString());
                }
                else
                {
                    MessageBox.Show("ID inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void tipoMobiliarioCBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            if (accion == "")//agrega nuevo registro
            {
                ClassMobiliario LG = new ClassMobiliario();
                string respuesta = LG.NuevoMobiliario(Convert.ToInt32(estadoCBX.SelectedValue), Convert.ToInt32(tipoMobiliarioCBX.SelectedValue),
                                    Convert.ToInt32(ubicacionCBX.SelectedValue), descripcionTBX.Text, numeroSTBX.Text, observacionTBX.Text);
                if (respuesta.ToUpper().Contains("ERROR"))
                    MessageBox.Show(respuesta, "Error al guargar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show(respuesta, "Nuevo Mobiliario.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (accion.ToUpper() == "EDIT")//actualiza registro
            {
                ClassMobiliario LG = new ClassMobiliario();
                Models.Mobiliario MB = new Models.Mobiliario();
                MB.MobiliarioId = id;
                MB.EstadomobiliarioId = Convert.ToInt32(estadoCBX.SelectedValue);
                MB.TipomobiliarioId = Convert.ToInt32(tipoMobiliarioCBX.SelectedValue);
                MB.UbicacionId = Convert.ToInt32(ubicacionCBX.SelectedValue);
                MB.descripcion_mobiliario = descripcionTBX.Text;
                MB.numero_serie = numeroSTBX.Text;
                MB.observacion = observacionTBX.Text;
                MB.fecha_baja = null;
                MB.fecha_creacion = Convert.ToDateTime(dt.Rows[0]["fecha_creacion"].ToString());

                string respuesta = LG.EditarMobiliario(MB);
                if (respuesta.ToUpper().Contains("ERROR"))
                    MessageBox.Show(respuesta, "Error al actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show(respuesta, "Edición Mobiliario.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
