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

namespace UI.Edificio
{
    public partial class frmEdificioAgregar : Form
    {
        public frmEdificioAgregar()
        {
            InitializeComponent();
        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            ClassEdificio LG = new ClassEdificio();
            string respuesta = LG.NuevoEdificio(nombreTBX.Text, observacionTBX.Text);
            if (respuesta.ToUpper().Contains("ERROR"))
                MessageBox.Show(respuesta, "Error al guargar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(respuesta, "Nuevo Edificio.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdificioAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
