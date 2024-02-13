using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLCita
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLCita(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadCitas Cita)
        {
            int id_Diagnostico = 0;
            DACita accesoDatos = new DACita(_cadenaConexion);
            try
            {
                id_Diagnostico = accesoDatos.Ingresar(Cita);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return id_Diagnostico;
        }

        //Metodo para Listar Cita
        public DataSet ListarCita(string condicion, string orden)
        {
            DataSet DS;
            DACita accesoDatos = new DACita(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarCita(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadCitas ObtenerCita(int id)
        {
            EntidadCitas Cita;
            DACita accesoDatos = new DACita(_cadenaConexion);
            try
            {
                Cita = accesoDatos.ObtenerCita(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Cita;
        }

        public int Eliminar(EntidadCitas Cita)
        {
            int resultado;
            DACita accesoDatos = new DACita(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(Cita);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

    }
}
