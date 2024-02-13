
namespace CapaInterfaz
{
    partial class FrmEspecialistas
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
            this.cbxEspecialidades = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreoE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNacionalidadE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdListaEspecialista = new System.Windows.Forms.DataGridView();
            this.IDEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccionE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEspecialista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEspecialidades
            // 
            this.cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidades.FormattingEnabled = true;
            this.cbxEspecialidades.Items.AddRange(new object[] {
            "Pediatría",
            "Ginecología ",
            "Cardiología",
            "Dermatología",
            "Cardiología",
            "Oftalmología",
            "Odontología"});
            this.cbxEspecialidades.Location = new System.Drawing.Point(467, 94);
            this.cbxEspecialidades.Name = "cbxEspecialidades";
            this.cbxEspecialidades.Size = new System.Drawing.Size(121, 23);
            this.cbxEspecialidades.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 62;
            this.label8.Text = "Especialidades";
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.Location = new System.Drawing.Point(13, 95);
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.Size = new System.Drawing.Size(436, 23);
            this.txtCorreoE.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "Correo Electronico";
            // 
            // txtNacionalidadE
            // 
            this.txtNacionalidadE.Location = new System.Drawing.Point(467, 29);
            this.txtNacionalidadE.Name = "txtNacionalidadE";
            this.txtNacionalidadE.Size = new System.Drawing.Size(154, 23);
            this.txtNacionalidadE.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nacionalidad";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(687, 488);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(467, 488);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(244, 488);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 488);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.grdListaEspecialista.Location = new System.Drawing.Point(13, 234);
            this.grdListaEspecialista.Name = "grdListaEspecialista";
            this.grdListaEspecialista.RowTemplate.Height = 25;
            this.grdListaEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialista.Size = new System.Drawing.Size(749, 210);
            this.grdListaEspecialista.TabIndex = 52;
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
            // txtDireccionE
            // 
            this.txtDireccionE.Location = new System.Drawing.Point(12, 162);
            this.txtDireccionE.Multiline = true;
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.Size = new System.Drawing.Size(749, 56);
            this.txtDireccionE.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Direccion";
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.Location = new System.Drawing.Point(638, 29);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(127, 23);
            this.txtTelefonoE.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Telefono";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(260, 29);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(189, 23);
            this.txtNombreE.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre Completo";
            // 
            // txtCedulaE
            // 
            this.txtCedulaE.Location = new System.Drawing.Point(106, 29);
            this.txtCedulaE.Name = "txtCedulaE";
            this.txtCedulaE.Size = new System.Drawing.Size(137, 23);
            this.txtCedulaE.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cedula";
            // 
            // txtIDEspecialista
            // 
            this.txtIDEspecialista.Location = new System.Drawing.Point(13, 30);
            this.txtIDEspecialista.Name = "txtIDEspecialista";
            this.txtIDEspecialista.Size = new System.Drawing.Size(75, 23);
            this.txtIDEspecialista.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID. Especialista";
            // 
            // FrmEspecialistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 521);
            this.Controls.Add(this.cbxEspecialidades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreoE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNacionalidadE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grdListaEspecialista);
            this.Controls.Add(this.txtDireccionE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedulaE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDEspecialista);
            this.Controls.Add(this.label1);
            this.Name = "FrmEspecialistas";
            this.Text = "Administrar Especialistas";
            this.Load += new System.EventHandler(this.FrmEspecialistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreoE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNacionalidadE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdListaEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.TextBox txtDireccionE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEspecialista;
        private System.Windows.Forms.Label label1;
    }
}