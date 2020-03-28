namespace UI.Edificio
{
    partial class frmEdificioEditar
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.observacionEdificio = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.actualizarBTN = new Syncfusion.WinForms.Controls.SfButton();
            this.cancelarBTN = new Syncfusion.WinForms.Controls.SfButton();
            this.activo = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoEdificio = new System.Windows.Forms.TextBox();
            this.nombreEdificio = new System.Windows.Forms.TextBox();
            this.listaEdificios = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.filtro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observacionEdificio)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.activo);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.observacionEdificio, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(437, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(414, 76);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "Observación";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // observacionEdificio
            // 
            this.observacionEdificio.BeforeTouchSize = new System.Drawing.Size(201, 70);
            this.observacionEdificio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacionEdificio.Location = new System.Drawing.Point(210, 3);
            this.observacionEdificio.Multiline = true;
            this.observacionEdificio.Name = "observacionEdificio";
            this.observacionEdificio.Size = new System.Drawing.Size(201, 70);
            this.observacionEdificio.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.actualizarBTN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelarBTN, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(327, 187);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(272, 51);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // actualizarBTN
            // 
            this.actualizarBTN.AccessibleName = "Button";
            this.actualizarBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actualizarBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarBTN.Location = new System.Drawing.Point(3, 3);
            this.actualizarBTN.Name = "actualizarBTN";
            this.actualizarBTN.Size = new System.Drawing.Size(130, 45);
            this.actualizarBTN.TabIndex = 0;
            this.actualizarBTN.Text = "Actualizar";
            this.actualizarBTN.Click += new System.EventHandler(this.actualizarBTN_Click);
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.AccessibleName = "Button";
            this.cancelarBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelarBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBTN.Location = new System.Drawing.Point(139, 3);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(130, 45);
            this.cancelarBTN.TabIndex = 1;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // activo
            // 
            activeStateCollection1.Text = "ACTIVO";
            this.activo.ActiveState = activeStateCollection1;
            this.activo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.activo.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.Text = "INACTIVO";
            this.activo.InactiveState = inactiveStateCollection1;
            this.activo.Location = new System.Drawing.Point(550, 116);
            this.activo.MinimumSize = new System.Drawing.Size(52, 20);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(232, 40);
            this.activo.Slider = sliderCollection1;
            this.activo.TabIndex = 2;
            this.activo.Text = "activo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.codigoEdificio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nombreEdificio, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 122);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // codigoEdificio
            // 
            this.codigoEdificio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codigoEdificio.Enabled = false;
            this.codigoEdificio.Location = new System.Drawing.Point(202, 3);
            this.codigoEdificio.Name = "codigoEdificio";
            this.codigoEdificio.Size = new System.Drawing.Size(193, 26);
            this.codigoEdificio.TabIndex = 2;
            // 
            // nombreEdificio
            // 
            this.nombreEdificio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nombreEdificio.Location = new System.Drawing.Point(202, 64);
            this.nombreEdificio.Name = "nombreEdificio";
            this.nombreEdificio.Size = new System.Drawing.Size(193, 26);
            this.nombreEdificio.TabIndex = 3;
            // 
            // listaEdificios
            // 
            this.listaEdificios.AccessibleName = "Table";
            this.listaEdificios.AllowEditing = false;
            this.listaEdificios.AllowGrouping = false;
            this.listaEdificios.AllowSorting = false;
            this.listaEdificios.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaEdificios.Location = new System.Drawing.Point(0, 26);
            this.listaEdificios.Name = "listaEdificios";
            this.listaEdificios.Size = new System.Drawing.Size(874, 224);
            this.listaEdificios.TabIndex = 2;
            this.listaEdificios.Text = "CategoriasDatos";
            this.listaEdificios.SelectionChanged += new Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventHandler(this.listaEdificios_SelectionChanged);
            // 
            // filtro
            // 
            this.filtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro.Location = new System.Drawing.Point(0, 0);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(874, 26);
            this.filtro.TabIndex = 4;
            this.filtro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filtro.Visible = false;
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            // 
            // frmEdificioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaEdificios);
            this.Controls.Add(this.filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEdificioEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Edificios";
            this.Load += new System.EventHandler(this.frmEdificioEditar_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observacionEdificio)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton actualizarBTN;
        private Syncfusion.WinForms.Controls.SfButton cancelarBTN;
        private Syncfusion.Windows.Forms.Tools.ToggleButton activo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoEdificio;
        private System.Windows.Forms.TextBox nombreEdificio;
        private Syncfusion.WinForms.DataGrid.SfDataGrid listaEdificios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt observacionEdificio;
        private System.Windows.Forms.TextBox filtro;
    }
}