using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLPacientes
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLPacientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadPaciente Paciente)
        {
            int id_pacientes = 0;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                id_pacientes = accesoDatos.Insertar(Paciente);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return id_pacientes;
        }
        //Metodo para Listar pacientes
        public DataSet ListarPacientes(string condicion, string orden)
        {
            DataSet DS;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarPacientes(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadPaciente ObtenerPaciente(int id)
        {
            EntidadPaciente Paciente;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                Paciente = accesoDatos.obtenerPaciente(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Paciente;
        }

        public int ModificarPacientes(EntidadPaciente Paciente)
        {
            int resultado;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarPacientes(Paciente);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int EliminarConSP(EntidadPaciente Paciente)
        {
            int resultado;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarRegistroSP(Paciente);
                _mensaje = accesoDatos.Mensaje;

            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
