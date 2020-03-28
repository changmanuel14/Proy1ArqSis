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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Edificio.frmEdificioListar listar = new Edificio.frmEdificioListar();
            listar.MdiParent = this;
            listar.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Edificio.frmEdificioAgregar agregar = new Edificio.frmEdificioAgregar();
            agregar.MdiParent = this;
            agregar.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Edificio.frmEdificioEditar editar = new Edificio.frmEdificioEditar();
            editar.MdiParent = this;
            editar.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Mobiliario.frmMobiliarioListar listar = new Mobiliario.frmMobiliarioListar();
            listar.MdiParent = this;
            listar.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Mobiliario.frmMobiliarioAgregar agregar = new Mobiliario.frmMobiliarioAgregar();
            agregar.MdiParent = this;
            agregar.Show();
        }


        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Ubicacion.frmUbicacionListar listar = new Ubicacion.frmUbicacionListar();
            listar.MdiParent = this;
            listar.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Ubicacion.frmUbicacionAgregar agregar = new Ubicacion.frmUbicacionAgregar();
            agregar.MdiParent = this;
            agregar.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Ubicacion.frmUbicacionEditar editar = new Ubicacion.frmUbicacionEditar();
            editar.MdiParent = this;
            editar.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Informe1 inf = new Informe1();
            inf.MdiParent = this;
            inf.Show();
        }
    }
}
