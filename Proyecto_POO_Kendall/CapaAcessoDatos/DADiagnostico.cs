using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DADiagnostico
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DADiagnostico(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadDiagnostico Diag)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO Diagnosticos (IdEspecialista, FechaRealizacion, Resultados) VALUES(@IdEspecialista, @FechaRealizacion, @Resultados) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@IdEspecialista", Diag.getIdEspecialista());
            comando.Parameters.AddWithValue("@FechaRealizacion", Diag.getFechaRealizacion());
            comando.Parameters.AddWithValue("@Resultados", Diag.getResultados());
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

        //Devuelve un DataSet de Diagnostico para mostrar en un diagrama
        public DataSet ListarDiagnostico(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IDdiagnostico, IdEspecialista, FechaRealizacion, Resultados from Diagnosticos";

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
                adapter.Fill(datos, "Diagnostico");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        //Metodo recibe el ID del diagnostico y devuelve la entidad cliente

        public EntidadDiagnostico ObtenerDiagnostico(int id)
        {
            EntidadDiagnostico Diagnostico = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IDdiagnostico, IdEspecialista, FechaRealizacion, Resultados from Diagnosticos where IDdiagnostico = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Diagnostico = new EntidadDiagnostico();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Diagnostico.IdDiagnostico = dataReader.GetInt32(0);
                    Diagnostico.IdEspecialista = dataReader.GetString(1);
                    Diagnostico.FechaRealizacion1 = dataReader.GetDateTime(2);
                    Diagnostico.Resultados1 = dataReader.GetString(3);
                    Diagnostico.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Diagnostico;
        }

        public int modificarDiagnostico(EntidadDiagnostico Diagnostico)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE Diagnosticos SET IdEspecialista= @IdEspecialista, FechaRealizacion= @FechaRealizacion1, Resultados= @Resultados1 WHERE IdDiagnostico= @IdDiagnostico";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IdDiagnostico", Diagnostico.IdDiagnostico);
            comando.Parameters.AddWithValue("@IdEspecialista", Diagnostico.IdEspecialista);
            comando.Parameters.AddWithValue("@FechaRealizacion1", Diagnostico.FechaRealizacion1);
            comando.Parameters.AddWithValue("@Resultados1", Diagnostico.Resultados1);

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

        public int Eliminar(EntidadDiagnostico Diagnostico)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Diagnosticos";
            sentencia = string.Format("{0} WHERE IdDiagnostico = '{1}'", sentencia, Diagnostico.IdDiagnostico);
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
