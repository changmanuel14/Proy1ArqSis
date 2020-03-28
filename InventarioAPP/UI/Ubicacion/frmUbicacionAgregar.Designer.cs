namespace UI.Ubicacion
{
    partial class frmUbicacionAgregar
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
            this.nombreTBX = new System.Windows.Forms.TextBox();
            this.observacionTBX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.edificioCMBX = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.agregarBTN = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observacionTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificioCMBX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR NUEVA UBICACIÓN";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nombreTBX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.observacionTBX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.edificioCMBX, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(107, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.75691F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.86188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 181);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edificio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 93);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observación";
            // 
            // nombreTBX
            // 
            this.nombreTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nombreTBX.ForeColor = System.Drawing.Color.Black;
            this.nombreTBX.Location = new System.Drawing.Point(195, 3);
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(186, 35);
            this.nombreTBX.TabIndex = 3;
            // 
            // observacionTBX
            // 
            this.observacionTBX.BeforeTouchSize = new System.Drawing.Size(186, 87);
            this.observacionTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacionTBX.ForeColor = System.Drawing.Color.Black;
            this.observacionTBX.Location = new System.Drawing.Point(195, 91);
            this.observacionTBX.Multiline = true;
            this.observacionTBX.Name = "observacionTBX";
            this.observacionTBX.Size = new System.Drawing.Size(186, 87);
            this.observacionTBX.TabIndex = 4;
            // 
            // edificioCMBX
            // 
            this.edificioCMBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edificioCMBX.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.edificioCMBX.ForeColor = System.Drawing.Color.Black;
            this.edificioCMBX.Location = new System.Drawing.Point(195, 46);
            this.edificioCMBX.Name = "edificioCMBX";
            this.edificioCMBX.Size = new System.Drawing.Size(186, 39);
            this.edificioCMBX.Style.EditorStyle.ForeColor = System.Drawing.Color.Black;
            this.edificioCMBX.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.agregarBTN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sfButton2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(107, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // agregarBTN
            // 
            this.agregarBTN.AccessibleName = "Button";
            this.agregarBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(3, 3);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(186, 49);
            this.agregarBTN.TabIndex = 0;
            this.agregarBTN.Text = "Agregar";
            this.agregarBTN.Click += new System.EventHandler(this.agregarBTN_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton2.Location = new System.Drawing.Point(195, 3);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(186, 49);
            this.sfButton2.TabIndex = 1;
            this.sfButton2.Text = "Cancelar";
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // frmUbicacionAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 353);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUbicacionAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Ubicación";
            this.Load += new System.EventHandler(this.frmUbicacionAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observacionTBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificioCMBX)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTBX;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt observacionTBX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton agregarBTN;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.ListView.SfComboBox edificioCMBX;
    }
}