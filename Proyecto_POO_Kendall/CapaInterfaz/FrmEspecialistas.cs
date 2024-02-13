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
    public partial class FrmEspecialistas : Form
    {
        //Variable Global
        FrmBuscarEspecialista formularioBuscar;

        //variable global para un cliente
        EntidadEspecialista EspecialistaRegistrado;

        public FrmEspecialistas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtIDEspecialista.Text = string.Empty;
            txtCedulaE.Text = string.Empty;
            txtNombreE.Text = string.Empty;
            txtTelefonoE.Text = string.Empty;
            txtCorreoE.Text = string.Empty;
            txtNacionalidadE.Text = string.Empty;
            txtDireccionE.Text = string.Empty;
            cbxEspecialidades.SelectedIndex = 0;
            txtIDEspecialista.Focus();
        }

        //Generar la entidad Paciente
        private EntidadEspecialista GenerarEntidadEspecialista()
        {
            BLEspecialista logica = new BLEspecialista(Configuracion.getConnectionString);
            EntidadEspecialista Especialista = new EntidadEspecialista();
            if (logica.ExisteEspecialistaRegistrado(txtIDEspecialista.Text))
            {
                Especialista = EspecialistaRegistrado;
            }
            else
            {
                Especialista = new EntidadEspecialista();
            }

            Especialista.setIdEspecialidad(txtIDEspecialista.Text);
            Especialista.setCedula(txtCedulaE.Text);
            Especialista.setNombreCompleto(txtNombreE.Text);
            Especialista.setTelefono(txtTelefonoE.Text);
            Especialista.setCorreoElectro(txtCorreoE.Text);
            Especialista.setNacionalidad(txtNacionalidadE.Text);
            Especialista.setDireccion(txtDireccionE.Text);
            Especialista.setNombreEspecialidad(cbxEspecialidades.Text);

            return Especialista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLEspecialista logica = new BLEspecialista(Configuracion.getConnectionString);
            EntidadEspecialista especialista;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreE.Text) && !string.IsNullOrEmpty(txtTelefonoE.Text) && !string.IsNullOrEmpty(txtDireccionE.Text))
                {
                    especialista = GenerarEntidadEspecialista();
                    if (!especialista.Existe)
                    {
                        resultado = logica.Insertar(especialista);
                        Mensaje = "Especialista insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarEspecialista(especialista);
                        Mensaje = "Especialista modificado correctamente";

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

        //cargar la lista de funcionarios con un DataSet
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

        private void FrmEspecialistas_Load(object sender, EventArgs e)
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
        private void CargarEspecialista(string id)
        {
            EntidadEspecialista Especialista = new EntidadEspecialista();
            BLEspecialista traerFuncionario = new BLEspecialista(Configuracion.getConnectionString);

            try
            {
                Especialista = traerFuncionario.obtenerEspecialista(id);
                if (Especialista != null)
                {
                    txtIDEspecialista.Text = Especialista.IdEspecialidad;
                    txtCedulaE.Text = Especialista.Cedula;
                    txtNombreE.Text = Especialista.NombreCompleto;
                    txtTelefonoE.Text = Especialista.Telefono;
                    txtCorreoE.Text = Especialista.CorreoElectro;
                    txtDireccionE.Text = Especialista.Direccion;
                    txtNacionalidadE.Text = Especialista.Nacionalidad;
                    cbxEspecialidades.Text = (Especialista.NombreEspecialidad);
                    EspecialistaRegistrado = Especialista;
                }
                else
                {
                    MessageBox.Show("El Especialista no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string idEspecialista = (string)id;
                if (!string.IsNullOrEmpty(idEspecialista))
                {
                    CargarEspecialista(idEspecialista);
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
            
            formularioBuscar = new FrmBuscarEspecialista();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = string.Empty;
            try
            {
                //Recuperar el id de DGV
                id = (string)grdListaEspecialista.SelectedRows[0].Cells[0].Value;
                CargarEspecialista(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadEspecialista Especialista;
            int resultado;
            BLEspecialista logica = new BLEspecialista(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDEspecialista.Text))
                {
                    Especialista = logica.obtenerEspecialista(txtIDEspecialista.Text);
                    if (Especialista != null)
                    {
                        resultado = logica.EliminarEspecialista(Especialista);
                        MessageBox.Show("Especialista eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Especialista no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Especialista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
