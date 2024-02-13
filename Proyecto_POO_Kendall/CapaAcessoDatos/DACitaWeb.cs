using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DACitaWeb
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DACitaWeb(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        /// <summary>
        /// Inserta una cita web en la base de datos.
        /// </summary>
        /// <param name="Cita">La entidad de la cita web a insertar.</param>
        /// <returns>El resultado de la operación de inserción.</returns>
        public int Insertar(EntidadCitasWeb Cita)
        {
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "AgendarCitaWeb"; 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@IDAgendaEspecialista", Cita.IDAgendaEspecialista1);
            comando.Parameters.AddWithValue("@IdPaciente", Cita.IdPaciente1);
            comando.Parameters.AddWithValue("@HoraInicioCita", Cita.HoraInicio1);
            comando.Parameters.AddWithValue("@FechaCita", Cita.Fecha1);

            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            //se declara otro parametro de retorno del SP que optenga el retorno de SP
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@Resultado"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }


            return resultado;
        }

        /// <summary>
        /// Obtiene los datos de las citas web según la condición especificada.
        /// </summary>
        /// <param name="condicion">La condición para filtrar las citas web.</param>
        /// <returns>Un DataSet con los datos de las citas web.</returns>
        public DataSet ListarCitas(int condicion)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT CW.IDcitaWeb, CW.IDAgendaEspecialista, P.NombreCompletoP, CW.HoraInico, CW.Fecha " +
                                "FROM CitasWeb CW " +
                                "JOIN Pacientes P ON CW.IdPaciente = P.IdPaciente " +
                                "WHERE CW.IdPaciente = {0} ";

            sentencia = string.Format(sentencia, condicion);

            try
            {
                //Se prepara adapter 
                adapter = new SqlDataAdapter(sentencia, conexion);
                //ejecutar sentencia
                adapter.Fill(datos, "Agenda");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        /// <summary>
        /// Elimina una cita web según el ID especificado.
        /// </summary>
        /// <param name="id">El ID de la cita web a eliminar.</param>
        /// <returns>El número de filas afectadas por la eliminación.</returns>
        public int Eliminar(int id)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM CitasWeb";
            sentencia = string.Format("{0} WHERE IDcitaWeb = '{1}'", sentencia, id);
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

