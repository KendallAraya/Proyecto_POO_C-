
namespace CapaInterfaz
{
    partial class FrmPagos
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
            this.txtIDFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.grdListaPagos = new System.Windows.Forms.DataGridView();
            this.IDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID. Factura";
            // 
            // txtIDFactura
            // 
            this.txtIDFactura.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDFactura.Enabled = false;
            this.txtIDFactura.Location = new System.Drawing.Point(13, 32);
            this.txtIDFactura.Name = "txtIDFactura";
            this.txtIDFactura.Size = new System.Drawing.Size(63, 23);
            this.txtIDFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID. Paciente";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDPaciente.Enabled = false;
            this.txtIDPaciente.Location = new System.Drawing.Point(13, 81);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(63, 23);
            this.txtIDPaciente.TabIndex = 3;
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
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDFuncionario.Enabled = false;
            this.txtIDFuncionario.Location = new System.Drawing.Point(13, 130);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(63, 23);
            this.txtIDFuncionario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(13, 179);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(63, 23);
            this.txtMonto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "SINPE Movil",
            "Tarjeta Credito/Debito"});
            this.cboTipoPago.Location = new System.Drawing.Point(13, 228);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(211, 23);
            this.cboTipoPago.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha del pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(13, 277);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(211, 23);
            this.dtpFechaPago.TabIndex = 11;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(255, 81);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(117, 23);
            this.btnPaciente.TabIndex = 12;
            this.btnPaciente.Text = "Buscar Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(255, 129);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(117, 23);
            this.btnFuncionario.TabIndex = 13;
            this.btnFuncionario.Text = "Buscar Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // grdListaPagos
            // 
            this.grdListaPagos.AllowUserToAddRows = false;
            this.grdListaPagos.AllowUserToDeleteRows = false;
            this.grdListaPagos.AllowUserToResizeColumns = false;
            this.grdListaPagos.AllowUserToResizeRows = false;
            this.grdListaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFactura,
            this.IDPaciente,
            this.IDFuncionario,
            this.Monto,
            this.TipoPago,
            this.FechaPago});
            this.grdListaPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaPagos.Location = new System.Drawing.Point(13, 321);
            this.grdListaPagos.Name = "grdListaPagos";
            this.grdListaPagos.RowTemplate.Height = 25;
            this.grdListaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaPagos.Size = new System.Drawing.Size(359, 167);
            this.grdListaPagos.TabIndex = 14;
            this.grdListaPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaPagos_CellContentClick);
            // 
            // IDFactura
            // 
            this.IDFactura.DataPropertyName = "IDfactura";
            this.IDFactura.HeaderText = "ID. Factura";
            this.IDFactura.Name = "IDFactura";
            this.IDFactura.Width = 50;
            // 
            // IDPaciente
            // 
            this.IDPaciente.DataPropertyName = "IdPaciente";
            this.IDPaciente.HeaderText = "ID. Paciente";
            this.IDPaciente.Name = "IDPaciente";
            this.IDPaciente.Width = 50;
            // 
            // IDFuncionario
            // 
            this.IDFuncionario.DataPropertyName = "IdFuncionario";
            this.IDFuncionario.HeaderText = "ID. Funcionario";
            this.IDFuncionario.Name = "IDFuncionario";
            this.IDFuncionario.Width = 50;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 50;
            // 
            // TipoPago
            // 
            this.TipoPago.DataPropertyName = "TipoPago";
            this.TipoPago.HeaderText = "Tipo Pago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Width = 70;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Width = 70;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 543);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(296, 542);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(159, 543);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 578);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdListaPagos);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDFactura);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagos";
            this.Text = "Administrar Pagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.DataGridView grdListaPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
    }
}