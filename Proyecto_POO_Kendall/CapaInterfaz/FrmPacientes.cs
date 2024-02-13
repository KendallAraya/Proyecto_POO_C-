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
    public partial class FrmPacientes : Form
    {

        //Variable Global
        FrmBuscarPacientes formularioBuscar;

        //variable global para un cliente
        EntidadPaciente PacienteRegistrado;

        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Limpiar()
        {
            txtIDpaciente.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCedula.Focus();
        }

        //Generar la entidad Paciente
        private EntidadPaciente GenerarEntidadPaciente()
        {
            EntidadPaciente Paciente = new EntidadPaciente();
            if (!string.IsNullOrEmpty(txtIDpaciente.Text))
            {
                Paciente = PacienteRegistrado;
            }
            else
            {
                Paciente = new EntidadPaciente();
            }
            Paciente.setCedula(txtCedula.Text);
            Paciente.setNombreCompleto(txtNombre.Text);
            Paciente.setTelefono(txtTelefono.Text);
            Paciente.setCorreoElectro(txtCorreo.Text);
            Paciente.setNacionalidad(txtNacionalidad.Text);
            Paciente.setDireccion(txtDireccion.Text);

            return Paciente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            EntidadPaciente Paciente;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtDireccion.Text))
                {
                    Paciente = GenerarEntidadPaciente();
                    if (!Paciente.existe)
                    {
                        resultado = logica.Insertar(Paciente);
                        Mensaje = "Paciente Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarPacientes(Paciente);
                        Mensaje = "Paciente modificado correctamente";

                    }
                    Limpiar();
                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Datos Obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cargar la lista de clientes con un DataSet
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

        private void FrmPacientes_Load(object sender, EventArgs e)
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

        //Cargar los datos del cliente por medio del id
        private void CargarPaciente(int id)
        {
            EntidadPaciente Paciente = new EntidadPaciente();
            BLPacientes traerPaciente = new BLPacientes(Configuracion.getConnectionString);

            try
            {
                Paciente = traerPaciente.ObtenerPaciente(id);
                if (Paciente != null)
                {
                    txtIDpaciente.Text = Paciente.IdPaciente.ToString();
                    txtCedula.Text = Paciente.Cedula;
                    txtNombre.Text = Paciente.NombreCompleto;
                    txtTelefono.Text = Paciente.Telefono;
                    txtCorreo.Text = Paciente.CorreoElectro;
                    txtDireccion.Text = Paciente.Direccion;
                    txtNacionalidad.Text = Paciente.Nacionalidad;
                    PacienteRegistrado = Paciente;
                }
                else
                {
                    MessageBox.Show("El paciente no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idPaciente = (int)id;

                if (idPaciente != -1)
                {
                    CargarPaciente(idPaciente);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //FrmBuscarClientes frm = new FrmBuscarClientes();
            //frm.Show();
            formularioBuscar = new FrmBuscarPacientes();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void grdVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdVista.SelectedRows[0].Cells[0].Value;
                CargarPaciente(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadPaciente Paciente;
            int resultado;
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDpaciente.Text))
                {
                    Paciente = logica.ObtenerPaciente(int.Parse(txtIDpaciente.Text));
                    if (Paciente != null)
                    {
                        resultado = logica.EliminarConSP(Paciente);
                        MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El paciente no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
