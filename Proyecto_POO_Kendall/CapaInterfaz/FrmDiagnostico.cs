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
    public partial class FrmDiagnostico : Form
    {
        //Variable Global
        FrmBuscarEspecialista formularioBuscar;
        //variable global para un cliente
        EntidadDiagnostico DiagnosticoRegistrado;

        public FrmDiagnostico()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtIDDiag.Text = string.Empty;
            txtIDEspecialista.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            txtResultados.Text = string.Empty;
        }

        //Generar la entidad Medicamento
        private EntidadDiagnostico GenerarEntidadDiagnostico()
        {
            EntidadDiagnostico Diagnostico = new EntidadDiagnostico();
            if (!string.IsNullOrEmpty(txtIDDiag.Text))
            {
                Diagnostico = DiagnosticoRegistrado;
            }
            else
            {
                Diagnostico = new EntidadDiagnostico();
            }
            Diagnostico.setIdEspecialista(txtIDEspecialista.Text);
            Diagnostico.setFechaRealizacion(dtpFecha.Value);
            Diagnostico.setResultados(txtResultados.Text);

            return Diagnostico;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            EntidadDiagnostico Diagnostico;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtResultados.Text))
                {
                    Diagnostico = GenerarEntidadDiagnostico();
                    if (!Diagnostico.Existe)
                    {
                        resultado = logica.Insertar(Diagnostico);
                        Mensaje = "Diagnostico Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.modificarDiagnostico(Diagnostico);
                        Mensaje = "Diagnostico modificado correctamente";

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
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            DataSet DSDiagnostico;
            try
            {
                DSDiagnostico = logica.ListarDiagnostico(condicion, orden);
                GrdListaDiagnostico.DataSource = DSDiagnostico;
                GrdListaDiagnostico.DataMember = DSDiagnostico.Tables["Diagnostico"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarEspecialista_Click(object sender, EventArgs e)
        {
            formularioBuscar = new FrmBuscarEspecialista();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(AceptarEspecialidad);
            formularioBuscar.ShowDialog();
        }

        //Cargar los datos del cliente por medio del id
        private void CargarEspecialidad(string id)
        {
            EntidadEspecialista Especialidad = new EntidadEspecialista();
            BLEspecialista traerMedicina = new BLEspecialista(Configuracion.getConnectionString);

            try
            {
                Especialidad = traerMedicina.obtenerEspecialista(id);
                if (Especialidad != null)
                {
                    txtIDEspecialista.Text = Especialidad.IdEspecialidad;
                    
                }
                else
                {
                    MessageBox.Show("La Especialidad no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarDiagnostico(int id)
        {
            EntidadDiagnostico Diagnostico = new EntidadDiagnostico();
            BLDiagnostico traerMedicina = new BLDiagnostico(Configuracion.getConnectionString);

            try
            {
                Diagnostico = traerMedicina.ObtenerDiagnostico(id);
                if (Diagnostico != null)
                {
                    txtIDDiag.Text = Diagnostico.IdDiagnostico.ToString();
                    txtIDEspecialista.Text = Diagnostico.IdEspecialista;
                    dtpFecha.Value = (DateTime)Diagnostico.FechaRealizacion1;
                    txtResultados.Text = Diagnostico.Resultados1;
                    DiagnosticoRegistrado = Diagnostico;

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
                int idDiagnostico = (int)id;

                if (idDiagnostico != -1)
                {
                    CargarDiagnostico(idDiagnostico);
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

        private void AceptarEspecialidad(object id, EventArgs e)
        {
            try
            {
                string idEspecialidad = (string)id;

                if (idEspecialidad != null)
                {
                    CargarEspecialidad(idEspecialidad);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GrdListaDiagnostico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)GrdListaDiagnostico.SelectedRows[0].Cells[0].Value;
                CargarDiagnostico(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDiagnostico_Load(object sender, EventArgs e)
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
            EntidadDiagnostico Diagnostico;
            int resultado;
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDDiag.Text))
                {
                    Diagnostico = logica.ObtenerDiagnostico(int.Parse(txtIDDiag.Text));
                    if (Diagnostico != null)
                    {
                        resultado = logica.Eliminar(Diagnostico);
                        MessageBox.Show("Diagnostico Eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El Diagnostico no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Diagnostico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
