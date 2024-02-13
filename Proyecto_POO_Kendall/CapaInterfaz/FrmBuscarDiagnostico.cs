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
    public partial class FrmBuscarDiagnostico : Form
    {
        public event EventHandler Aceptar;
        int vgn_id_Diagnostico;

        public FrmBuscarDiagnostico()
        {
            InitializeComponent();
        }

        //cargar la lista de Medicamentos con un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            DataSet DSMedicamentos;
            try
            {
                DSMedicamentos = logica.ListarDiagnostico(condicion, orden);
                GrdVista.DataSource = DSMedicamentos;
                GrdVista.DataMember = DSMedicamentos.Tables["Diagnostico"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarDiagnostico_Load(object sender, EventArgs e)
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
            if (GrdVista.SelectedRows.Count > 0)
            {
                vgn_id_Diagnostico = (int)GrdVista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Diagnostico, null);
                Close();
            }
        }

        private void GrdVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }
}
