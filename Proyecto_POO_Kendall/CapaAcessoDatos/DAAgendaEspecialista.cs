using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DAAgendaEspecialista
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAAgendaEspecialista(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int RegistrarAgenda(EntidadAgendaEspecialista Agenda)
        {
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "RegistrarCita"; //el nombre del procedimineto almacenado
            //Se especifica que tipo de comando es, en este caso es un SP
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@idEspecialista", Agenda.IdEspecialista);
            comando.Parameters.AddWithValue("@horaInicio", Agenda.HoraInicio1);
            comando.Parameters.AddWithValue("@horaFinal", Agenda.HoraFinal1);
            comando.Parameters.AddWithValue("@fechaCita", Agenda.FechaCita1);
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

        public DataSet ListarAgenda(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IDAgendaEspecialista, IDEspecialista, HoraInicio, HoraFinal, FechaCita from AgendaEspecialista";

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
                adapter.Fill(datos, "Agenda");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        public DataSet ListarAgendaEspecialistas(string condicion)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ae.IDAgendaEspecialista, esp.NombreCompletoE, ae.HoraInicio, ae.HoraFinal, ae.FechaCita " +
                   "FROM AgendaEspecialista ae " +
                   "JOIN Especialidad esp ON ae.IDEspecialista = esp.IdEspecialista " +
                   "WHERE esp.NombreEspecialidad = '{0}'";


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

        //Metodo recibe el ID del Agenda y devuelve la entidad cliente

        public EntidadAgendaEspecialista ObtenerAgenda(int id)
        {
            EntidadAgendaEspecialista Agenda = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IDAgendaEspecialista, IDEspecialista, HoraInicio, HoraFinal, FechaCita from AgendaEspecialista where IDAgendaEspecialista = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Agenda = new EntidadAgendaEspecialista();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Agenda.IdAgenda = dataReader.GetInt32(0);
                    Agenda.IdEspecialista = dataReader.GetString(1);
                    Agenda.HoraInicio1 = dataReader.GetTimeSpan(2);
                    Agenda.HoraFinal1 = dataReader.GetTimeSpan(3);
                    Agenda.FechaCita1 = dataReader.GetDateTime(4);
                    Agenda.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Agenda;
        }

        public int Eliminar(EntidadAgendaEspecialista Agenda)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM AgendaEspecialista";
            sentencia = string.Format("{0} WHERE IDAgendaEspecialista = '{1}'", sentencia, Agenda.IdAgenda);
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
