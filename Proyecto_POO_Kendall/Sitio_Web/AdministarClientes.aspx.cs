using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogica;

namespace Sitio_Web
{
    public partial class AdministarClientes : System.Web.UI.Page
    {

        string mensajeScript = "";

        /// <summary>
        /// Limpia los campos de entrada de texto en el formulario.
        /// </summary>
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

        /// <summary>
        /// Evento que se ejecuta al cargar la página.
        /// Recupera los datos del paciente y los muestra en los controles de la interfaz de usuario.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
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

                            txtCedula.Enabled = false;
                            txtID.Visible = true;
                        }
                        else
                        {
                            mensajeScript = string.Format("javascript:MostrarMnesaje('Paciente no encontrado')");
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

                Response.Redirect("Pacientes.aspx");
            }
        }

        /// <summary>
        /// Genera y devuelve una instancia de la clase EntidadPaciente con los datos ingresados en los controles de la interfaz de usuario.
        /// </summary>
        /// <returns>Instancia de la clase EntidadPaciente con los datos ingresados.</returns>
        private EntidadPaciente GenerarEntidad()
        {
            EntidadPaciente Paciente = new EntidadPaciente();
            if (Session["id_del_paciente"] != null)
            {
                Paciente.IdPaciente = int.Parse(Session["id_del_paciente"].ToString());
                Paciente.existe = true;
            }
            else
            {
                Paciente.IdPaciente = -1;
                Paciente.existe = false;
            }
            Paciente.setCedula(txtCedula.Text);
            Paciente.setNombreCompleto(txtNombre.Text);
            Paciente.setTelefono(txtTelefono.Text);
            Paciente.setCorreoElectro(txtCorreo.Text);
            Paciente.setNacionalidad(txtNacionalidad.Text);
            Paciente.setDireccion(txtDireccion.Text);
            return Paciente;
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Guardar".
        /// Guarda o modifica los datos del paciente en la base de datos, según corresponda.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadPaciente Pacientes;

            BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCedula.Text) &&
                    !string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtTelefono.Text) &&
                    !string.IsNullOrEmpty(txtNacionalidad.Text) &&
                    !string.IsNullOrEmpty(txtCorreo.Text) &&
                    !string.IsNullOrEmpty(txtDireccion.Text))
                {
                    Pacientes = GenerarEntidad();
                    if (!Pacientes.existe)
                    {
                        resultado = logica.Insertar(Pacientes);
                    }
                    else
                    {
                        resultado = logica.ModificarPacientes(Pacientes);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        Response.Redirect("Pacientes.aspx");
                    }
                    else
                    {
                        txtCedula.Text = string.Empty;
                        txtCedula.Focus();
                        mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
                else
                {
                    mensajeScript = string.Format("javascript:MostrarMnesaje('Los datos son obligatorios')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:MostrarMnesaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pacientes.aspx");
        }
    }
}