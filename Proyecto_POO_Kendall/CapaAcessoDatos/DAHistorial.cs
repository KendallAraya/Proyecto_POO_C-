using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DAHistorial
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAHistorial(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadHistorial Historial)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO Historial_Clinico (IdPaciente, IDdiagnostico, IDmedicamento) VALUES(@IdPaciente, @IDdiagnostico, @IDmedicamento) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@IdPaciente", Historial.GetIdPaciente());
            comando.Parameters.AddWithValue("@IDdiagnostico", Historial.GetIdDiagnostico());
            comando.Parameters.AddWithValue("@IDmedicamento", Historial.GetIdMedicamento());
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

        //Devuelve un DataSet del Historial para mostrar en un diagrama
        public DataSet ListarHistorial(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IDHistorial, IdPaciente, IDdiagnostico, IDmedicamento from Historial_Clinico";

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
                adapter.Fill(datos, "Historial");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        public EntidadHistorial ObtenerHistorial(int id)
        {
            EntidadHistorial Historial = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IDHistorial, IdPaciente, IDdiagnostico, IDmedicamento from Historial_Clinico WHERE IDHistorial = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Historial = new EntidadHistorial();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Historial.IdHistorial = dataReader.GetInt32(0);
                    Historial.IdPaciente = dataReader.GetInt32(1);
                    Historial.IdDiagnostico = dataReader.GetInt32(2);
                    Historial.IdMedicamento = dataReader.GetInt32(3);
                    Historial.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Historial;
        }

        public int Eliminar(EntidadHistorial Historial)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Historial_Clinico";
            sentencia = string.Format("{0} WHERE IDHistorial = '{1}'", sentencia, Historial.IdHistorial);
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
