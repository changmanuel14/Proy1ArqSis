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

namespace UI.Ubicacion
{
    public partial class frmUbicacionAgregar : Form
    {
        public frmUbicacionAgregar()
        {
            InitializeComponent();
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            ClassUbicacion ub = new ClassUbicacion();
            short edificioID = (short)(Convert.ToInt32(edificioCMBX.SelectedValue));
            string respuesta = ub.NuevaUbicacion(nombreTBX.Text, observacionTBX.Text, edificioID);
            if (respuesta.ToUpper().Contains("ERROR"))
                MessageBox.Show(respuesta, "Error al guargar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(respuesta, "Nueva Ubicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmUbicacionAgregar_Load(object sender, EventArgs e)
        {
            ClassEdificio edf = new ClassEdificio();
            edificioCMBX.DataSource = edf.ListarEdificios();
            edificioCMBX.DisplayMember = "nombre_edificio";
            edificioCMBX.ValueMember = "EdificioId";
        }
    }
}
