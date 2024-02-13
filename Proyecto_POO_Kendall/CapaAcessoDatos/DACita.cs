using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DACita
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DACita(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Ingresar(EntidadCitas Cita)
        {
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "IngresarCita"; //el nombre del procedimineto almacenado
            //Se especifica que tipo de comando es, en este caso es un SP
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@IDAgendaEspecialista", Cita.IdAgenda);
            comando.Parameters.AddWithValue("@IDFuncionario", Cita.IdFuncionario);
            comando.Parameters.AddWithValue("@IDPaciente", Cita.IdPaciente);
            //parametro de salida del SP
            comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            //se declara otro parametro de retorno del SP que optenga el retorno de SP
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@mensaje"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }


            return resultado;
        }

        //Devuelve un DataSet de Citas para mostrar en un diagrama
        public DataSet ListarCita(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IDcita, IDAgendaEspecialista, IdFuncionario, IdPaciente from Citas";

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
                adapter.Fill(datos, "Citas");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        public EntidadCitas ObtenerCita(int id)
        {
            EntidadCitas Cita = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IDcita, IDAgendaEspecialista, IdFuncionario, IdPaciente from Citas where IDcita = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Cita = new EntidadCitas();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Cita.IdCita = dataReader.GetInt32(0);
                    Cita.IdAgenda = dataReader.GetInt32(1);
                    Cita.IdFuncionario = dataReader.GetString(2);
                    Cita.IdPaciente = dataReader.GetInt32(3);
                    Cita.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Cita;
        }

        public int Eliminar(EntidadCitas Cita)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Citas";
            sentencia = string.Format("{0} WHERE IDcita = '{1}'", sentencia, Cita.IdCita);
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
