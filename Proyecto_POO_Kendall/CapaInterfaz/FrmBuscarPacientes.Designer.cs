
namespace CapaInterfaz
{
    partial class FrmBuscarPacientes
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBucar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grdVista = new System.Windows.Forms.DataGridView();
            this.IDPACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdVista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(455, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // btnBucar
            // 
            this.btnBucar.Location = new System.Drawing.Point(505, 31);
            this.btnBucar.Name = "btnBucar";
            this.btnBucar.Size = new System.Drawing.Size(75, 23);
            this.btnBucar.TabIndex = 2;
            this.btnBucar.Text = "Buscar";
            this.btnBucar.UseVisualStyleBackColor = true;
            this.btnBucar.Click += new System.EventHandler(this.btnBucar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(504, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(393, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grdVista
            // 
            this.grdVista.AllowUserToAddRows = false;
            this.grdVista.AllowUserToDeleteRows = false;
            this.grdVista.AllowUserToResizeColumns = false;
            this.grdVista.AllowUserToResizeRows = false;
            this.grdVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPACIENTE,
            this.Cedula,
            this.NombreCom,
            this.Telefono,
            this.Correo,
            this.Nacionalidad,
            this.Direccion});
            this.grdVista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdVista.Location = new System.Drawing.Point(10, 86);
            this.grdVista.Name = "grdVista";
            this.grdVista.RowTemplate.Height = 25;
            this.grdVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVista.Size = new System.Drawing.Size(569, 181);
            this.grdVista.TabIndex = 11;
            this.grdVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVista_CellContentClick);
            // 
            // IDPACIENTE
            // 
            this.IDPACIENTE.DataPropertyName = "IdPaciente";
            this.IDPACIENTE.HeaderText = "ID. Paciente";
            this.IDPACIENTE.Name = "IDPACIENTE";
            this.IDPACIENTE.Width = 65;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CedulaP";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // NombreCom
            // 
            this.NombreCom.DataPropertyName = "NombreCompletoP";
            this.NombreCom.HeaderText = "Nombre Completo";
            this.NombreCom.Name = "NombreCom";
            this.NombreCom.Width = 170;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TelefonoP";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoElecP";
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.Name = "Correo";
            this.Correo.Width = 170;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "NacionalidadP";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "DireccionP";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // FrmBuscarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.grdVista);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBucar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarPacientes";
            this.Text = "Buscar Pacientes";
            this.Load += new System.EventHandler(this.FrmBuscarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBucar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView grdVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}