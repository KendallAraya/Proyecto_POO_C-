using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DAPagos
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadPagos Pago)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO Pagos (IdPaciente, IdFuncionario, Monto, FechaPago, TipoPago) VALUES(@IdPaciente, @IdFuncionario, @Monto, @FechaPago, @TipoPago) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@IdPaciente", Pago.GetIdPaciente());
            comando.Parameters.AddWithValue("@IdFuncionario", Pago.GetIdFuncionario());
            comando.Parameters.AddWithValue("@Monto", Pago.GetMonto());
            comando.Parameters.AddWithValue("@FechaPago", Pago.GetFechaRealiza());
            comando.Parameters.AddWithValue("@TipoPago", Pago.GetTipoPago());
            comando.CommandText = sentencia;
            //Ejecutar el comando 
            try
            {
                conexion.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return id;
        }

        //Devuelve un DataSet de pagos para mostrar en un diagrama
        public DataSet ListarPago(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IDfactura, IdPaciente, IdFuncionario, Monto,  FechaPago, TipoPago from Pagos";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} where {1}", sentencia, orden);
            }
            try
            {
                //Se prepara adapter 
                adapter = new SqlDataAdapter(sentencia, conexion);
                //ejecutar sentencia
                adapter.Fill(datos, "PAGOS");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        //Metodo recibe el ID del Pagos y devuelve la entidad cliente

        public EntidadPagos obtenerPagos(int id)
        {
            EntidadPagos Pagos = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IDfactura, IdPaciente, IdFuncionario, Monto,  FechaPago, TipoPago from Pagos where IDfactura = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Pagos = new EntidadPagos();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Pagos.IdFactura = dataReader.GetInt32(0);
                    Pagos.IdPaciente = dataReader.GetInt32(1);
                    Pagos.IdFuncionario = dataReader.GetString(2);
                    Pagos.Monto = Convert.ToDouble(dataReader.GetDecimal(3));
                    Pagos.FechaRealiza1 = dataReader.GetDateTime(4);
                    Pagos.TipoPago = dataReader.GetString(5);
                    Pagos.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Pagos;
        }

        public int modificarPagos(EntidadPagos pagos)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE Pagos SET IdPaciente= @IdPaciente, IdFuncionario= @IdFuncionario, Monto= @Monto, FechaPago= @FechaPago, TipoPago= @TipoPago WHERE IDfactura= @IDfactura";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IDfactura", pagos.IdFactura);
            comando.Parameters.AddWithValue("@IdPaciente", pagos.IdPaciente);
            comando.Parameters.AddWithValue("@IdFuncionario", pagos.IdFuncionario);
            comando.Parameters.AddWithValue("@Monto", pagos.Monto);
            comando.Parameters.AddWithValue("@TipoPago", pagos.TipoPago);
            comando.Parameters.AddWithValue("@FechaPago", pagos.FechaRealiza1);

            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }

        public int Eliminar(EntidadPagos pagos)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Pagos";
            sentencia = string.Format("{0} WHERE IDfactura = '{1}'", sentencia, pagos.IdFactura);
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                afectado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return afectado;
        }
    }
}
