using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void MnuAdministrar_Click(object sender, EventArgs e)
        {
            FrmPacientes FrmP = new FrmPacientes();
            FrmP.Show();
        }

        private void administrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios FrmF = new FrmFuncionarios();
            FrmF.Show();
        }

        private void administrarEspecialistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecialistas FrmE = new FrmEspecialistas();
            FrmE.Show();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void administrarMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicamentos FrmM = new FrmMedicamentos();
            FrmM.Show();
        }

        private void administrarDiagnosticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiagnostico FrmD = new FrmDiagnostico();
            FrmD.Show();
        }

        private void MnuhistorialMedico_Click(object sender, EventArgs e)
        {
            FrmHistorialPaciente FrmH = new FrmHistorialPaciente();
            FrmH.Show();
        }

        private void administrarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagos FrmP = new FrmPagos();
            FrmP.Show();
        }

        private void agendaEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendaEspecialista FrmAE = new FrmAgendaEspecialista();
            FrmAE.Show();
        }

        private void administrarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCitas FrmC = new FrmCitas();
            FrmC.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacora FrmB = new FrmBitacora();
            FrmB.Show();
        }
    }
}
