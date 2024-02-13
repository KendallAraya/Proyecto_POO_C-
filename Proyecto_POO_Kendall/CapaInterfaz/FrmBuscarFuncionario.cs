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
    public partial class FrmBuscarFuncionario : Form
    {
        public event EventHandler Aceptar;
        string vgn_id_Funcionario;

        public FrmBuscarFuncionario()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            DataSet DSFuncionario;
            try
            {
                DSFuncionario = logica.ListarFuncinario(condicion, orden);
                grdListaFuncionario.DataSource = DSFuncionario;
                grdListaFuncionario.DataMember = DSFuncionario.Tables["Funcionario"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarFuncionario_Load(object sender, EventArgs e)
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

        private void btnBucarF_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreF.Text))
                {
                    condicion = string.Format("NombreCompletoF like '%{0}%'", txtNombreF.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir el nombre a buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNombreF.Focus();
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
            if (grdListaFuncionario.SelectedRows.Count > 0)
            {
                vgn_id_Funcionario = (string)grdListaFuncionario.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Funcionario, null);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdListaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(null, null);
            Close();
        }
    }
}
