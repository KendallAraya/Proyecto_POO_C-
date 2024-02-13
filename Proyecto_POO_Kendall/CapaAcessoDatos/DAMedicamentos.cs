using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DAMedicamentos
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAMedicamentos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        public int Insertar(EntidadMedicamentos Med)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO Medicamentos (NombreMed, Descripcion, Instrucciones) VALUES(@NombreMed, @Descripcion, @Instrucciones) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@NombreMed", Med.getnombreMed());
            comando.Parameters.AddWithValue("@Descripcion", Med.getdescripcion());
            comando.Parameters.AddWithValue("@Instrucciones", Med.getinstrucciones());
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

        //Devuelve un DataSet de medicamentos para mostrar en un diagrama
        public DataSet ListarMedicamentos(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IDmedicamento, NombreMed, Descripcion, Instrucciones from Medicamentos";

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
                adapter.Fill(datos, "Medicamentos");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        //Metodo recibe el ID del Medicamento y devuelve la entidad cliente

        public EntidadMedicamentos obtenerMedicamento(int id)
        {
            EntidadMedicamentos Medicamento = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IDmedicamento, NombreMed, Descripcion, Instrucciones from Medicamentos where IDmedicamento = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Medicamento = new EntidadMedicamentos();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Medicamento.IdMedicamento = dataReader.GetInt32(0);
                    Medicamento.NombreMed = dataReader.GetString(1);
                    Medicamento.Descripcion = dataReader.GetString(2);
                    Medicamento.Instrucciones = dataReader.GetString(3);
                    Medicamento.existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Medicamento;
        }

        public int modificarMedicamento(EntidadMedicamentos Medicamento)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE Medicamentos SET NombreMed= @NombreMed, Descripcion= @Descripcion, Instrucciones= @Instrucciones WHERE IDmedicamento= @IDmedicamento";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IDmedicamento", Medicamento.IdMedicamento);
            comando.Parameters.AddWithValue("@NombreMed", Medicamento.NombreMed);
            comando.Parameters.AddWithValue("@Descripcion", Medicamento.Descripcion);
            comando.Parameters.AddWithValue("@Instrucciones", Medicamento.Instrucciones);

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

        public int Eliminar(EntidadMedicamentos Medicamento)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Medicamentos";
            sentencia = string.Format("{0} WHERE IDmedicamento = '{1}'", sentencia, Medicamento.IdMedicamento);
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
