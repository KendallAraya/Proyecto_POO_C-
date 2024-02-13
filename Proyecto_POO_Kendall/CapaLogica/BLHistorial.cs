using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLHistorial
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLHistorial(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadHistorial Diag)
        {
            int id_Diagnostico = 0;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
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

        //Metodo para Listar Historial
        public DataSet ListarHistorial(string condicion, string orden)
        {
            DataSet DS;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarHistorial(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadHistorial ObtenerHistorial(int id)
        {
            EntidadHistorial Historial;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                Historial = accesoDatos.ObtenerHistorial(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Historial;
        }

        public int Eliminar(EntidadHistorial Historial)
        {
            int resultado;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(Historial);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
