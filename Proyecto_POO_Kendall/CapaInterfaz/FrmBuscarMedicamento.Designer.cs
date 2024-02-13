
namespace CapaInterfaz
{
    partial class FrmBuscarMedicamento
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
            this.btnBucarM = new System.Windows.Forms.Button();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdBuscarMedicamento = new System.Windows.Forms.DataGridView();
            this.IDMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrucciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscarMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBucarM
            // 
            this.btnBucarM.Location = new System.Drawing.Point(504, 29);
            this.btnBucarM.Name = "btnBucarM";
            this.btnBucarM.Size = new System.Drawing.Size(75, 23);
            this.btnBucarM.TabIndex = 17;
            this.btnBucarM.Text = "Buscar";
            this.btnBucarM.UseVisualStyleBackColor = true;
            this.btnBucarM.Click += new System.EventHandler(this.btnBucarM_Click);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(12, 30);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(455, 23);
            this.txtNombreM.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(403, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(505, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdBuscarMedicamento
            // 
            this.grdBuscarMedicamento.AllowUserToAddRows = false;
            this.grdBuscarMedicamento.AllowUserToDeleteRows = false;
            this.grdBuscarMedicamento.AllowUserToResizeColumns = false;
            this.grdBuscarMedicamento.AllowUserToResizeRows = false;
            this.grdBuscarMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscarMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMedicamentos,
            this.NombreM,
            this.Descripcion,
            this.Instrucciones});
            this.grdBuscarMedicamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdBuscarMedicamento.Location = new System.Drawing.Point(12, 90);
            this.grdBuscarMedicamento.Name = "grdBuscarMedicamento";
            this.grdBuscarMedicamento.RowTemplate.Height = 25;
            this.grdBuscarMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBuscarMedicamento.Size = new System.Drawing.Size(567, 204);
            this.grdBuscarMedicamento.TabIndex = 20;
            this.grdBuscarMedicamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuscarMedicamento_CellContentClick);
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
            // FrmBuscarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.grdBuscarMedicamento);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBucarM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarMedicamento";
            this.Text = "Buscar Medicamento";
            this.Load += new System.EventHandler(this.FrmBuscarMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscarMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBucarM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdBuscarMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrucciones;
    }
}