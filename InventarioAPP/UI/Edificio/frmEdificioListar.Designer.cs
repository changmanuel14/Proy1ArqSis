namespace UI.Edificio
{
    partial class frmEdificioListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaEdificios = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.listaEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 0;
            // 
            // listaEdificios
            // 
            this.listaEdificios.AccessibleName = "Table";
            this.listaEdificios.AllowEditing = false;
            this.listaEdificios.AllowGrouping = false;
            this.listaEdificios.AllowSorting = false;
            this.listaEdificios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaEdificios.Location = new System.Drawing.Point(0, 75);
            this.listaEdificios.Name = "listaEdificios";
            this.listaEdificios.Size = new System.Drawing.Size(800, 375);
            this.listaEdificios.TabIndex = 1;
            this.listaEdificios.Text = "listaEdificios";
            // 
            // frmEdificioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaEdificios);
            this.Controls.Add(this.panel1);
            this.Name = "frmEdificioListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Edificios";
            this.Load += new System.EventHandler(this.frmEdificioListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEdificios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid listaEdificios;
    }
}