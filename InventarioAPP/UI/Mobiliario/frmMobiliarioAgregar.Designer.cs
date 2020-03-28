namespace UI.Mobiliario
{
    partial class frmMobiliarioAgregar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroSTBX = new System.Windows.Forms.TextBox();
            this.descripcionTBX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.observacionTBX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tipoMobiliarioCBX = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ubicacionCBX = new Syncfusion.WinForms.ListView.SfComboBox();
            this.estadoCBX = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.agregarBTN = new Syncfusion.WinForms.Controls.SfButton();
            this.cancelarBTN = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMobiliarioCBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionCBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCBX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR NUEVO MOBILIARIO";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.53904F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.46096F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.numeroSTBX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.descripcionTBX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.observacionTBX, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tipoMobiliarioCBX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ubicacionCBX, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.estadoCBX, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 253);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Serie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Mobiliario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicación";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 43);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeroSTBX
            // 
            this.numeroSTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeroSTBX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroSTBX.Location = new System.Drawing.Point(247, 3);
            this.numeroSTBX.Name = "numeroSTBX";
            this.numeroSTBX.Size = new System.Drawing.Size(384, 26);
            this.numeroSTBX.TabIndex = 6;
            // 
            // descripcionTBX
            // 
            this.descripcionTBX.BeforeTouchSize = new System.Drawing.Size(384, 37);
            this.descripcionTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descripcionTBX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTBX.Location = new System.Drawing.Point(247, 45);
            this.descripcionTBX.Multiline = true;
            this.descripcionTBX.Name = "descripcionTBX";
            this.descripcionTBX.Size = new System.Drawing.Size(384, 36);
            this.descripcionTBX.TabIndex = 7;
            // 
            // observacionTBX
            // 
            this.observacionTBX.BeforeTouchSize = new System.Drawing.Size(384, 37);
            this.observacionTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacionTBX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionTBX.Location = new System.Drawing.Point(247, 213);
            this.observacionTBX.Multiline = true;
            this.observacionTBX.Name = "observacionTBX";
            this.observacionTBX.Size = new System.Drawing.Size(384, 37);
            this.observacionTBX.TabIndex = 8;
            // 
            // tipoMobiliarioCBX
            // 
            this.tipoMobiliarioCBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoMobiliarioCBX.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.tipoMobiliarioCBX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoMobiliarioCBX.Location = new System.Drawing.Point(247, 87);
            this.tipoMobiliarioCBX.Name = "tipoMobiliarioCBX";
            this.tipoMobiliarioCBX.Size = new System.Drawing.Size(384, 36);
            this.tipoMobiliarioCBX.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoMobiliarioCBX.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoMobiliarioCBX.TabIndex = 9;
            this.tipoMobiliarioCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipoMobiliarioCBX_KeyPress);
            // 
            // ubicacionCBX
            // 
            this.ubicacionCBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicacionCBX.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ubicacionCBX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionCBX.Location = new System.Drawing.Point(247, 129);
            this.ubicacionCBX.Name = "ubicacionCBX";
            this.ubicacionCBX.Size = new System.Drawing.Size(384, 36);
            this.ubicacionCBX.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionCBX.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionCBX.TabIndex = 10;
            this.ubicacionCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipoMobiliarioCBX_KeyPress);
            // 
            // estadoCBX
            // 
            this.estadoCBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadoCBX.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.estadoCBX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCBX.Location = new System.Drawing.Point(247, 171);
            this.estadoCBX.Name = "estadoCBX";
            this.estadoCBX.Size = new System.Drawing.Size(384, 36);
            this.estadoCBX.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCBX.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCBX.TabIndex = 11;
            this.estadoCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipoMobiliarioCBX_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.agregarBTN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelarBTN, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // agregarBTN
            // 
            this.agregarBTN.AccessibleName = "Button";
            this.agregarBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(3, 3);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(311, 46);
            this.agregarBTN.TabIndex = 0;
            this.agregarBTN.Text = "Agregar";
            this.agregarBTN.Click += new System.EventHandler(this.agregarBTN_Click);
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.AccessibleName = "Button";
            this.cancelarBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelarBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBTN.Location = new System.Drawing.Point(320, 3);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(311, 46);
            this.cancelarBTN.TabIndex = 1;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // frmMobiliarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 336);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMobiliarioAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Mobiliario";
            this.Load += new System.EventHandler(this.frmMobiliarioAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionTBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMobiliarioCBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionCBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCBX)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton agregarBTN;
        private Syncfusion.WinForms.Controls.SfButton cancelarBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numeroSTBX;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt descripcionTBX;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt observacionTBX;
        private Syncfusion.WinForms.ListView.SfComboBox tipoMobiliarioCBX;
        private Syncfusion.WinForms.ListView.SfComboBox ubicacionCBX;
        private Syncfusion.WinForms.ListView.SfComboBox estadoCBX;
    }
}