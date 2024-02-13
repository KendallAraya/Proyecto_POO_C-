using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class FrmAgendaEspecialista : Form
    {
        //Variable Global
        FrmBuscarEspecialista formularioBuscar;

        //variable global 
        EntidadAgendaEspecialista AgendaRegistrado;

        public FrmAgendaEspecialista()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtIDAgenda.Text = string.Empty;
            txtIDEspecialista.Text = string.Empty;
            TimeSpan horaActual = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DateTime fechaHoraActual = DateTime.Now;
            DateTime fechaActual = fechaHoraActual.Date;
            horaActual = fechaHoraActual.TimeOfDay;
            DateTime horaFechaActual = fechaActual.Add(horaActual);
            dtpHoraInicio.Value = horaFechaActual;
            dtpHoraFinal.Value = horaFechaActual.AddMinutes(30);
            dtpFechaCita.Value = DateTime.Now;
            
        }

        //Generar la entidad 
        private EntidadAgendaEspecialista GenerarEntidadAgenda()
        {
            BLAgendaEspecialista logica = new BLAgendaEspecialista(Configuracion.getConnectionString);
            EntidadAgendaEspecialista Agenda = new EntidadAgendaEspecialista();
            if (!string.IsNullOrEmpty(txtIDAgenda.Text))
            {
                Agenda = AgendaRegistrado;
            }
            else
            {
                Agenda = new EntidadAgendaEspecialista();
            }


            TimeSpan horaInicio = dtpHoraInicio.Value.TimeOfDay;
            TimeSpan horaFinal = horaInicio.Add(TimeSpan.FromMinutes(30));
            // Establecer los milisegundos en cero
            horaInicio = new TimeSpan(horaInicio.Hours, horaInicio.Minutes, horaInicio.Seconds);
            DateTime dateTimeInicio = DateTime.Today.Add(horaInicio);
            DateTime dateTimeFinal = dateTimeInicio.AddMinutes(30);
            horaFinal = dateTimeFinal.TimeOfDay;

            Agenda.setIdEspecialista(txtIDEspecialista.Text);
            Agenda.setHoraInicio(horaInicio);
            Agenda.setHoraFinal(horaFinal);
            Agenda.setFechaCita(dtpFechaCita.Value);
            

            return Agenda;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLAgendaEspecialista logica = new BLAgendaEspecialista(Configuracion.getConnectionString);
            EntidadAgendaEspecialista Agenda;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtIDEspecialista.Text))
                {
                    Agenda = GenerarEntidadAgenda();
                    if (!Agenda.Existe)
                    {
                        resultado = logica.Insertar(Agenda);
                        Mensaje = logica.Mensaje;
                    }
                    else
                    {
                        //resultado = logica.modificarDiagnostico(Agenda);
                        Mensaje = "Agenda modificado correctamente";

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

        //cargar la lista de Medicamentos con un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLAgendaEspecialista logica = new BLAgendaEspecialista(Configuracion.getConnectionString);
            DataSet DSDiagnostico;
            try
            {
                DSDiagnostico = logica.ListarAgenda(condicion, orden);
                grdLisAgenda.DataSource = DSDiagnostico;
                grdLisAgenda.DataMember = DSDiagnostico.Tables["Agenda"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEspecialista(string id)
        {
            EntidadEspecialista Especialista = new EntidadEspecialista();
            BLEspecialista traerEspecialistaE = new BLEspecialista(Configuracion.getConnectionString);

            try
            {
                Especialista = traerEspecialistaE.obtenerEspecialista(id);
                if (Especialista != null)
                {
                    txtIDEspecialista.Text = Especialista.IdEspecialidad;

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

        private void AceptarEspecialista(object id, EventArgs e)
        {
            try
            {
                string IDEspecialista = (string)id;

                if (IDEspecialista != null)
                {
                    CargarEspecialista(IDEspecialista);
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

        private void button1_Click(object sender, EventArgs e)
        {
            formularioBuscar = new FrmBuscarEspecialista();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(AceptarEspecialista);
            formularioBuscar.ShowDialog();
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
                    txtIDAgenda.Text = Agenda.IdAgenda.ToString();
                    txtIDEspecialista.Text = Agenda.IdEspecialista;
                    dtpHoraInicio.Value = DateTime.Today + Agenda.HoraInicio1;
                    dtpHoraFinal.Value = DateTime.Today + Agenda.HoraFinal1;
                    dtpFechaCita.Value = (DateTime)Agenda.FechaCita1;
                    AgendaRegistrado = Agenda;

                }
                else
                {
                    MessageBox.Show("El Diagnostico no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void grdLisAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdLisAgenda.SelectedRows[0].Cells[0].Value;
                CargarAgenda(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAgendaEspecialista_Load(object sender, EventArgs e)
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
            EntidadAgendaEspecialista Agenda;
            int resultado;
            BLAgendaEspecialista logica = new BLAgendaEspecialista(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDAgenda.Text))
                {
                    Agenda = logica.ObtenerAgenda(int.Parse(txtIDAgenda.Text));
                    if (Agenda != null)
                    {
                        resultado = logica.Eliminar(Agenda);
                        MessageBox.Show("Agenda Eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("La Agenda no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una Agenda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
