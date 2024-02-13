
namespace CapaInterfaz
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.MnuMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuhistorialMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEspecialistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarDiagnosticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenuPrincipal
            // 
            this.MnuMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPacientes,
            this.funcionariosToolStripMenuItem,
            this.especialistasToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.medicamentosToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.diagnosticosToolStripMenuItem,
            this.MnuSalir});
            this.MnuMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuMenuPrincipal.Name = "MnuMenuPrincipal";
            this.MnuMenuPrincipal.Size = new System.Drawing.Size(775, 24);
            this.MnuMenuPrincipal.TabIndex = 0;
            this.MnuMenuPrincipal.Text = "menuStrip1";
            // 
            // MnuPacientes
            // 
            this.MnuPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAdministrar,
            this.MnuhistorialMedico});
            this.MnuPacientes.Image = global::CapaInterfaz.Properties.Resources.Erix_Subyarko_Medical_Hospital_Person_People_Profile_Patient_48;
            this.MnuPacientes.Name = "MnuPacientes";
            this.MnuPacientes.Size = new System.Drawing.Size(85, 20);
            this.MnuPacientes.Text = "Pacientes";
            // 
            // MnuAdministrar
            // 
            this.MnuAdministrar.Name = "MnuAdministrar";
            this.MnuAdministrar.Size = new System.Drawing.Size(182, 22);
            this.MnuAdministrar.Text = "Aministrar Pacientes";
            this.MnuAdministrar.Click += new System.EventHandler(this.MnuAdministrar_Click);
            // 
            // MnuhistorialMedico
            // 
            this.MnuhistorialMedico.Name = "MnuhistorialMedico";
            this.MnuhistorialMedico.Size = new System.Drawing.Size(182, 22);
            this.MnuhistorialMedico.Text = "Historial Medico";
            this.MnuhistorialMedico.Click += new System.EventHandler(this.MnuhistorialMedico_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarFuncionarioToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.Google_Noto_Emoji_People_Clothing_Objects_12206_rescue_workers_helmet_48;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // administrarFuncionarioToolStripMenuItem
            // 
            this.administrarFuncionarioToolStripMenuItem.Name = "administrarFuncionarioToolStripMenuItem";
            this.administrarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.administrarFuncionarioToolStripMenuItem.Text = "Administrar Funcionario";
            this.administrarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.administrarFuncionarioToolStripMenuItem_Click);
            // 
            // especialistasToolStripMenuItem
            // 
            this.especialistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarEspecialistasToolStripMenuItem,
            this.agendaEspecialistaToolStripMenuItem});
            this.especialistasToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.Microsoft_Fluentui_Emoji_3d_Health_Worker_3d_Medium_Light_48;
            this.especialistasToolStripMenuItem.Name = "especialistasToolStripMenuItem";
            this.especialistasToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.especialistasToolStripMenuItem.Text = "Especialistas";
            // 
            // administrarEspecialistasToolStripMenuItem
            // 
            this.administrarEspecialistasToolStripMenuItem.Name = "administrarEspecialistasToolStripMenuItem";
            this.administrarEspecialistasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.administrarEspecialistasToolStripMenuItem.Text = "Administrar Especialistas";
            this.administrarEspecialistasToolStripMenuItem.Click += new System.EventHandler(this.administrarEspecialistasToolStripMenuItem_Click);
            // 
            // agendaEspecialistaToolStripMenuItem
            // 
            this.agendaEspecialistaToolStripMenuItem.Name = "agendaEspecialistaToolStripMenuItem";
            this.agendaEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agendaEspecialistaToolStripMenuItem.Text = "Agenda Especialista";
            this.agendaEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.agendaEspecialistaToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("citasToolStripMenuItem.Image")));
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // administrarCitasToolStripMenuItem
            // 
            this.administrarCitasToolStripMenuItem.Name = "administrarCitasToolStripMenuItem";
            this.administrarCitasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.administrarCitasToolStripMenuItem.Text = "Administrar Citas";
            this.administrarCitasToolStripMenuItem.Click += new System.EventHandler(this.administrarCitasToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.Aha_Soft_Universal_Shop_Cash_register_64;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // administrarPagosToolStripMenuItem
            // 
            this.administrarPagosToolStripMenuItem.Name = "administrarPagosToolStripMenuItem";
            this.administrarPagosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.administrarPagosToolStripMenuItem.Text = "Administrar Pagos";
            this.administrarPagosToolStripMenuItem.Click += new System.EventHandler(this.administrarPagosToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarMedicamentosToolStripMenuItem});
            this.medicamentosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.Iconfactory_Kidcons_Medicine_32;
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // administrarMedicamentosToolStripMenuItem
            // 
            this.administrarMedicamentosToolStripMenuItem.Name = "administrarMedicamentosToolStripMenuItem";
            this.administrarMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.administrarMedicamentosToolStripMenuItem.Text = "Administrar Medicamentos";
            this.administrarMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.administrarMedicamentosToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_planner_64;
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // diagnosticosToolStripMenuItem
            // 
            this.diagnosticosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarDiagnosticosToolStripMenuItem});
            this.diagnosticosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.Erix_Subyarko_Medical_Medicine_Medicine_Tool_Doctor_Hospital_Stethoscope_64;
            this.diagnosticosToolStripMenuItem.Name = "diagnosticosToolStripMenuItem";
            this.diagnosticosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.diagnosticosToolStripMenuItem.Text = "Diagnosticos";
            // 
            // administrarDiagnosticosToolStripMenuItem
            // 
            this.administrarDiagnosticosToolStripMenuItem.Name = "administrarDiagnosticosToolStripMenuItem";
            this.administrarDiagnosticosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarDiagnosticosToolStripMenuItem.Text = "Administrar Diagnosticos";
            this.administrarDiagnosticosToolStripMenuItem.Click += new System.EventHandler(this.administrarDiagnosticosToolStripMenuItem_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Image = global::CapaInterfaz.Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_64;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(57, 20);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CapaInterfaz.Properties.Resources.v870_mynt_18;
            this.ClientSize = new System.Drawing.Size(775, 540);
            this.Controls.Add(this.MnuMenuPrincipal);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuMenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Clinica El Buen Vivir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuMenuPrincipal.ResumeLayout(false);
            this.MnuMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem MnuAdministrar;
        private System.Windows.Forms.ToolStripMenuItem MnuhistorialMedico;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEspecialistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaEspecialistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarDiagnosticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    }
}

