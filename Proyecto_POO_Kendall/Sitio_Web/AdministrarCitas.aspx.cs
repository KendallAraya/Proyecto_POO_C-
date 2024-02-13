using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogica;

namespace Sitio_Web
{
    public partial class AdministrarCitas : System.Web.UI.Page
    {
        string mensajeScript = string.Empty;

        public void Limpiar()
        {
            txtID2.Text = string.Empty;
            txtNombre2.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtCedula2.Text = string.Empty;
            txtNacionalidad2.Text = string.Empty;
            txtCorreo2.Text = string.Empty;
            txtDireccion2.Text = string.Empty;
        }

        /// <summary>
        /// Carga el DataGridView con los datos de pacientes obtenidos desde el DataSet.
        /// </summary>
        /// <param name="condicion">Condición opcional para filtrar los pacientes.</param>
        /// <param name="orden">Orden opcional para ordenar los pacientes.</param>
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
            BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);
            DataSet DSPaciente;

            try
            {
                DSPaciente = logica.ListarPacientes(condicion, orden);
                grdLista.DataSource = DSPaciente;
                grdLista.DataMember = DSPaciente.Tables[0].TableName;
                //Para que se visualicen los datos en web 
                grdLista.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarListaDataSet();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón de buscar.
        /// Realiza una búsqueda de pacientes por nombre y carga el DataGridView con los resultados.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("NombreCompletoP LIKE '%{0}%'", txtNombre.Text);
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNombre.Text = string.Empty;
            CargarListaDataSet();
            pnlPacientes.Visible = true;
            pnlDatosPaciente.Visible = false;
            pnlCitas.Visible = false;
        }

        protected void grdLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            BLCitaWeb logica = new BLCitaWeb(clsConfiguracion.getConnectionString);
            string idPaciente = e.CommandArgument.ToString();
            DataSet DSCita;
            // Buscar la fila correspondiente en el GridView
            foreach (GridViewRow row in grdLista.Rows)
            {
                if (row.Cells[0].Text == idPaciente)
                {
                    // Obtener los valores de las columnas del GridView
                    txtID2.Text = row.Cells[0].Text;
                    txtCedula2.Text = row.Cells[1].Text;
                    txtNombre2.Text = row.Cells[2].Text;
                    txtTelefono2.Text = row.Cells[3].Text;
                    txtCorreo2.Text = row.Cells[4].Text;
                    txtNacionalidad2.Text = row.Cells[5].Text;
                    txtDireccion2.Text = row.Cells[6].Text;

                    pnlPacientes.Visible = false;
                    pnlDatosPaciente.Visible = true;
                    DSCita = logica.ListarCita(Convert.ToInt32(txtID2.Text));
                    grdCitas.DataSource = DSCita;
                    grdCitas.DataMember = DSCita.Tables[0].TableName;
                    //Para que se visualicen los datos en web 
                    grdCitas.DataBind();
                    pnlCitas.Visible = true;
                    break;
                }
            }
        }

        protected void lnkCancelar_Command(object sender, CommandEventArgs e)
        {
            BLCitaWeb logica = new BLCitaWeb(clsConfiguracion.getConnectionString);
            DataSet DSCita;
            int id = Convert.ToInt32(e.CommandArgument);

            try
            {
                logica.Eliminar(id);
                DSCita = logica.ListarCita(Convert.ToInt32(txtID2.Text));
                grdCitas.DataSource = DSCita;
                grdCitas.DataMember = DSCita.Tables[0].TableName;
                //Para que se visualicen los datos en web 
                grdCitas.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}