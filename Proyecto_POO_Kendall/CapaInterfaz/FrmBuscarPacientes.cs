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
    public partial class FrmBuscarPacientes : Form
    {
        public event EventHandler Aceptar;
        int vgn_id_Paciente;

        public FrmBuscarPacientes()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            DataSet DSPacientes;
            try
            {
                DSPacientes = logica.ListarPacientes(condicion, orden);
                grdVista.DataSource = DSPacientes;
                grdVista.DataMember = DSPacientes.Tables["Pacientes"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarPacientes_Load(object sender, EventArgs e)
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

        private void btnBucar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("NombreCompletoP like '%{0}%'", txtNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir el nombre a buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNombre.Focus();
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
            if (grdVista.SelectedRows.Count > 0)
            {
                vgn_id_Paciente = (int)grdVista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Paciente, null);
                Close();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
