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
    public partial class FrmMedicamentos : Form
    {
        //Variable Global
        FrmBuscarMedicamento formularioBuscar;

        //variable global para un cliente
        EntidadMedicamentos MedicamentoRegistrado;

        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIDMedicamento.Text = string.Empty;
            txtNombreMedicamento.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtInstrucciones.Text = string.Empty;
        }

        //Generar la entidad Medicamento
        private EntidadMedicamentos GenerarEntidadMedicamento()
        {
            EntidadMedicamentos Medicamento = new EntidadMedicamentos();
            if (!string.IsNullOrEmpty(txtIDMedicamento.Text))
            {
                Medicamento = MedicamentoRegistrado;
            }
            else
            {
                Medicamento = new EntidadMedicamentos();
            }
            Medicamento.setnombreMed(txtNombreMedicamento.Text);
            Medicamento.setdescripcion(txtDescripcion.Text);
            Medicamento.setinstrucciones(txtInstrucciones.Text);

            return Medicamento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            EntidadMedicamentos Medicina;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreMedicamento.Text) && !string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtInstrucciones.Text))
                {
                    Medicina = GenerarEntidadMedicamento();
                    if (!Medicina.existe)
                    {
                        resultado = logica.Insertar(Medicina);
                        Mensaje = "Medicamento Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.modificarMedicamento(Medicina);
                        Mensaje = "Medicamento modificado correctamente";

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
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            DataSet DSPacientes;
            try
            {
                DSPacientes = logica.ListarMedicamentos(condicion, orden);
                GrdListaMedicamentos.DataSource = DSPacientes;
                GrdListaMedicamentos.DataMember = DSPacientes.Tables["Medicamentos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Cargar los datos del cliente por medio del id
        private void CargarMedicina(int id)
        {
            EntidadMedicamentos Medicina = new EntidadMedicamentos();
            BLMedicamentos traerMedicina = new BLMedicamentos(Configuracion.getConnectionString);

            try
            {
                Medicina = traerMedicina.ObtenerMedicina(id);
                if (Medicina != null)
                {
                    txtIDMedicamento.Text = Medicina.IdMedicamento.ToString();
                    txtNombreMedicamento.Text = Medicina.NombreMed;
                    txtDescripcion.Text = Medicina.Descripcion;
                    txtInstrucciones.Text = Medicina.Instrucciones;
                    MedicamentoRegistrado = Medicina;

                }
                else
                {
                    MessageBox.Show("La medicina no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int idMedicina = (int)id;

                if (idMedicina != -1)
                {
                    CargarMedicina(idMedicina);
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
            formularioBuscar = new FrmBuscarMedicamento();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void GrdListaMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)GrdListaMedicamentos.SelectedRows[0].Cells[0].Value;
                CargarMedicina(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadMedicamentos Medicamento;
            int resultado;
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDMedicamento.Text))
                {
                    Medicamento = logica.ObtenerMedicina(int.Parse(txtIDMedicamento.Text));
                    if (Medicamento != null)
                    {
                        resultado = logica.Eliminar(Medicamento);
                        MessageBox.Show("Medicamento Eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El Medicamento no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Medicamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
