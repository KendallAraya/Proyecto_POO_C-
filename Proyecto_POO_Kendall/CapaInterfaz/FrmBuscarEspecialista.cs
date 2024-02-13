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
    public partial class FrmBuscarEspecialista : Form
    {
        public event EventHandler Aceptar;
        string vgn_id_Especialista;

        public FrmBuscarEspecialista()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(null, null);
            Close();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEspecialista logica = new BLEspecialista(Configuracion.getConnectionString);
            DataSet DSEspecialista;
            try
            {
                DSEspecialista = logica.ListarEspecialista(condicion, orden);
                grdListaEspecialista.DataSource = DSEspecialista;
                grdListaEspecialista.DataMember = DSEspecialista.Tables["Especialista"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarEspecialista_Load(object sender, EventArgs e)
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

        private void btnBucarE_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreE.Text))
                {
                    condicion = string.Format("NombreCompletoE like '%{0}%'", txtNombreE.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir el nombre a buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNombreE.Focus();
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
            if (grdListaEspecialista.SelectedRows.Count > 0)
            {
                vgn_id_Especialista = (string)grdListaEspecialista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Especialista, null);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }
    }
}
