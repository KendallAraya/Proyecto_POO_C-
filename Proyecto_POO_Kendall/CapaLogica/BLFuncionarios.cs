using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLFuncionarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadFuncionario Funcionario)
        {
            int id_Funcionario = 0;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                id_Funcionario = accesoDatos.Insertar(Funcionario);
            }
            catch (Exception)
            {
                throw;
            }

            return id_Funcionario;
        }

        //Metodo que llama a al metodo de verficar exixtencia
        public bool ExisteFuncionarioRegistrado(string idFuncionario)
        {
            bool Existe = false;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                Existe = accesoDatos.ExisteFuncionarioRegistrado(idFuncionario);
            }
            catch (Exception)
            {
                throw;
            }

            return Existe;
        }

        //Metodo para Listar Funcinario
        public DataSet ListarFuncinario(string condicion, string orden)
        {
            DataSet DS;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarFuncinario(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadFuncionario obtenerFuncionario(string id)
        {
            EntidadFuncionario funcionario;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                funcionario = accesoDatos.obtenerFuncionario(id);
            }
            catch (Exception)
            {
                throw;
            }
            return funcionario;
        }

        public int ModificarFuncionarios(EntidadFuncionario Funcionario)
        {
            int resultado;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarFuncionarios(Funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int EliminarFuncionario(EntidadFuncionario Funcionario)
        {
            int resultado;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarFuncionario(Funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
