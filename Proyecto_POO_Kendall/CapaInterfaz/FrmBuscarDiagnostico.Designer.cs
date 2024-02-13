
namespace CapaInterfaz
{
    partial class FrmBuscarDiagnostico
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
            this.GrdVista = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.IDdiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrdVista);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el diagnostico";
            // 
            // GrdVista
            // 
            this.GrdVista.AllowUserToAddRows = false;
            this.GrdVista.AllowUserToDeleteRows = false;
            this.GrdVista.AllowUserToResizeColumns = false;
            this.GrdVista.AllowUserToResizeRows = false;
            this.GrdVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDdiagnostico,
            this.IdEspecialista,
            this.FechaRealizacion,
            this.Resultados});
            this.GrdVista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdVista.Location = new System.Drawing.Point(7, 23);
            this.GrdVista.Name = "GrdVista";
            this.GrdVista.RowTemplate.Height = 25;
            this.GrdVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdVista.Size = new System.Drawing.Size(444, 295);
            this.GrdVista.TabIndex = 0;
            this.GrdVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVista_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(389, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IDdiagnostico
            // 
            this.IDdiagnostico.DataPropertyName = "IDdiagnostico";
            this.IDdiagnostico.HeaderText = "ID. Diagnostico";
            this.IDdiagnostico.Name = "IDdiagnostico";
            // 
            // IdEspecialista
            // 
            this.IdEspecialista.DataPropertyName = "IdEspecialista";
            this.IdEspecialista.HeaderText = "ID. Especialista";
            this.IdEspecialista.Name = "IdEspecialista";
            // 
            // FechaRealizacion
            // 
            this.FechaRealizacion.DataPropertyName = "FechaRealizacion";
            this.FechaRealizacion.HeaderText = "Fecha Realizacion";
            this.FechaRealizacion.Name = "FechaRealizacion";
            // 
            // Resultados
            // 
            this.Resultados.DataPropertyName = "Resultados";
            this.Resultados.HeaderText = "Resultados";
            this.Resultados.Name = "Resultados";
            // 
            // FrmBuscarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 377);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBuscarDiagnostico";
            this.Text = "Buscar Diagnostico";
            this.Load += new System.EventHandler(this.FrmBuscarDiagnostico_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GrdVista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDdiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultados;
    }
}