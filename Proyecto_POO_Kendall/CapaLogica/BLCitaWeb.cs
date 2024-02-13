using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLCitaWeb
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLCitaWeb(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadCitasWeb cita)
        {
            int id_Cita = 0;
            DACitaWeb accesoDatos = new DACitaWeb(_cadenaConexion);
            try
            {
                id_Cita = accesoDatos.Insertar(cita);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return id_Cita;
        }

        public DataSet ListarCita(int condicion)
        {
            DataSet DS;
            DACitaWeb accesoDatos = new DACitaWeb(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarCitas(condicion);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public int Eliminar(int id)
        {
            int resultado;
            DACitaWeb accesoDatos = new DACitaWeb(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(id);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

    }
}
