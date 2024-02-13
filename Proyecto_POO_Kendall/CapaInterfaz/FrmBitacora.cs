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
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLBitacora logica = new BLBitacora(Configuracion.getConnectionString);
            DataSet DSBitacora;
            try
            {
                DSBitacora = logica.ListarBitacora(condicion, orden);
                grdVistabitacora.DataSource = DSBitacora;
                grdVistabitacora.DataMember = DSBitacora.Tables["Bitacora"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
