using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaInterfaz
{
    public partial class FrmBuscarAgenda : Form
    {
        public event EventHandler Aceptar;
        int vgn_id_Agenda;

        public FrmBuscarAgenda()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLAgendaEspecialista logica = new BLAgendaEspecialista(Configuracion.getConnectionString);
            DataSet DSAgenda;
            try
            {
                DSAgenda = logica.ListarAgenda(condicion, orden);
                grdListaCitas.DataSource = DSAgenda;
                grdListaCitas.DataMember = DSAgenda.Tables["Agenda"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarAgenda_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Seleccionar()
        {
            if (grdListaCitas.SelectedRows.Count > 0)
            {
                vgn_id_Agenda = (int)grdListaCitas.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Agenda, null);
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void grdListaCitas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }
    }
}
