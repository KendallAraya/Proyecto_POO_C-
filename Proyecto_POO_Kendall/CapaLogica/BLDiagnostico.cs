using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLDiagnostico
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLDiagnostico(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadDiagnostico Diag)
        {
            int id_Diagnostico = 0;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                id_Diagnostico = accesoDatos.Insertar(Diag);
            }
            catch (Exception)
            {
                throw;
            }

            return id_Diagnostico;
        }

        //Metodo para Listar Diagnostico
        public DataSet ListarDiagnostico(string condicion, string orden)
        {
            DataSet DS;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarDiagnostico(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadDiagnostico ObtenerDiagnostico(int id)
        {
            EntidadDiagnostico diagnostico;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                diagnostico = accesoDatos.ObtenerDiagnostico(id);
            }
            catch (Exception)
            {

                throw;
            }
            return diagnostico;
        }

        public int modificarDiagnostico(EntidadDiagnostico Diagnostico)
        {
            int resultado;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarDiagnostico(Diagnostico);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int Eliminar(EntidadDiagnostico Diagnostico)
        {
            int resultado;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(Diagnostico);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
