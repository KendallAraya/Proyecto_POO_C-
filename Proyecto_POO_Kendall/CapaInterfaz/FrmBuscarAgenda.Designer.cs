
namespace CapaInterfaz
{
    partial class FrmBuscarAgenda
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdListaCitas = new System.Windows.Forms.DataGridView();
            this.IDAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(389, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdListaCitas);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Cita en la Agenda Especialista";
            // 
            // grdListaCitas
            // 
            this.grdListaCitas.AllowUserToAddRows = false;
            this.grdListaCitas.AllowUserToDeleteRows = false;
            this.grdListaCitas.AllowUserToResizeColumns = false;
            this.grdListaCitas.AllowUserToResizeRows = false;
            this.grdListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAgenda,
            this.IDEspecialista,
            this.HoraInicio,
            this.HoraFinal,
            this.FechaCita});
            this.grdListaCitas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaCitas.Location = new System.Drawing.Point(6, 22);
            this.grdListaCitas.Name = "grdListaCitas";
            this.grdListaCitas.RowTemplate.Height = 25;
            this.grdListaCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaCitas.Size = new System.Drawing.Size(445, 296);
            this.grdListaCitas.TabIndex = 12;
            this.grdListaCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaCitas_CellContentClick_1);
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
            // FrmBuscarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 377);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBuscarAgenda";
            this.Text = "FrmBuscarAgenda";
            this.Load += new System.EventHandler(this.FrmBuscarAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdListaCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCita;
    }
}