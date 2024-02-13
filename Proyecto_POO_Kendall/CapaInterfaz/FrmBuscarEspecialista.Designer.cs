
namespace CapaInterfaz
{
    partial class FrmBuscarEspecialista
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBucarE = new System.Windows.Forms.Button();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdListaEspecialista = new System.Windows.Forms.DataGridView();
            this.IDEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(394, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(505, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBucarE
            // 
            this.btnBucarE.Location = new System.Drawing.Point(506, 30);
            this.btnBucarE.Name = "btnBucarE";
            this.btnBucarE.Size = new System.Drawing.Size(75, 23);
            this.btnBucarE.TabIndex = 34;
            this.btnBucarE.Text = "Buscar";
            this.btnBucarE.UseVisualStyleBackColor = true;
            this.btnBucarE.Click += new System.EventHandler(this.btnBucarE_Click);
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(14, 31);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(455, 23);
            this.txtNombreE.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // grdListaEspecialista
            // 
            this.grdListaEspecialista.AllowUserToAddRows = false;
            this.grdListaEspecialista.AllowUserToDeleteRows = false;
            this.grdListaEspecialista.AllowUserToResizeColumns = false;
            this.grdListaEspecialista.AllowUserToResizeRows = false;
            this.grdListaEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEspecialista,
            this.Cedula,
            this.NombreCom,
            this.Telefono,
            this.Correo,
            this.Nacionalidad,
            this.Especialidad});
            this.grdListaEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaEspecialista.Location = new System.Drawing.Point(12, 90);
            this.grdListaEspecialista.Name = "grdListaEspecialista";
            this.grdListaEspecialista.RowTemplate.Height = 25;
            this.grdListaEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialista.Size = new System.Drawing.Size(569, 181);
            this.grdListaEspecialista.TabIndex = 53;
            this.grdListaEspecialista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaEspecialista_CellContentClick);
            // 
            // IDEspecialista
            // 
            this.IDEspecialista.DataPropertyName = "IdEspecialista";
            this.IDEspecialista.HeaderText = "ID. Especialista";
            this.IDEspecialista.Name = "IDEspecialista";
            this.IDEspecialista.Width = 65;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CedulaE";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // NombreCom
            // 
            this.NombreCom.DataPropertyName = "NombreCompletoE";
            this.NombreCom.HeaderText = "Nombre Completo";
            this.NombreCom.Name = "NombreCom";
            this.NombreCom.Width = 160;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TelefonoE";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoElecE";
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.Name = "Correo";
            this.Correo.Width = 160;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "NacionalidadE";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "NombreEspecialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // FrmBuscarEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.grdListaEspecialista);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBucarE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarEspecialista";
            this.Text = "FrmBuscarEspecialista";
            this.Load += new System.EventHandler(this.FrmBuscarEspecialista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBucarE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdListaEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}