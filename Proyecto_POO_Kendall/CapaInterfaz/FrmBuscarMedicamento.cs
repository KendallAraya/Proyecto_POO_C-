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
    public partial class FrmBuscarMedicamento : Form
    {
        public event EventHandler Aceptar;
        int vgn_id_Medicina;

        public FrmBuscarMedicamento()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            DataSet DSMedicamentos;
            try
            {
                DSMedicamentos = logica.ListarMedicamentos(condicion, orden);
                grdBuscarMedicamento.DataSource = DSMedicamentos;
                grdBuscarMedicamento.DataMember = DSMedicamentos.Tables["Medicamentos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarMedicamento_Load(object sender, EventArgs e)
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

        private void btnBucarM_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreM.Text))
                {
                    condicion = string.Format("NombreMed like '%{0}%'", txtNombreM.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir el nombre a buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNombreM.Focus();
                }
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seleccionar()
        {
            if (grdBuscarMedicamento.SelectedRows.Count > 0)
            {
                vgn_id_Medicina = (int)grdBuscarMedicamento.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Medicina, null);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdBuscarMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
