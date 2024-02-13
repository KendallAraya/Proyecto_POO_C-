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
    public partial class FrmHistorialPaciente : Form
    {
        //Variable Global
        FrmBuscarPacientes formularioBuscarP;
        FrmBuscarDiagnostico formularioBuscarD;
        FrmBuscarMedicamento formularioBuscarM;
        EntidadHistorial HistorialRegistrado;

        public FrmHistorialPaciente()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIDHis.Text = string.Empty;
            txtIDPA.Text = string.Empty;
            txtIDDIAG.Text = string.Empty;
            txtIDMED.Text = string.Empty;
        }

        //Generar la entidad Medicamento
        private EntidadHistorial GenerarEntidadHistorial()
        {
            EntidadHistorial Historial = new EntidadHistorial();
            if (!string.IsNullOrEmpty(txtIDHis.Text))
            {
                Historial = HistorialRegistrado;
            }
            else
            {
                Historial = new EntidadHistorial();
            }
            Historial.SetIdPaciente(Convert.ToInt32(txtIDPA.Text));
            Historial.SetIdDiagnostico(Convert.ToInt32(txtIDDIAG.Text));
            Historial.SetIdMedicamento(Convert.ToInt32(txtIDMED.Text));

            return Historial;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLHistorial logica = new BLHistorial(Configuracion.getConnectionString);
            EntidadHistorial Historial;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtIDPA.Text) || !string.IsNullOrEmpty(txtIDMED.Text) || !string.IsNullOrEmpty(txtIDDIAG.Text))
                {
                    Historial = GenerarEntidadHistorial();
                    if (!Historial.Existe)
                    {
                        resultado = logica.Insertar(Historial);
                        Mensaje = "Historial Insertado correctamente";
                    }
                    else
                    {
                        //resultado = logica.modificarDiagnostico(Historial);
                        //Mensaje = "Diagnostico modificado correctamente";

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
            BLHistorial logica = new BLHistorial(Configuracion.getConnectionString);
            DataSet DSDiagnostico;
            try
            {
                DSDiagnostico = logica.ListarHistorial(condicion, orden);
                grdListaHistorial.DataSource = DSDiagnostico;
                grdListaHistorial.DataMember = DSDiagnostico.Tables["Historial"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPacientes(int id)
        {
            EntidadPaciente paciente = new EntidadPaciente();
            BLPacientes traerpACIENTE = new BLPacientes(Configuracion.getConnectionString);

            try
            {
                paciente = traerpACIENTE.ObtenerPaciente(id);
                if (paciente != null)
                {
                    txtIDPA.Text = paciente.IdPaciente.ToString();

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

        private void AceptarPaciente(object id, EventArgs e)
        {
            try
            {
                int IDpaciente = (int)id;

                if (IDpaciente != -1)
                {
                    CargarPacientes(IDpaciente);
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

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            formularioBuscarP = new FrmBuscarPacientes();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarP.Aceptar += new EventHandler(AceptarPaciente);
            formularioBuscarP.ShowDialog();
        }

        private void CargarMedicamento(int id)
        {
            EntidadMedicamentos Medicamento = new EntidadMedicamentos();
            BLMedicamentos traerMedicamento = new BLMedicamentos(Configuracion.getConnectionString);

            try
            {
                Medicamento = traerMedicamento.ObtenerMedicina(id);
                if (Medicamento != null)
                {
                    txtIDMED.Text = Medicamento.IdMedicamento.ToString();

                }
                else
                {
                    MessageBox.Show("El Medicamento no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarMedicina(object id, EventArgs e)
        {
            try
            {
                int IDmedicina = (int)id;

                if (IDmedicina != -1)
                {
                    CargarMedicamento(IDmedicina);
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

        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            formularioBuscarM = new FrmBuscarMedicamento();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarM.Aceptar += new EventHandler(AceptarMedicina);
            formularioBuscarM.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDiagnostico(int id)
        {
            EntidadDiagnostico Diagnostico = new EntidadDiagnostico();
            BLDiagnostico traerDiagnostico = new BLDiagnostico(Configuracion.getConnectionString);

            try
            {
                Diagnostico = traerDiagnostico.ObtenerDiagnostico(id);
                if (Diagnostico != null)
                {
                    txtIDDIAG.Text = Diagnostico.IdDiagnostico.ToString();

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

        private void AceptarDiagnostico(object id, EventArgs e)
        {
            try
            {
                int IDDiagnostico = (int)id;

                if (IDDiagnostico != -1)
                {
                    CargarDiagnostico(IDDiagnostico);
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
            formularioBuscarD = new FrmBuscarDiagnostico();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarD.Aceptar += new EventHandler(AceptarDiagnostico);
            formularioBuscarD.ShowDialog();
        }

        private void FrmHistorialPaciente_Load(object sender, EventArgs e)
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
            EntidadHistorial Historial;
            int resultado;
            BLHistorial logica = new BLHistorial(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDHis.Text))
                {
                    Historial = logica.ObtenerHistorial(int.Parse(txtIDHis.Text));
                    if (Historial != null)
                    {
                        resultado = logica.Eliminar(Historial);
                        MessageBox.Show("Historial Eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El Historial no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Historial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorial(int id)
        {
            EntidadHistorial Historial = new EntidadHistorial();
            BLHistorial traerHistorial = new BLHistorial(Configuracion.getConnectionString);

            try
            {
                Historial = traerHistorial.ObtenerHistorial(id);
                if (Historial != null)
                {
                    txtIDHis.Text = Historial.IdHistorial.ToString();
                    txtIDPA.Text = Historial.IdPaciente.ToString();
                    txtIDDIAG.Text = Historial.IdDiagnostico.ToString();
                    txtIDMED.Text = Historial.IdMedicamento.ToString();

                }
                else
                {
                    MessageBox.Show("El Historial no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grdListaHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaHistorial.SelectedRows[0].Cells[0].Value;
                CargarHistorial(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
