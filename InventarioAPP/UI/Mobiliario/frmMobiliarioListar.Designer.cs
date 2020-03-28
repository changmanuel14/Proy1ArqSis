namespace UI.Mobiliario
{
    partial class frmMobiliarioListar
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
            this.filter = new System.Windows.Forms.TextBox();
            this.listaMobiliario = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.listaMobiliario)).BeginInit();
            this.SuspendLayout();
            // 
            // filter
            // 
            this.filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(0, 0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(800, 26);
            this.filter.TabIndex = 0;
            this.filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filter_KeyUp);
            // 
            // listaMobiliario
            // 
            this.listaMobiliario.AccessibleName = "Table";
            this.listaMobiliario.AllowEditing = false;
            this.listaMobiliario.AllowFiltering = true;
            this.listaMobiliario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaMobiliario.Location = new System.Drawing.Point(0, 26);
            this.listaMobiliario.Name = "listaMobiliario";
            this.listaMobiliario.Size = new System.Drawing.Size(800, 424);
            this.listaMobiliario.TabIndex = 1;
            this.listaMobiliario.Text = "sfDataGrid1";
            this.listaMobiliario.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.listaMobiliario_CellDoubleClick);
            // 
            // frmMobiliarioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaMobiliario);
            this.Controls.Add(this.filter);
            this.Name = "frmMobiliarioListar";
            this.Text = "Listar Mobiliario";
            this.Load += new System.EventHandler(this.frmMobiliarioListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaMobiliario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filter;
        private Syncfusion.WinForms.DataGrid.SfDataGrid listaMobiliario;
    }
}