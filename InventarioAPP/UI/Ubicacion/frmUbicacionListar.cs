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

namespace UI.Ubicacion
{
    public partial class frmUbicacionListar : Form
    {
        sfDataGridQustomize_ sfDG = new sfDataGridQustomize_();
        public frmUbicacionListar()
        {
            InitializeComponent();
        }

        private void frmUbicacionListar_Load(object sender, EventArgs e)
        {
            ClassUbicacion ub = new ClassUbicacion();
            sfDataGrid1.DataSource = ub.ListarUbicaciones();
            sfDataGrid1 = sfDG.FillColumns(sfDataGrid1, 1);
        }
    }
}
