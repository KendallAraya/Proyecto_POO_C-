
namespace CapaInterfaz
{
    partial class FrmMedicamentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstrucciones = new System.Windows.Forms.TextBox();
            this.GrdListaMedicamentos = new System.Windows.Forms.DataGridView();
            this.IDMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrucciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID. Medicamento";
            // 
            // txtIDMedicamento
            // 
            this.txtIDMedicamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDMedicamento.Enabled = false;
            this.txtIDMedicamento.Location = new System.Drawing.Point(13, 32);
            this.txtIDMedicamento.Name = "txtIDMedicamento";
            this.txtIDMedicamento.Size = new System.Drawing.Size(98, 23);
            this.txtIDMedicamento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Medicamento";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(158, 31);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(194, 23);
            this.txtNombreMedicamento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(13, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(567, 23);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Instrucciones";
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.Location = new System.Drawing.Point(13, 130);
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.Size = new System.Drawing.Size(567, 23);
            this.txtInstrucciones.TabIndex = 7;
            // 
            // GrdListaMedicamentos
            // 
            this.GrdListaMedicamentos.AllowUserToAddRows = false;
            this.GrdListaMedicamentos.AllowUserToDeleteRows = false;
            this.GrdListaMedicamentos.AllowUserToResizeColumns = false;
            this.GrdListaMedicamentos.AllowUserToResizeRows = false;
            this.GrdListaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListaMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMedicamentos,
            this.NombreM,
            this.Descripcion,
            this.Instrucciones});
            this.GrdListaMedicamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdListaMedicamentos.Location = new System.Drawing.Point(13, 160);
            this.GrdListaMedicamentos.Name = "GrdListaMedicamentos";
            this.GrdListaMedicamentos.RowTemplate.Height = 25;
            this.GrdListaMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListaMedicamentos.Size = new System.Drawing.Size(567, 150);
            this.GrdListaMedicamentos.TabIndex = 8;
            this.GrdListaMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdListaMedicamentos_CellContentClick);
            // 
            // IDMedicamentos
            // 
            this.IDMedicamentos.DataPropertyName = "IDmedicamento";
            this.IDMedicamentos.HeaderText = "ID. Medicamento";
            this.IDMedicamentos.Name = "IDMedicamentos";
            // 
            // NombreM
            // 
            this.NombreM.DataPropertyName = "NombreMed";
            this.NombreM.HeaderText = "Nombre Med.";
            this.NombreM.Name = "NombreM";
            this.NombreM.Width = 110;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 120;
            // 
            // Instrucciones
            // 
            this.Instrucciones.DataPropertyName = "Instrucciones";
            this.Instrucciones.HeaderText = "Instrucciones";
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Width = 194;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 334);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(172, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(504, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(335, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GrdListaMedicamentos);
            this.Controls.Add(this.txtInstrucciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDMedicamento);
            this.Controls.Add(this.label1);
            this.Name = "FrmMedicamentos";
            this.Text = "Administrar Medicamentos";
            this.Load += new System.EventHandler(this.FrmMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstrucciones;
        private System.Windows.Forms.DataGridView GrdListaMedicamentos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrucciones;
    }
}