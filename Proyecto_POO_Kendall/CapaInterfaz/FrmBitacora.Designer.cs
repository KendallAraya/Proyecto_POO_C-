
namespace CapaInterfaz
{
    partial class FrmBitacora
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
            this.grdVistabitacora = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.IdBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdVistabitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVistabitacora
            // 
            this.grdVistabitacora.AllowUserToAddRows = false;
            this.grdVistabitacora.AllowUserToDeleteRows = false;
            this.grdVistabitacora.AllowUserToResizeColumns = false;
            this.grdVistabitacora.AllowUserToResizeRows = false;
            this.grdVistabitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVistabitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBitacora,
            this.Fecha,
            this.Hora,
            this.Movimiento});
            this.grdVistabitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdVistabitacora.Location = new System.Drawing.Point(13, 13);
            this.grdVistabitacora.Name = "grdVistabitacora";
            this.grdVistabitacora.RowTemplate.Height = 25;
            this.grdVistabitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVistabitacora.Size = new System.Drawing.Size(486, 361);
            this.grdVistabitacora.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(424, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // IdBitacora
            // 
            this.IdBitacora.DataPropertyName = "IdBitacora";
            this.IdBitacora.HeaderText = "ID. Bitacora";
            this.IdBitacora.Name = "IdBitacora";
            this.IdBitacora.Width = 60;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 80;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 80;
            // 
            // Movimiento
            // 
            this.Movimiento.DataPropertyName = "Movimiento";
            this.Movimiento.HeaderText = "Movimiento";
            this.Movimiento.Name = "Movimiento";
            this.Movimiento.Width = 222;
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdVistabitacora);
            this.Name = "FrmBitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVistabitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVistabitacora;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimiento;
    }
}