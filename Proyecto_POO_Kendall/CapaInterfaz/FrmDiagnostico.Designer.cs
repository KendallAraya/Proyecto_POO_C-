
namespace CapaInterfaz
{
    partial class FrmDiagnostico
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GrdListaDiagnostico = new System.Windows.Forms.DataGridView();
            this.IDdiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDEspecialista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDDiag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEspecialista = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(260, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(504, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // GrdListaDiagnostico
            // 
            this.GrdListaDiagnostico.AllowUserToAddRows = false;
            this.GrdListaDiagnostico.AllowUserToDeleteRows = false;
            this.GrdListaDiagnostico.AllowUserToResizeColumns = false;
            this.GrdListaDiagnostico.AllowUserToResizeRows = false;
            this.GrdListaDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListaDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDdiagnostico,
            this.IDEspecialista,
            this.Fecha,
            this.Resultados});
            this.GrdListaDiagnostico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdListaDiagnostico.Location = new System.Drawing.Point(13, 159);
            this.GrdListaDiagnostico.Name = "GrdListaDiagnostico";
            this.GrdListaDiagnostico.RowTemplate.Height = 25;
            this.GrdListaDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListaDiagnostico.Size = new System.Drawing.Size(567, 150);
            this.GrdListaDiagnostico.TabIndex = 21;
            this.GrdListaDiagnostico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdListaDiagnostico_CellContentClick);
            // 
            // IDdiagnostico
            // 
            this.IDdiagnostico.DataPropertyName = "IDdiagnostico";
            this.IDdiagnostico.HeaderText = "ID. Diagnostico";
            this.IDdiagnostico.Name = "IDdiagnostico";
            // 
            // IDEspecialista
            // 
            this.IDEspecialista.DataPropertyName = "IdEspecialista";
            this.IDEspecialista.HeaderText = "ID. Especialista";
            this.IDEspecialista.Name = "IDEspecialista";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaRealizacion";
            this.Fecha.HeaderText = "Fecha Realiza";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 123;
            // 
            // Resultados
            // 
            this.Resultados.DataPropertyName = "Resultados";
            this.Resultados.HeaderText = "Resultados";
            this.Resultados.Name = "Resultados";
            this.Resultados.Width = 200;
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(13, 108);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(567, 44);
            this.txtResultados.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Resultados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha de Realizacion";
            // 
            // txtIDEspecialista
            // 
            this.txtIDEspecialista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDEspecialista.Enabled = false;
            this.txtIDEspecialista.Location = new System.Drawing.Point(162, 24);
            this.txtIDEspecialista.Name = "txtIDEspecialista";
            this.txtIDEspecialista.Size = new System.Drawing.Size(84, 23);
            this.txtIDEspecialista.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID. Especialista";
            // 
            // txtIDDiag
            // 
            this.txtIDDiag.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDDiag.Enabled = false;
            this.txtIDDiag.Location = new System.Drawing.Point(17, 25);
            this.txtIDDiag.Name = "txtIDDiag";
            this.txtIDDiag.Size = new System.Drawing.Size(87, 23);
            this.txtIDDiag.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID. Diagnostico";
            // 
            // btnBuscarEspecialista
            // 
            this.btnBuscarEspecialista.Location = new System.Drawing.Point(464, 24);
            this.btnBuscarEspecialista.Name = "btnBuscarEspecialista";
            this.btnBuscarEspecialista.Size = new System.Drawing.Size(118, 23);
            this.btnBuscarEspecialista.TabIndex = 26;
            this.btnBuscarEspecialista.Text = "Buscar Especialista";
            this.btnBuscarEspecialista.UseVisualStyleBackColor = true;
            this.btnBuscarEspecialista.Click += new System.EventHandler(this.btnBuscarEspecialista_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(162, 58);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 27;
            // 
            // FrmDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnBuscarEspecialista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GrdListaDiagnostico);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDEspecialista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDDiag);
            this.Controls.Add(this.label1);
            this.Name = "FrmDiagnostico";
            this.Text = "Administrar Diagnosticos";
            this.Load += new System.EventHandler(this.FrmDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView GrdListaDiagnostico;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDEspecialista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDDiag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEspecialista;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDdiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultados;
    }
}