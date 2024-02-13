using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaAcessoDatos
{
     public class DAFuncionarios
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadFuncionario Funcionario)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO Funcionarios (IdFuncionario, CedulaF, NombreCompletoF, TelefonoF, CorreoElecF, NacionalidadF, DireccionF, PuestoTrabajaF) VALUES(@IDFUNCIONARIO, @CedulaF, @NombreCompletoF, @TelefonoF, @CorreoElecF, @NacionalidadF, @DireccionF, @PuestoTrabaja) ";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@IDFUNCIONARIO", Funcionario.getIdFuncionario());
            comando.Parameters.AddWithValue("@CedulaF", Funcionario.getCedula());
            comando.Parameters.AddWithValue("@NombreCompletoF", Funcionario.getNombreCompleto());
            comando.Parameters.AddWithValue("@TelefonoF", Funcionario.getTelefono());
            comando.Parameters.AddWithValue("@CorreoElecF", Funcionario.getCorreoElectro());
            comando.Parameters.AddWithValue("@NacionalidadF", Funcionario.getNacionalidad());
            comando.Parameters.AddWithValue("@DireccionF", Funcionario.getDireccion());
            comando.Parameters.AddWithValue("@PuestoTrabaja", Funcionario.getPuestoTrabaja());
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

        //Verificar si un funcionario existe
        public bool ExisteFuncionarioRegistrado(string idFuncionario)
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
                        comando.CommandText = "SELECT COUNT(*) FROM Funcionarios WHERE IdFuncionario = @IDFuncionario";
                        comando.Parameters.AddWithValue("@IDFuncionario", idFuncionario);

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
            catch (Exception )
            {
                throw;
            }

            return existe;
        }

        //Devuelve un DataSet de Pacientes para mostrar en un diagrama
        public DataSet ListarFuncinario(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select IdFuncionario, CedulaF, NombreCompletoF, TelefonoF, CorreoElecF, NacionalidadF, DireccionF, PuestoTrabajaF from Funcionarios";

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
                adapter.Fill(datos, "Funcionario");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        //Metodo recibe el ID del funcionario y devuelve la entidad funcionario

        public EntidadFuncionario obtenerFuncionario(string id)
        {
            EntidadFuncionario Funcionario = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT IdFuncionario, CedulaF, NombreCompletoF, TelefonoF, CorreoElecF, NacionalidadF, PuestoTrabajaF, DireccionF FROM Funcionarios WHERE IdFuncionario = '{0}'", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Funcionario = new EntidadFuncionario();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Funcionario.IdFuncionario = dataReader.GetString(0);
                    Funcionario.Cedula = dataReader.GetString(1);
                    Funcionario.NombreCompleto = dataReader.GetString(2);
                    Funcionario.Telefono = dataReader.GetString(3);
                    Funcionario.CorreoElectro = dataReader.GetString(4);
                    Funcionario.Nacionalidad = dataReader.GetString(5);
                    Funcionario.PuestoTrabaja = dataReader.GetString(6);
                    Funcionario.Direccion = dataReader.GetString(7);
                    Funcionario.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Funcionario;
        }

        public int modificarFuncionarios(EntidadFuncionario Funcionario)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE Funcionarios SET IdFuncionario= @IDFUNCIONARIO, CedulaF= @CEDULA, NombreCompletoF= @NOMBRE, TelefonoF= @TELEFONO, CorreoElecF= @CORREO, DireccionF= @DIRECCION, NacionalidadF= @NACIONALIDAD, PuestoTrabajaF= @PUESTO WHERE IdFuncionario= @IDFUNCIONARIO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IDFUNCIONARIO", Funcionario.IdFuncionario);
            comando.Parameters.AddWithValue("@CEDULA", Funcionario.Cedula);
            comando.Parameters.AddWithValue("@NOMBRE", Funcionario.NombreCompleto);
            comando.Parameters.AddWithValue("@TELEFONO", Funcionario.Telefono);
            comando.Parameters.AddWithValue("@DIRECCION", Funcionario.Direccion);
            comando.Parameters.AddWithValue("@NACIONALIDAD", Funcionario.Nacionalidad);
            comando.Parameters.AddWithValue("@PUESTO", Funcionario.PuestoTrabaja);
            comando.Parameters.AddWithValue("@CORREO", Funcionario.CorreoElectro);

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
        public int EliminarFuncionario(EntidadFuncionario Funcionario)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM Funcionarios";
            sentencia = string.Format("{0} WHERE IdFuncionario = '{1}'", sentencia, Funcionario.IdFuncionario);
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
