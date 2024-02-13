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
    public partial class Pacientes : System.Web.UI.Page
    {
        //Variable global
        string mensajeScript = string.Empty;

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

        protected void grdLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }

        protected void lnkEliminar_Command(object sender, CommandEventArgs e)
        {
            //Lee el ID, que es enviado por el CommandEvent

            int id = int.Parse(e.CommandArgument.ToString());

            BLPacientes Logica = new BLPacientes(clsConfiguracion.getConnectionString);
            EntidadPaciente Paciente;
            try
            {
                Paciente = Logica.ObtenerPaciente(id);
                if (Paciente.existe)
                {
                    if (Logica.EliminarConSP(Paciente) > 0)
                    {
                        //Mensaje 
                        mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", Logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                        txtNombre.Text = string.Empty;
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", Logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                        txtNombre.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void lnkMoficar_Command(object sender, CommandEventArgs e)
        {
            Session["id_del_paciente"] = e.CommandArgument.ToString();

            Response.Redirect("AdministarClientes.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Session.Remove("id_del_paciente");

            Response.Redirect("AdministarClientes.aspx");
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            Session["id_del_paciente"] = e.CommandArgument.ToString();
            //Redireccionamos 
            Response.Redirect("CitasWeb.aspx");
        }
    }
}