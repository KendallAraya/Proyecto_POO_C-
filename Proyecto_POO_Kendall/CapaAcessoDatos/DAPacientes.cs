using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
    public class DAPacientes
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAPacientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadPaciente Paciente)
        {
            int id = 0;

            using (SqlConnection conexion = new SqlConnection(_cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand("InsertarPaciente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@CedulaP", Paciente.getCedula());
                    comando.Parameters.AddWithValue("@NombreCompletoP", Paciente.getNombreCompleto());
                    comando.Parameters.AddWithValue("@TelefonoP", Paciente.getTelefono());
                    comando.Parameters.AddWithValue("@CorreoElecP", Paciente.getCorreoElectro());
                    comando.Parameters.AddWithValue("@NacionalidadP", Paciente.getNacionalidad());
                    comando.Parameters.AddWithValue("@DireccionP", Paciente.getDireccion());

                    comando.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();

                        // Obtener el valor del parámetro de salida @ID
                        id = Convert.ToInt32(comando.Parameters["@ID"].Value);
                        // Obtener el valor del parámetro de salida @Mensaje
                        _mensaje = comando.Parameters["@Mensaje"].Value.ToString();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return id;
        }


        //Devuelve un DataSet de PACIENTES para mostrar en un diagrama
        public DataSet ListarPacientes(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IdPaciente, CedulaP, NombreCompletoP, TelefonoP, CorreoElecP, NacionalidadP, DireccionP from Pacientes";

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
                adapter.Fill(datos, "Pacientes");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        //Metodo recibe el ID del Paciente y devuelve la entidad cliente

        public EntidadPaciente obtenerPaciente(int id)
        {
            EntidadPaciente Paciente = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("Select IdPaciente, CedulaP, NombreCompletoP, TelefonoP, CorreoElecP, NacionalidadP, DireccionP from Pacientes where IdPaciente = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Paciente = new EntidadPaciente();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Paciente.IdPaciente = dataReader.GetInt32(0);
                    Paciente.Cedula = dataReader.GetString(1);
                    Paciente.NombreCompleto = dataReader.GetString(2);
                    Paciente.Telefono = dataReader.GetString(3);
                    Paciente.CorreoElectro = dataReader.GetString(4);
                    Paciente.Nacionalidad = dataReader.GetString(5);
                    Paciente.Direccion = dataReader.GetString(6);
                    Paciente.existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Paciente;
        }

        public int modificarPacientes(EntidadPaciente Paciente)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE Pacientes SET CedulaP= @CedulaP, NombreCompletoP= @NombreCompletoP, TelefonoP= @TelefonoP, CorreoElecP= @CorreoElecP, NacionalidadP= @NacionalidadP, DireccionP= @DireccionP WHERE IdPaciente= @IdPaciente";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IdPaciente", Paciente.IdPaciente);
            comando.Parameters.AddWithValue("@CedulaP", Paciente.Cedula);
            comando.Parameters.AddWithValue("@NombreCompletoP", Paciente.NombreCompleto);
            comando.Parameters.AddWithValue("@TelefonoP", Paciente.Telefono);
            comando.Parameters.AddWithValue("@CorreoElecP", Paciente.CorreoElectro);
            comando.Parameters.AddWithValue("@NacionalidadP", Paciente.Nacionalidad);
            comando.Parameters.AddWithValue("@DireccionP", Paciente.Direccion);

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

        //Eliminar un registro mediante un proceso almacenado
        public int EliminarRegistroSP(EntidadPaciente Paciente)
        {
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_PACIENTE02"; //el nombre del procedimineto almacenado
            //Se especifica que tipo de comando es, en este caso es un SP
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@ID_PACIENTE", Paciente.IdPaciente);
            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            //se declara otro parametro de retorno del SP que optenga el retorno de SP
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@msj"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
