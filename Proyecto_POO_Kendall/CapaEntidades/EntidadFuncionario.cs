using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadFuncionario
    {
        private string idFuncionario;
        private string cedula;
        private string nombreCompleto;
        private string telefono;
        private string correoElectro;
        private string nacionalidad;
        private string direccion;
        private string puestoTrabaja;
        private bool existe;


        //Constructor con parametros
        public EntidadFuncionario(string idFuncionario, string cedula, string nombreCompleto, string telefono, string correoElectro, string nacionalidad, string direccion, string puestoTrabaja, bool existe)
        {
            this.idFuncionario = idFuncionario;
            this.cedula = cedula;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.correoElectro = correoElectro;
            this.nacionalidad = nacionalidad;
            this.direccion = direccion;
            this.puestoTrabaja = puestoTrabaja;
            this.existe = existe;
        }

        //Constructor sin parametros
        public EntidadFuncionario()
        {
            idFuncionario = string.Empty;
            cedula = string.Empty;
            nombreCompleto = string.Empty;
            telefono = string.Empty;
            correoElectro = string.Empty;
            nacionalidad = string.Empty;
            direccion = string.Empty;
            puestoTrabaja = string.Empty;
            existe = false;
        }

        //Métodos generados
        public string IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectro { get => correoElectro; set => correoElectro = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string PuestoTrabaja { get => puestoTrabaja; set => puestoTrabaja = value; }
        public bool Existe { get => existe; set => existe = value; }

        // Métodos Get
        public string getIdFuncionario() { return idFuncionario; }
        public string getCedula() { return cedula; }
        public string getNombreCompleto() { return nombreCompleto; }
        public string getTelefono() { return telefono; }
        public string getCorreoElectro() { return correoElectro; }
        public string getNacionalidad() { return nacionalidad; }
        public string getDireccion() { return direccion; }
        public string getPuestoTrabaja() { return puestoTrabaja; }
        public bool getExiste() { return existe; }

        // Métodos Set
        public void setIdFuncionario(string idFuncionario) { this.idFuncionario = idFuncionario; }
        public void setCedula(string cedula) { this.cedula = cedula; }
        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setCorreoElectro(string correoElectro) { this.correoElectro = correoElectro; }
        public void setNacionalidad(string nacionalidad) { this.nacionalidad = nacionalidad; }
        public void setDireccion(string direccion) { this.direccion = direccion; }
        public void setPuestoTrabaja(string puestoTrabaja) { this.puestoTrabaja = puestoTrabaja; }
        public void setExiste(bool existe) { this.existe = existe; }
    }
}
