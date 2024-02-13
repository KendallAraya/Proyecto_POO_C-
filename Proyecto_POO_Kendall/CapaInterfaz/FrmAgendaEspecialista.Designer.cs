
namespace CapaInterfaz
{
    partial class FrmAgendaEspecialista
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
            this.txtIDAgenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEspecialista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.grdLisAgenda = new System.Windows.Forms.DataGridView();
            this.IDAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdLisAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID. Agenda Especialista";
            // 
            // txtIDAgenda
            // 
            this.txtIDAgenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDAgenda.Enabled = false;
            this.txtIDAgenda.Location = new System.Drawing.Point(13, 32);
            this.txtIDAgenda.Name = "txtIDAgenda";
            this.txtIDAgenda.Size = new System.Drawing.Size(100, 23);
            this.txtIDAgenda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID. Especialista";
            // 
            // txtIDEspecialista
            // 
            this.txtIDEspecialista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDEspecialista.Enabled = false;
            this.txtIDEspecialista.Location = new System.Drawing.Point(13, 81);
            this.txtIDEspecialista.Name = "txtIDEspecialista";
            this.txtIDEspecialista.Size = new System.Drawing.Size(100, 23);
            this.txtIDEspecialista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de la Cita";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(13, 228);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(212, 23);
            this.dtpFechaCita.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar Especialista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdLisAgenda
            // 
            this.grdLisAgenda.AllowUserToAddRows = false;
            this.grdLisAgenda.AllowUserToDeleteRows = false;
            this.grdLisAgenda.AllowUserToResizeColumns = false;
            this.grdLisAgenda.AllowUserToResizeRows = false;
            this.grdLisAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLisAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAgenda,
            this.IDEspecialista,
            this.HoraInicio,
            this.HoraFinal,
            this.FechaCita});
            this.grdLisAgenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdLisAgenda.Location = new System.Drawing.Point(13, 258);
            this.grdLisAgenda.Name = "grdLisAgenda";
            this.grdLisAgenda.RowTemplate.Height = 25;
            this.grdLisAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLisAgenda.Size = new System.Drawing.Size(486, 180);
            this.grdLisAgenda.TabIndex = 11;
            this.grdLisAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLisAgenda_CellContentClick);
            // 
            // IDAgenda
            // 
            this.IDAgenda.DataPropertyName = "IDAgendaEspecialista";
            this.IDAgenda.HeaderText = "ID. Agenda E.";
            this.IDAgenda.Name = "IDAgenda";
            this.IDAgenda.Width = 71;
            // 
            // IDEspecialista
            // 
            this.IDEspecialista.DataPropertyName = "IDEspecialista";
            this.IDEspecialista.HeaderText = "ID. Especialista";
            this.IDEspecialista.Name = "IDEspecialista";
            this.IDEspecialista.Width = 71;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // HoraFinal
            // 
            this.HoraFinal.DataPropertyName = "HoraFinal";
            this.HoraFinal.HeaderText = "Hora Final";
            this.HoraFinal.Name = "HoraFinal";
            // 
            // FechaCita
            // 
            this.FechaCita.DataPropertyName = "FechaCita";
            this.FechaCita.HeaderText = "Fecha Cita";
            this.FechaCita.Name = "FechaCita";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 493);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(424, 493);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(220, 493);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(13, 129);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(100, 23);
            this.dtpHoraInicio.TabIndex = 15;
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Enabled = false;
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(13, 179);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(100, 23);
            this.dtpHoraFinal.TabIndex = 16;
            // 
            // FrmAgendaEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 528);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdLisAgenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDEspecialista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDAgenda);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgendaEspecialista";
            this.Text = "W";
            this.Load += new System.EventHandler(this.FrmAgendaEspecialista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLisAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDAgenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEspecialista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdLisAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCita;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
    }
}