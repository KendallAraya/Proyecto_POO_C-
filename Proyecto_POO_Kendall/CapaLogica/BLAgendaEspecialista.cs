using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLAgendaEspecialista
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLAgendaEspecialista(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadAgendaEspecialista Agenda)
        {
            int resultado;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {

                resultado = accesoDatos.RegistrarAgenda(Agenda);
                _mensaje = accesoDatos.Mensaje;

            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }


        public DataSet ListarAgenda(string condicion, string orden)
        {
            DataSet DS;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarAgenda(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public DataSet ListarAgendaEspecialista(string condicion)
        {
            DataSet DS;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarAgendaEspecialistas(condicion);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadAgendaEspecialista ObtenerAgenda(int id)
        {
            EntidadAgendaEspecialista Agenda;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                Agenda = accesoDatos.ObtenerAgenda(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Agenda;
        }

        public int Eliminar(EntidadAgendaEspecialista Agenda)
        {
            int resultado;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(Agenda);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
