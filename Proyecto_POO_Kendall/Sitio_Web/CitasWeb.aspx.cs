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
    public partial class CitasWeb : System.Web.UI.Page
    {
        string mensajeScript = string.Empty;

        public void Limpiar()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadPaciente Paciente;
            BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);

            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    //El id se obtiene en el otro formulario
                    if (Session["id_del_paciente"] != null)
                    {
                        identificacion = int.Parse((Session["id_del_paciente"].ToString()));
                        Paciente = logica.ObtenerPaciente(identificacion);
                        if (Paciente.existe)
                        {
                            txtID.Text = Paciente.IdPaciente.ToString();
                            txtCedula.Text = Paciente.Cedula;
                            txtNombre.Text = Paciente.NombreCompleto;
                            txtTelefono.Text = Paciente.Telefono;
                            txtCorreo.Text = Paciente.CorreoElectro;
                            txtNacionalidad.Text = Paciente.Nacionalidad;
                            txtDireccion.Text = Paciente.Direccion;


                            txtID.Visible = true;
                        }
                        else
                        {
                            mensajeScript = string.Format("javascript:MostrarMnesaje('Cliente no encontrado')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

                        }
                    }
                    else
                    {
                        Limpiar();
                        txtID.Text = "-1";
                        txtID.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pacientes.aspx?origen=agendar");
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CargarListaDataSet(string condicion = "")
        {
            //carga el datagridview con el dataset
            BLAgendaEspecialista logica = new BLAgendaEspecialista(clsConfiguracion.getConnectionString);
            DataSet DSAgendas;

            try
            {
                DSAgendas = logica.ListarAgendaEspecialista(condicion);
                grdLista.DataSource = DSAgendas;
                grdLista.DataMember = DSAgendas.Tables[0].TableName;
                //Para que se visualicen los datos en web 
                grdLista.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado del DropDownList
            string condicion = cboEspecialidad.SelectedItem.Text;
            pnlLista.Visible = true;
            pnlAgendaEspecialistas.Visible = false;


            // Llamar a la función para cargar el DataGrid pasando la especialidad seleccionada como parámetro
            CargarListaDataSet(condicion);
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            string idAgendaEspecialista = e.CommandArgument.ToString();

            // Buscar la fila correspondiente en el GridView
            foreach (GridViewRow row in grdLista.Rows)
            {
                if (row.Cells[0].Text == idAgendaEspecialista)
                {
                    // Obtener los valores de las columnas del GridView
                    txtID_A.Text = row.Cells[0].Text;
                    txtNombreEspecialista.Text = row.Cells[1].Text;
                    txtHoraInicio.Text = row.Cells[2].Text;
                    txtHoraFinal.Text = row.Cells[3].Text;
                    txtFecha.Text = row.Cells[4].Text;

                    pnlLista.Visible = false;
                    pnlAgendaEspecialistas.Visible = true;
                    pnlCita.Visible = true;
                    break;
                }
            }
        }

        protected void btnLimpiarAgenda_Click(object sender, EventArgs e)
        {
            pnlLista.Visible = true;
            pnlAgendaEspecialistas.Visible = false;
            pnlCita.Visible = false;
        }

        //Generar la Entidad
        private EntidadCitasWeb GenerarEntidad()
        {
            EntidadCitasWeb Cita = new EntidadCitasWeb();

            Cita.SetIDAgendaEspecialista(Convert.ToInt32(txtID_A.Text));
            Cita.SetIDPaciente(Convert.ToInt32(txtID.Text));
            Cita.SetHoraInicio(TimeSpan.Parse(txtHoraInicoCita.Text));
            Cita.SetFecha(Convert.ToDateTime(txtFecha.Text));

            return Cita;
        }

        protected void btnSolicitud_Click(object sender, EventArgs e)
        {
            EntidadCitasWeb Cita;

            BLCitaWeb logica = new BLCitaWeb(clsConfiguracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text) &&
                    !string.IsNullOrEmpty(txtID_A.Text) &&
                    !string.IsNullOrEmpty(txtHoraInicoCita.Text) &&
                    !string.IsNullOrEmpty(txtFecha.Text))
                {
                    Cita = GenerarEntidad();

                    resultado = logica.Insertar(Cita);
                    
                    if (resultado > 0)
                    {
                        Limpiar();
                        pnlLista.Visible = false;
                        pnlAgendaEspecialistas.Visible = false;
                        pnlCita.Visible = false;
                        mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
                else
                {
                    mensajeScript = string.Format("javascript:MostrarMnesaje('Debe seleccionar un paciente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

            }
        }
    }
}