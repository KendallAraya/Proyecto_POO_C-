using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAcessoDatos;
using System.Data;

namespace CapaLogica
{
    public class BLMedicamentos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLMedicamentos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadMedicamentos med)
        {
            int id_medicina = 0;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                id_medicina = accesoDatos.Insertar(med);
            }
            catch (Exception)
            {
                throw;
            }

            return id_medicina;
        }

        //Metodo para Listar Medicamentos
        public DataSet ListarMedicamentos(string condicion, string orden)
        {
            DataSet DS;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMedicamentos(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public EntidadMedicamentos ObtenerMedicina(int id)
        {
            EntidadMedicamentos Medicamento;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                Medicamento = accesoDatos.obtenerMedicamento(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Medicamento;
        }

        public int modificarMedicamento(EntidadMedicamentos Medicamento)
        {
            int resultado;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarMedicamento(Medicamento);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int Eliminar(EntidadMedicamentos Medicamento)
        {
            int resultado;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(Medicamento);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

    }
}
