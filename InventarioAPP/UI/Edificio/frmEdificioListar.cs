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

namespace UI.Edificio
{
    public partial class frmEdificioListar : Form
    {
        sfDataGridQustomize_ sfDG = new sfDataGridQustomize_();
        public frmEdificioListar()
        {
            InitializeComponent();
        }

        private void frmEdificioListar_Load(object sender, EventArgs e)
        {
            ClassEdificio logica = new ClassEdificio();
            listaEdificios.DataSource = logica.ListarEdificios();
            listaEdificios = sfDG.FillColumns(listaEdificios, 1);
        }
    }
}
