
namespace CapaInterfaz
{
    partial class FrmFuncionarios
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
            this.txtCorreoF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNacionalidadF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdListaFuncionario = new System.Windows.Forms.DataGridView();
            this.IDFUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoTrabaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccionF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPuestoTrabaja = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreoF
            // 
            this.txtCorreoF.Location = new System.Drawing.Point(13, 95);
            this.txtCorreoF.Name = "txtCorreoF";
            this.txtCorreoF.Size = new System.Drawing.Size(436, 23);
            this.txtCorreoF.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Correo Electronico";
            // 
            // txtNacionalidadF
            // 
            this.txtNacionalidadF.Location = new System.Drawing.Point(467, 29);
            this.txtNacionalidadF.Name = "txtNacionalidadF";
            this.txtNacionalidadF.Size = new System.Drawing.Size(154, 23);
            this.txtNacionalidadF.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nacionalidad";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(687, 488);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 488);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(226, 488);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 488);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdListaFuncionario
            // 
            this.grdListaFuncionario.AllowUserToAddRows = false;
            this.grdListaFuncionario.AllowUserToDeleteRows = false;
            this.grdListaFuncionario.AllowUserToResizeColumns = false;
            this.grdListaFuncionario.AllowUserToResizeRows = false;
            this.grdListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFUNCIONARIO,
            this.Cedula,
            this.NombreCom,
            this.Telefono,
            this.Correo,
            this.Nacionalidad,
            this.PuestoTrabaja,
            this.Direccion});
            this.grdListaFuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaFuncionario.Location = new System.Drawing.Point(13, 234);
            this.grdListaFuncionario.Name = "grdListaFuncionario";
            this.grdListaFuncionario.RowTemplate.Height = 25;
            this.grdListaFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaFuncionario.Size = new System.Drawing.Size(749, 210);
            this.grdListaFuncionario.TabIndex = 30;
            this.grdListaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaFuncionario_CellContentClick);
            // 
            // IDFUNCIONARIO
            // 
            this.IDFUNCIONARIO.DataPropertyName = "IdFuncionario";
            this.IDFUNCIONARIO.HeaderText = "ID. Funcionario";
            this.IDFUNCIONARIO.Name = "IDFUNCIONARIO";
            this.IDFUNCIONARIO.Width = 65;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CedulaF";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // NombreCom
            // 
            this.NombreCom.DataPropertyName = "NombreCompletoF";
            this.NombreCom.HeaderText = "Nombre Completo";
            this.NombreCom.Name = "NombreCom";
            this.NombreCom.Width = 160;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TelefonoF";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoElecF";
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.Name = "Correo";
            this.Correo.Width = 160;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "NacionalidadF";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // PuestoTrabaja
            // 
            this.PuestoTrabaja.DataPropertyName = "PuestoTrabajaF";
            this.PuestoTrabaja.HeaderText = "Puesto Trabaja";
            this.PuestoTrabaja.Name = "PuestoTrabaja";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "DireccionF";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // txtDireccionF
            // 
            this.txtDireccionF.Location = new System.Drawing.Point(12, 162);
            this.txtDireccionF.Multiline = true;
            this.txtDireccionF.Name = "txtDireccionF";
            this.txtDireccionF.Size = new System.Drawing.Size(749, 56);
            this.txtDireccionF.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Direccion";
            // 
            // txtTelefonoF
            // 
            this.txtTelefonoF.Location = new System.Drawing.Point(638, 29);
            this.txtTelefonoF.Name = "txtTelefonoF";
            this.txtTelefonoF.Size = new System.Drawing.Size(127, 23);
            this.txtTelefonoF.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefono";
            // 
            // txtNombreF
            // 
            this.txtNombreF.Location = new System.Drawing.Point(260, 29);
            this.txtNombreF.Name = "txtNombreF";
            this.txtNombreF.Size = new System.Drawing.Size(189, 23);
            this.txtNombreF.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre Completo";
            // 
            // txtCedulaF
            // 
            this.txtCedulaF.Location = new System.Drawing.Point(106, 29);
            this.txtCedulaF.Name = "txtCedulaF";
            this.txtCedulaF.Size = new System.Drawing.Size(137, 23);
            this.txtCedulaF.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cedula";
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(13, 30);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(75, 23);
            this.txtIDFuncionario.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID. Funcionario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Puesto Trabaja";
            // 
            // cbxPuestoTrabaja
            // 
            this.cbxPuestoTrabaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPuestoTrabaja.FormattingEnabled = true;
            this.cbxPuestoTrabaja.Items.AddRange(new object[] {
            "Secretario",
            "Administrador",
            "Conserje",
            "Asistente"});
            this.cbxPuestoTrabaja.Location = new System.Drawing.Point(467, 94);
            this.cbxPuestoTrabaja.Name = "cbxPuestoTrabaja";
            this.cbxPuestoTrabaja.Size = new System.Drawing.Size(121, 23);
            this.cbxPuestoTrabaja.TabIndex = 41;
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 521);
            this.Controls.Add(this.cbxPuestoTrabaja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreoF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNacionalidadF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grdListaFuncionario);
            this.Controls.Add(this.txtDireccionF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedulaF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "FrmFuncionarios";
            this.Text = "Administrar Funcionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreoF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNacionalidadF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdListaFuncionario;
        private System.Windows.Forms.TextBox txtDireccionF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPuestoTrabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoTrabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}