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
    public partial class FrmCitas : Form
    {
        //Variable Global
        FrmBuscarAgenda formularioBuscarA;
        FrmBuscarFuncionario formularioBuscarF;
        FrmBuscarPacientes formularioBuscarP;
        //variable global para un cliente
        EntidadCitas CitaRegistrado;

        public FrmCitas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtCita.Text = string.Empty;
            txtAgenda.Text = string.Empty;
            txtFuncionario.Text = string.Empty;
            txtPaciente.Text = string.Empty;
        }

        private EntidadCitas GenerarEntidadCitas()
        {
            EntidadCitas Cita = new EntidadCitas();
            if (!string.IsNullOrEmpty(txtCita.Text))
            {
                Cita = CitaRegistrado;
            }
            else
            {
                Cita = new EntidadCitas();
            }
            //Cita.setIdCita(Convert.ToInt32(txtCita.Text));
            Cita.setIdAgenda(Convert.ToInt32(txtAgenda.Text));
            Cita.setIdFuncionario(txtFuncionario.Text);
            Cita.setIdPaciente(Convert.ToInt32(txtPaciente.Text));

            return Cita;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLCita logica = new BLCita(Configuracion.getConnectionString);
            EntidadCitas Citas;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtAgenda.Text) || !string.IsNullOrEmpty(txtFuncionario.Text) || !string.IsNullOrEmpty(txtPaciente.Text))
                {
                    Citas = GenerarEntidadCitas();
                    if (!Citas.Existe)
                    {
                        resultado = logica.Insertar(Citas);
                        Mensaje = logica.Mensaje ;
                    }
                    else
                    {
                        //resultado = logica.modificarDiagnostico(Citas);
                        Mensaje = "Cita modificado correctamente";

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

        //cargar la lista de Cita con un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLCita logica = new BLCita(Configuracion.getConnectionString);
            DataSet DSCita;
            try
            {
                DSCita = logica.ListarCita(condicion, orden);
                grdListaCitas.DataSource = DSCita;
                grdListaCitas.DataMember = DSCita.Tables["Citas"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFuncionario(string id)
        {
            EntidadFuncionario Funcionario = new EntidadFuncionario();
            BLFuncionarios traerFuncionario = new BLFuncionarios(Configuracion.getConnectionString);

            try
            {
                Funcionario = traerFuncionario.obtenerFuncionario(id);
                if (Funcionario != null)
                {
                    txtFuncionario.Text = Funcionario.IdFuncionario;

                }
                else
                {
                    MessageBox.Show("El Funcionario no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarFuncionario(object id, EventArgs e)
        {
            try
            {
                string idFuncionario = (string)id;

                if (idFuncionario != null)
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

        private void CargarPaciente(int id)
        {
            EntidadPaciente Paciente = new EntidadPaciente();
            BLPacientes traerPaciente = new BLPacientes(Configuracion.getConnectionString);

            try
            {
                Paciente = traerPaciente.ObtenerPaciente(id);
                if (Paciente != null)
                {
                    txtPaciente.Text = Paciente.IdPaciente.ToString();

                }
                else
                {
                    MessageBox.Show("El Paciente no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarPaciente(object id, EventArgs e)
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

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            formularioBuscarF = new FrmBuscarFuncionario();
            formularioBuscarF.Aceptar += new EventHandler(AceptarFuncionario);
            formularioBuscarF.ShowDialog();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            formularioBuscarP = new FrmBuscarPacientes();
            formularioBuscarP.Aceptar += new EventHandler(AceptarPaciente);
            formularioBuscarP.ShowDialog();
        }

        private void CargarAgenda(int id)
        {
            EntidadAgendaEspecialista Agenda = new EntidadAgendaEspecialista();
            BLAgendaEspecialista traerAgenda = new BLAgendaEspecialista(Configuracion.getConnectionString);

            try
            {
                Agenda = traerAgenda.ObtenerAgenda(id);
                if (Agenda != null)
                {
                    txtAgenda.Text = Agenda.IdAgenda.ToString();

                }
                else
                {
                    MessageBox.Show("la Agenda no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarAgenda(object id, EventArgs e)
        {
            try
            {
                int idAgenda = (int)id;

                if (idAgenda != -1)
                {
                    CargarAgenda(idAgenda);
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

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            formularioBuscarA = new FrmBuscarAgenda();
            formularioBuscarA.Aceptar += new EventHandler(AceptarAgenda);
            formularioBuscarA.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarCita(int id)
        {
            EntidadCitas Cita = new EntidadCitas();
            BLCita traerCita = new BLCita(Configuracion.getConnectionString);

            try
            {
                Cita = traerCita.ObtenerCita(id);
                if (Cita != null)
                {
                    txtCita.Text = Cita.IdCita.ToString();
                    txtAgenda.Text = Cita.IdAgenda.ToString();
                    txtFuncionario.Text = Cita.IdFuncionario;
                    txtPaciente.Text = Cita.IdPaciente.ToString();
                    CitaRegistrado = Cita;

                }
                else
                {
                    MessageBox.Show("La Cita no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int IDcita = (int)id;

                if (IDcita != -1)
                {
                    CargarCita(IDcita);
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

        private void grdListaCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaCitas.SelectedRows[0].Cells[0].Value;
                CargarCita(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCitas_Load(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadCitas Citas;
            int resultado;
            BLCita logica = new BLCita(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtCita.Text))
                {
                    Citas = logica.ObtenerCita(int.Parse(txtCita.Text));
                    if (Citas != null)
                    {
                        resultado = logica.Eliminar(Citas);
                        MessageBox.Show("Cita Eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("La Cita no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una Cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
