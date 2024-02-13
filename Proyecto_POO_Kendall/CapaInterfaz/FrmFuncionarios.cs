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

    public partial class FrmFuncionarios : Form
    {
        //Variable Global
        FrmBuscarFuncionario formularioBuscar;

        //variable global para un cliente
        EntidadFuncionario FuncionarioRegistrado;

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtIDFuncionario.Text = string.Empty;
            txtCedulaF.Text = string.Empty;
            txtNombreF.Text = string.Empty;
            txtTelefonoF.Text = string.Empty;
            txtCorreoF.Text = string.Empty;
            txtNacionalidadF.Text = string.Empty;
            txtDireccionF.Text = string.Empty;
            cbxPuestoTrabaja.SelectedIndex = 0;
            txtIDFuncionario.Focus();
        }

        //Generar la entidad Paciente
        private EntidadFuncionario GenerarEntidadFuncionario()
        {
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            EntidadFuncionario Funcionario = new EntidadFuncionario();
            if (logica.ExisteFuncionarioRegistrado(txtIDFuncionario.Text))
            {
                Funcionario = FuncionarioRegistrado;
            }
            else
            {
                Funcionario = new EntidadFuncionario();
            }

            Funcionario.setIdFuncionario(txtIDFuncionario.Text);
            Funcionario.setCedula(txtCedulaF.Text);
            Funcionario.setNombreCompleto(txtNombreF.Text);
            Funcionario.setTelefono(txtTelefonoF.Text);
            Funcionario.setCorreoElectro(txtCorreoF.Text);
            Funcionario.setNacionalidad(txtNacionalidadF.Text);
            Funcionario.setDireccion(txtDireccionF.Text);
            Funcionario.setPuestoTrabaja(cbxPuestoTrabaja.Text);

            return Funcionario;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            EntidadFuncionario Funcionario;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreF.Text) && !string.IsNullOrEmpty(txtTelefonoF.Text) && !string.IsNullOrEmpty(txtDireccionF.Text))
                {
                    Funcionario = GenerarEntidadFuncionario();
                    if (!Funcionario.Existe)
                    {
                        resultado = logica.Insertar(Funcionario);
                        Mensaje = "Funcionario insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarFuncionarios(Funcionario);
                        Mensaje = "Funcionario modificado correctamente";

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
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            DataSet DSPacientes;
            try
            {
                DSPacientes = logica.ListarFuncinario(condicion, orden);
                grdListaFuncionario.DataSource = DSPacientes;
                grdListaFuncionario.DataMember = DSPacientes.Tables["Funcionario"].TableName;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
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
        private void CargarFuncionario(string id)
        {
            EntidadFuncionario funcionario = new EntidadFuncionario();
            BLFuncionarios traerFuncionario = new BLFuncionarios(Configuracion.getConnectionString);
            


            try
            {
                funcionario = traerFuncionario.obtenerFuncionario(id);
                if (funcionario != null)
                {
                    txtIDFuncionario.Text = funcionario.IdFuncionario;
                    txtCedulaF.Text = funcionario.Cedula;
                    txtNombreF.Text = funcionario.NombreCompleto;
                    txtTelefonoF.Text = funcionario.Telefono;
                    txtCorreoF.Text = funcionario.CorreoElectro;
                    txtDireccionF.Text = funcionario.Direccion;
                    txtNacionalidadF.Text = funcionario.Nacionalidad;
                    cbxPuestoTrabaja.Text = (funcionario.PuestoTrabaja);
                    FuncionarioRegistrado = funcionario;
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
                string idFuncionario = (string)id;
                if (!string.IsNullOrEmpty(idFuncionario))
                {
                    CargarFuncionario(idFuncionario);
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
            formularioBuscar = new FrmBuscarFuncionario();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void grdListaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = string.Empty;
            try
            {
                //Recuperar el id de DGV
                id = (string)grdListaFuncionario.SelectedRows[0].Cells[0].Value;
                CargarFuncionario(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadFuncionario funcionario;
            int resultado;
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDFuncionario.Text))
                {
                    funcionario = logica.obtenerFuncionario(txtIDFuncionario.Text);
                    if (funcionario != null)
                    {


                        resultado = logica.EliminarFuncionario(funcionario);
                        MessageBox.Show("funcionario eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("funcionario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un funcionario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
