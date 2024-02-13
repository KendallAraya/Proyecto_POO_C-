using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLPagos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadPagos Pago)
        {
            int id_Pago = 0;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                id_Pago = accesoDatos.Insertar(Pago);
            }
            catch (Exception)
            {
                throw;
            }

            return id_Pago;
        }

        //Metodo para Listar Pago
        public DataSet ListarPago(string condicion, string orden)
        {
            DataSet DS;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarPago(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadPagos ObtenerPago(int id)
        {
            EntidadPagos Pago;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                Pago = accesoDatos.obtenerPagos(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Pago;
        }

        public int modificarPago(EntidadPagos Pago)
        {
            int resultado;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarPagos(Pago);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int Eliminar(EntidadPagos Pago)
        {
            int resultado;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(Pago);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
