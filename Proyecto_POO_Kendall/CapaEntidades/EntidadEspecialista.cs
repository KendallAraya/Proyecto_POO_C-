using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadEspecialista
    {
        private string idEspecialidad;
        private string cedula;
        private string nombreCompleto;
        private string telefono;
        private string correoElectro;
        private string nacionalidad;
        private string direccion;
        private string nombreEspecialidad;
        private bool existe;


        //Constructor con parametros
        public EntidadEspecialista(string idEspecialidad, string cedula, string nombreCompleto, string telefono, string correoElectro, string nacionalidad, string direccion, string nombreEspecialidad, bool existe)
        {
            this.idEspecialidad = idEspecialidad;
            this.cedula = cedula;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.correoElectro = correoElectro;
            this.nacionalidad = nacionalidad;
            this.direccion = direccion;
            this.nombreEspecialidad = nombreEspecialidad;
            this.existe = existe;
        }

        //Constructor sin parametros
        public EntidadEspecialista()
        {
            idEspecialidad = string.Empty;
            cedula = string.Empty;
            nombreCompleto = string.Empty;
            telefono = string.Empty;
            correoElectro = string.Empty;
            nacionalidad = string.Empty;
            direccion = string.Empty;
            nombreEspecialidad = string.Empty;
            existe = false;
        }

        //Métodos generados
        public string IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectro { get => correoElectro; set => correoElectro = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }
        public bool Existe { get => existe; set => existe = value; }

        // Métodos Get
        public string getIdEspecialidad() { return idEspecialidad; }
        public string getCedula() { return cedula; }
        public string getNombreCompleto() { return nombreCompleto; }
        public string getTelefono() { return telefono; }
        public string getCorreoElectro() { return correoElectro; }
        public string getNacionalidad() { return nacionalidad; }
        public string getDireccion() { return direccion; }
        public string getNombreEspecialidad() { return nombreEspecialidad; }
        public bool getExiste() { return existe; }

        // Métodos Set
        public void setIdEspecialidad(string idEspecialidad) { this.idEspecialidad = idEspecialidad; }
        public void setCedula(string cedula) { this.cedula = cedula; }
        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setCorreoElectro(string correoElectro) { this.correoElectro = correoElectro; }
        public void setNacionalidad(string nacionalidad) { this.nacionalidad = nacionalidad; }
        public void setDireccion(string direccion) { this.direccion = direccion; }
        public void setNombreEspecialidad(string nombreEspecialidad) { this.nombreEspecialidad = nombreEspecialidad; }
        public void setExiste(bool existe) { this.existe = existe; }
    }
}
