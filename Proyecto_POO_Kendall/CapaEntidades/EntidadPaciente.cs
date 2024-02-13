using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadPaciente
    {

        //Atributos
        private int idPaciente;
        private string cedula;
        private string nombreCompleto;
        private string telefono;
        private string correoElectro;
        private string nacionalidad;
        private string direccion;
        private bool Existe;

        //Constructor con parametros
        public EntidadPaciente(int idPaciente, string cedula, string nombreCompleto, string telefono, string correoElectro, string nacionalidad, string direccion, bool Existe)
        {
            this.idPaciente = idPaciente;
            this.cedula = cedula;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.correoElectro = correoElectro;
            this.nacionalidad = nacionalidad;
            this.direccion = direccion;
            this.Existe = Existe;
        }

        //Constructor sin parametros
        public EntidadPaciente()
        {
            idPaciente = 0;
            cedula = string.Empty;
            nombreCompleto = string.Empty;
            telefono = string.Empty;
            correoElectro = string.Empty;
            nacionalidad = string.Empty;
            direccion = string.Empty;
            Existe = false;
        }

        //Métodos de acceso generados
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectro { get => correoElectro; set => correoElectro = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool existe { get => Existe; set => Existe = value; }

        // Métodos Get
        public int getIdPaciente() { return idPaciente; }
        public string getCedula() { return cedula; }
        public string getNombreCompleto() { return nombreCompleto; }
        public string getTelefono() { return telefono; }
        public string getCorreoElectro() { return correoElectro; }
        public string getNacionalidad() { return nacionalidad; }
        public string getDireccion() { return direccion; }
        public bool getExiste() { return Existe; }

        // Métodos Set
        public void setIdPaciente(int idPaciente) { this.idPaciente = idPaciente; }
        public void setCedula(string cedula) { this.cedula = cedula; }
        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setCorreoElectro(string correoElectro) { this.correoElectro = correoElectro; }
        public void setNacionalidad(string nacionalidad) { this.nacionalidad = nacionalidad; }
        public void setDireccion(string direccion) { this.direccion = direccion; }
        public void setExiste(bool Existe) { this.Existe = Existe; }
    }
}
