
namespace CapaInterfaz
{
    partial class FrmHistorialPaciente
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
            this.txtIDHis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPA = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDDIAG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDMED = new System.Windows.Forms.TextBox();
            this.btnBuscarMedicamento = new System.Windows.Forms.Button();
            this.grdListaHistorial = new System.Windows.Forms.DataGridView();
            this.IDHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDdiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDmedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID. Historial Paciente";
            // 
            // txtIDHis
            // 
            this.txtIDHis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDHis.Enabled = false;
            this.txtIDHis.Location = new System.Drawing.Point(13, 32);
            this.txtIDHis.Name = "txtIDHis";
            this.txtIDHis.Size = new System.Drawing.Size(116, 23);
            this.txtIDHis.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID.Paciente";
            // 
            // txtIDPA
            // 
            this.txtIDPA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDPA.Enabled = false;
            this.txtIDPA.Location = new System.Drawing.Point(13, 81);
            this.txtIDPA.Name = "txtIDPA";
            this.txtIDPA.Size = new System.Drawing.Size(116, 23);
            this.txtIDPA.TabIndex = 3;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(268, 80);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(130, 23);
            this.btnBuscarPaciente.TabIndex = 4;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID. Diagnostico";
            // 
            // txtIDDIAG
            // 
            this.txtIDDIAG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDDIAG.Enabled = false;
            this.txtIDDIAG.Location = new System.Drawing.Point(13, 130);
            this.txtIDDIAG.Name = "txtIDDIAG";
            this.txtIDDIAG.Size = new System.Drawing.Size(116, 23);
            this.txtIDDIAG.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar Diagnostico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID. Medicamento";
            // 
            // txtIDMED
            // 
            this.txtIDMED.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDMED.Enabled = false;
            this.txtIDMED.Location = new System.Drawing.Point(13, 181);
            this.txtIDMED.Name = "txtIDMED";
            this.txtIDMED.Size = new System.Drawing.Size(116, 23);
            this.txtIDMED.TabIndex = 9;
            // 
            // btnBuscarMedicamento
            // 
            this.btnBuscarMedicamento.Location = new System.Drawing.Point(268, 180);
            this.btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            this.btnBuscarMedicamento.Size = new System.Drawing.Size(130, 23);
            this.btnBuscarMedicamento.TabIndex = 10;
            this.btnBuscarMedicamento.Text = "Buscar Medicamento";
            this.btnBuscarMedicamento.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamento.Click += new System.EventHandler(this.btnBuscarMedicamento_Click);
            // 
            // grdListaHistorial
            // 
            this.grdListaHistorial.AllowUserToAddRows = false;
            this.grdListaHistorial.AllowUserToDeleteRows = false;
            this.grdListaHistorial.AllowUserToResizeColumns = false;
            this.grdListaHistorial.AllowUserToResizeRows = false;
            this.grdListaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHistorial,
            this.IdPaciente,
            this.IDdiagnostico,
            this.IDmedicamento});
            this.grdListaHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaHistorial.Location = new System.Drawing.Point(13, 211);
            this.grdListaHistorial.Name = "grdListaHistorial";
            this.grdListaHistorial.RowTemplate.Height = 25;
            this.grdListaHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaHistorial.Size = new System.Drawing.Size(385, 186);
            this.grdListaHistorial.TabIndex = 11;
            this.grdListaHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaHistorial_CellContentClick);
            // 
            // IDHistorial
            // 
            this.IDHistorial.DataPropertyName = "IDHistorial";
            this.IDHistorial.HeaderText = "ID. Historial";
            this.IDHistorial.Name = "IDHistorial";
            this.IDHistorial.Width = 85;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            this.IdPaciente.HeaderText = "ID. Paciente";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.Width = 85;
            // 
            // IDdiagnostico
            // 
            this.IDdiagnostico.DataPropertyName = "IDdiagnostico";
            this.IDdiagnostico.HeaderText = "ID. Diagnostico";
            this.IDdiagnostico.Name = "IDdiagnostico";
            this.IDdiagnostico.Width = 85;
            // 
            // IDmedicamento
            // 
            this.IDmedicamento.DataPropertyName = "IDmedicamento";
            this.IDmedicamento.HeaderText = "ID. Medicamento";
            this.IDmedicamento.Name = "IDmedicamento";
            this.IDmedicamento.Width = 85;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 432);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(323, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(169, 432);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmHistorialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 467);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdListaHistorial);
            this.Controls.Add(this.btnBuscarMedicamento);
            this.Controls.Add(this.txtIDMED);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIDDIAG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtIDPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDHis);
            this.Controls.Add(this.label1);
            this.Name = "FrmHistorialPaciente";
            this.Text = "Historial Paciente";
            this.Load += new System.EventHandler(this.FrmHistorialPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDHis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPA;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDDIAG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDMED;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private System.Windows.Forms.DataGridView grdListaHistorial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDdiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDmedicamento;
    }
}