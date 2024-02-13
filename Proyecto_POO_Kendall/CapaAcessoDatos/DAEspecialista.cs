using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DAEspecialista
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAEspecialista(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadEspecialista Especialista)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO Especialidad (IdEspecialista, CedulaE, NombreCompletoE, TelefonoE, CorreoElecE, NacionalidadE, DireccionE, NombreEspecialidad) VALUES(@IDESPECIALISTA, @CedulaE, @NombreCompletoE, @TelefonoE, @CorreoElecE, @NacionalidadE, @DireccionE, @NOMBREESPECIALIDAD) ";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@IDESPECIALISTA", Especialista.getIdEspecialidad());
            comando.Parameters.AddWithValue("@CedulaE", Especialista.getCedula());
            comando.Parameters.AddWithValue("@NombreCompletoE", Especialista.getNombreCompleto());
            comando.Parameters.AddWithValue("@TelefonoE", Especialista.getTelefono());
            comando.Parameters.AddWithValue("@CorreoElecE", Especialista.getCorreoElectro());
            comando.Parameters.AddWithValue("@NacionalidadE", Especialista.getNacionalidad());
            comando.Parameters.AddWithValue("@DireccionE", Especialista.getDireccion());
            comando.Parameters.AddWithValue("@NOMBREESPECIALIDAD", Especialista.getNombreEspecialidad());
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

        //Verificar si un Especialista existe
        public bool ExisteEspecialistaRegistrado(string IdEspecialista)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadenaConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT COUNT(*) FROM Especialidad WHERE IdEspecialista = @IdEspecialista";
                        comando.Parameters.AddWithValue("@IdEspecialista", IdEspecialista);

                        // Ejecutar la consulta y obtener el resultado.
                        int count = (int)comando.ExecuteScalar();

                        // Si count es mayor que cero, significa que existe un funcionario con el ID proporcionado.
                        if (count > 0)
                        {
                            existe = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return existe;
        }

        //Devuelve un DataSet de Especialista para mostrar en un diagrama
        public DataSet ListarEspecialista(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IdEspecialista, CedulaE, NombreCompletoE, TelefonoE, CorreoElecE, NacionalidadE, DireccionE, NombreEspecialidad from Especialidad";

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
                adapter.Fill(datos, "Especialista");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        //Metodo recibe el ID del Especialista y devuelve la entidad funcionario

        public EntidadEspecialista obtenerEspecialista(string id)
        {
            EntidadEspecialista Especialista = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IdEspecialista, CedulaE, NombreCompletoE, TelefonoE, CorreoElecE, NacionalidadE, NombreEspecialidad, DireccionE from Especialidad WHERE IdEspecialista = '{0}'", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Especialista = new EntidadEspecialista();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Especialista.IdEspecialidad = dataReader.GetString(0);
                    Especialista.Cedula = dataReader.GetString(1);
                    Especialista.NombreCompleto = dataReader.GetString(2);
                    Especialista.Telefono = dataReader.GetString(3);
                    Especialista.CorreoElectro = dataReader.GetString(4);
                    Especialista.Nacionalidad = dataReader.GetString(5);
                    Especialista.NombreEspecialidad = dataReader.GetString(6);
                    Especialista.Direccion = dataReader.GetString(7);
                    Especialista.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Especialista;
        }

        public int modificarEspecialista(EntidadEspecialista Especialista)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE Especialidad SET IdEspecialista= @IDEspecialista, CedulaE= @CEDULA, NombreCompletoE= @NOMBRE, TelefonoE= @TELEFONO, CorreoElecE= @CORREO, DireccionE= @DIRECCION, NacionalidadE= @NACIONALIDAD, NombreEspecialidad= @Especialidad WHERE IdEspecialista= @IDEspecialista";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IDEspecialista", Especialista.IdEspecialidad);
            comando.Parameters.AddWithValue("@CEDULA", Especialista.Cedula);
            comando.Parameters.AddWithValue("@NOMBRE", Especialista.NombreCompleto);
            comando.Parameters.AddWithValue("@TELEFONO", Especialista.Telefono);
            comando.Parameters.AddWithValue("@DIRECCION", Especialista.Direccion);
            comando.Parameters.AddWithValue("@NACIONALIDAD", Especialista.Nacionalidad);
            comando.Parameters.AddWithValue("@Especialidad", Especialista.NombreEspecialidad);
            comando.Parameters.AddWithValue("@CORREO", Especialista.CorreoElectro);

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

        //Eliminar sin SP
        public int EliminarEspecialista(EntidadEspecialista Especialista)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Especialidad";
            sentencia = string.Format("{0} WHERE IdEspecialista = '{1}'", sentencia, Especialista.IdEspecialidad);
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
