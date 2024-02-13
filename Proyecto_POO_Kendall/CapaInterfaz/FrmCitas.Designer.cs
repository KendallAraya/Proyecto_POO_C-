
namespace CapaInterfaz
{
    partial class FrmCitas
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
            this.txtCita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.grdListaCitas = new System.Windows.Forms.DataGridView();
            this.IDCITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAGENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID. Cita";
            // 
            // txtCita
            // 
            this.txtCita.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCita.Enabled = false;
            this.txtCita.Location = new System.Drawing.Point(13, 32);
            this.txtCita.Name = "txtCita";
            this.txtCita.Size = new System.Drawing.Size(69, 23);
            this.txtCita.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID. Agenda Especialista";
            // 
            // txtAgenda
            // 
            this.txtAgenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAgenda.Enabled = false;
            this.txtAgenda.Location = new System.Drawing.Point(13, 81);
            this.txtAgenda.Name = "txtAgenda";
            this.txtAgenda.Size = new System.Drawing.Size(69, 23);
            this.txtAgenda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID. Funcionario";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(13, 130);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(69, 23);
            this.txtFuncionario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID. Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPaciente.Location = new System.Drawing.Point(12, 178);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(70, 23);
            this.txtPaciente.TabIndex = 7;
            // 
            // grdListaCitas
            // 
            this.grdListaCitas.AllowUserToAddRows = false;
            this.grdListaCitas.AllowUserToDeleteRows = false;
            this.grdListaCitas.AllowUserToResizeColumns = false;
            this.grdListaCitas.AllowUserToResizeRows = false;
            this.grdListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCITA,
            this.IDAGENDA,
            this.IDFuncionario,
            this.IDPaciente});
            this.grdListaCitas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaCitas.Location = new System.Drawing.Point(12, 223);
            this.grdListaCitas.Name = "grdListaCitas";
            this.grdListaCitas.RowTemplate.Height = 25;
            this.grdListaCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaCitas.Size = new System.Drawing.Size(360, 178);
            this.grdListaCitas.TabIndex = 8;
            this.grdListaCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaCitas_CellContentClick);
            // 
            // IDCITA
            // 
            this.IDCITA.DataPropertyName = "IDcita";
            this.IDCITA.HeaderText = "ID. Cita";
            this.IDCITA.Name = "IDCITA";
            this.IDCITA.Width = 79;
            // 
            // IDAGENDA
            // 
            this.IDAGENDA.DataPropertyName = "IDAgendaEspecialista";
            this.IDAGENDA.HeaderText = "ID. Agenda E.";
            this.IDAGENDA.Name = "IDAGENDA";
            this.IDAGENDA.Width = 79;
            // 
            // IDFuncionario
            // 
            this.IDFuncionario.DataPropertyName = "IdFuncionario";
            this.IDFuncionario.HeaderText = "ID. Funcionario";
            this.IDFuncionario.Name = "IDFuncionario";
            this.IDFuncionario.Width = 79;
            // 
            // IDPaciente
            // 
            this.IDPaciente.DataPropertyName = "IdPaciente";
            this.IDPaciente.HeaderText = "ID. Paciente";
            this.IDPaciente.Name = "IDPaciente";
            this.IDPaciente.Width = 79;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(248, 80);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(124, 23);
            this.btnAgenda.TabIndex = 10;
            this.btnAgenda.Text = "Buscar Agenda E.";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(248, 129);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(124, 23);
            this.btnFuncionario.TabIndex = 11;
            this.btnFuncionario.Text = "Buscar Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(248, 177);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(124, 23);
            this.btnPaciente.TabIndex = 12;
            this.btnPaciente.Text = "Buscar Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(296, 415);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 14;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(157, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.grdListaCitas);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCita);
            this.Controls.Add(this.label1);
            this.Name = "FrmCitas";
            this.Text = "Administrar Citas";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.DataGridView grdListaCitas;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAGENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPaciente;
    }
}