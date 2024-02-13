using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLEspecialista
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLEspecialista(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadEspecialista Especialista)
        {
            int id_Especialista = 0;
            DAEspecialista accesoDatos = new DAEspecialista(_cadenaConexion);
            try
            {
                id_Especialista = accesoDatos.Insertar(Especialista);
            }
            catch (Exception)
            {
                throw;
            }

            return id_Especialista;
        }

        //Metodo que llama a al metodo de verficar exixtencia
        public bool ExisteEspecialistaRegistrado(string idEspecialista)
        {
            bool Existe = false;
            DAEspecialista accesoDatos = new DAEspecialista(_cadenaConexion);
            try
            {
                Existe = accesoDatos.ExisteEspecialistaRegistrado(idEspecialista);
            }
            catch (Exception)
            {
                throw;
            }

            return Existe;
        }

        //Metodo para Listar Especialista
        public DataSet ListarEspecialista(string condicion, string orden)
        {
            DataSet DS;
            DAEspecialista accesoDatos = new DAEspecialista(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarEspecialista(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadEspecialista obtenerEspecialista(string id)
        {
            EntidadEspecialista Especialista;
            DAEspecialista accesoDatos = new DAEspecialista(_cadenaConexion);
            try
            {
                Especialista = accesoDatos.obtenerEspecialista(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Especialista;
        }

        public int ModificarEspecialista(EntidadEspecialista Especialista)
        {
            int resultado;
            DAEspecialista accesoDatos = new DAEspecialista(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarEspecialista(Especialista);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int EliminarEspecialista(EntidadEspecialista Especialista)
        {
            int resultado;
            DAEspecialista accesoDatos = new DAEspecialista(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarEspecialista(Especialista);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

    }
}
