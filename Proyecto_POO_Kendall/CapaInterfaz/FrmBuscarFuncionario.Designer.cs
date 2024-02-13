
namespace CapaInterfaz
{
    partial class FrmBuscarFuncionario
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
            this.btnBucarF = new System.Windows.Forms.Button();
            this.txtNombreF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdListaFuncionario = new System.Windows.Forms.DataGridView();
            this.IDFUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoTrabaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(394, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(505, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBucarF
            // 
            this.btnBucarF.Location = new System.Drawing.Point(506, 30);
            this.btnBucarF.Name = "btnBucarF";
            this.btnBucarF.Size = new System.Drawing.Size(75, 23);
            this.btnBucarF.TabIndex = 14;
            this.btnBucarF.Text = "Buscar";
            this.btnBucarF.UseVisualStyleBackColor = true;
            this.btnBucarF.Click += new System.EventHandler(this.btnBucarF_Click);
            // 
            // txtNombreF
            // 
            this.txtNombreF.Location = new System.Drawing.Point(14, 31);
            this.txtNombreF.Name = "txtNombreF";
            this.txtNombreF.Size = new System.Drawing.Size(455, 23);
            this.txtNombreF.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
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
            this.PuestoTrabaja});
            this.grdListaFuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaFuncionario.Location = new System.Drawing.Point(11, 87);
            this.grdListaFuncionario.Name = "grdListaFuncionario";
            this.grdListaFuncionario.RowTemplate.Height = 25;
            this.grdListaFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaFuncionario.Size = new System.Drawing.Size(569, 181);
            this.grdListaFuncionario.TabIndex = 31;
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
            // FrmBuscarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.grdListaFuncionario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBucarF);
            this.Controls.Add(this.txtNombreF);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarFuncionario";
            this.Text = "Buscar Funcionario";
            this.Load += new System.EventHandler(this.FrmBuscarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBucarF;
        private System.Windows.Forms.TextBox txtNombreF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdListaFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoTrabaja;
    }
}