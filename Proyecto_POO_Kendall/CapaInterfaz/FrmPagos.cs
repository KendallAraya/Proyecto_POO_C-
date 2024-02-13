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
    public partial class FrmPagos : Form
    {
        //Variable Global
        FrmBuscarPacientes formularioBuscarP;
        FrmBuscarFuncionario formularioBuscarF;

        EntidadPagos PagoRegistrado;

        public FrmPagos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIDFactura.Text = string.Empty;
            txtIDPaciente.Text = string.Empty;
            txtIDFuncionario.Text = string.Empty;
            txtMonto.Text = string.Empty;
            cboTipoPago.Text = string.Empty;
        }

        //Generar la entidad Medicamento
        private EntidadPagos GenerarEntidadPago()
        {
            EntidadPagos Pago = new EntidadPagos();
            if (!string.IsNullOrEmpty(txtIDFactura.Text))
            {
                Pago = PagoRegistrado;
            }
            else
            {
                Pago = new EntidadPagos();
            }
            Pago.SetIdPaciente(Convert.ToInt32(txtIDPaciente.Text));
            Pago.SetIdFuncionario(txtIDFuncionario.Text);
            Pago.SetMonto(Convert.ToDouble(txtMonto.Text));
            Pago.SetTipoPago(cboTipoPago.Text);
            Pago.SetFechaRealiza(dtpFechaPago.Value);

            return Pago;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLPagos logica = new BLPagos(Configuracion.getConnectionString);
            EntidadPagos Pago;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtIDFuncionario.Text) || !string.IsNullOrEmpty(txtIDPaciente.Text) || !string.IsNullOrEmpty(txtMonto.Text))
                {
                    Pago = GenerarEntidadPago();
                    if (!Pago.Existe)
                    {
                        resultado = logica.Insertar(Pago);
                        Mensaje = "Pago Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.modificarPago(Pago);
                        Mensaje = "Pago modificado correctamente";

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
            BLPagos logica = new BLPagos(Configuracion.getConnectionString);
            DataSet DSPagos;
            try
            {
                DSPagos = logica.ListarPago(condicion, orden);
                grdListaPagos.DataSource = DSPagos;
                grdListaPagos.DataMember = DSPagos.Tables["PAGOS"].TableName;

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
                    txtIDPaciente.Text = paciente.IdPaciente.ToString();

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

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            formularioBuscarP = new FrmBuscarPacientes();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarP.Aceptar += new EventHandler(AceptarPaciente);
            formularioBuscarP.ShowDialog();
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
                    txtIDFuncionario.Text = Funcionario.IdFuncionario;

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
                string IDFuncionario = (string)id;

                if (IDFuncionario != null)
                {
                    CargarFuncionario(IDFuncionario);
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
            //Especificar que se va a usar el evento aceptar
            formularioBuscarF.Aceptar += new EventHandler(AceptarFuncionario);
            formularioBuscarF.ShowDialog();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
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
        private void CargarPago(int id)
        {
            EntidadPagos Pago = new EntidadPagos();
            BLPagos traerPago = new BLPagos(Configuracion.getConnectionString);

            try
            {
                Pago = traerPago.ObtenerPago(id);
                if (Pago != null)
                {
                    txtIDFactura.Text = Pago.IdFactura.ToString();
                    txtIDPaciente.Text = Pago.IdPaciente.ToString();
                    txtIDFuncionario.Text = Pago.IdFuncionario;
                    txtMonto.Text = Pago.Monto.ToString();
                    cboTipoPago.Text = Pago.TipoPago;
                    PagoRegistrado = Pago;

                }
                else
                {
                    MessageBox.Show("el Pago no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int idPago = (int)id;

                if (idPago != -1)
                {
                    CargarPago(idPago);
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

        private void grdListaPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaPagos.SelectedRows[0].Cells[0].Value;
                CargarPago(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadPagos Pagos;
            int resultado;
            BLPagos logica = new BLPagos(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDFactura.Text))
                {
                    Pagos = logica.ObtenerPago(int.Parse(txtIDFactura.Text));
                    if (Pagos != null)
                    {
                        resultado = logica.Eliminar(Pagos);
                        MessageBox.Show("Pago Eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El Pago no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
