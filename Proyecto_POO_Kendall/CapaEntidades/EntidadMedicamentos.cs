using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadMedicamentos
    {
        private int idMedicamento;
        private string nombreMed;
        private string descripcion;
        private string instrucciones;
        private bool Existe;

        

        public EntidadMedicamentos(int idMedicamento, string nombreMed, string descripcion, string instrucciones, bool Existe)
        {
            this.idMedicamento = idMedicamento;
            this.nombreMed = nombreMed;
            this.descripcion = descripcion;
            this.instrucciones = instrucciones;
            this.Existe = Existe;
        }

        public EntidadMedicamentos()
        {
            idMedicamento = 0;
            nombreMed = string.Empty;
            descripcion = string.Empty;
            instrucciones = string.Empty;
            Existe = false;
        }

        public int IdMedicamento { get => idMedicamento; set => idMedicamento = value; }
        public string NombreMed { get => nombreMed; set => nombreMed = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Instrucciones { get => instrucciones; set => instrucciones = value; }
        public bool existe { get => Existe; set => Existe = value; }

        // Métodos Get
        public int getidMedicamento() { return idMedicamento; }
        public string getnombreMed() { return nombreMed; }
        public string getdescripcion() { return descripcion; }
        public string getinstrucciones() { return instrucciones; }
        public bool getExiste() { return Existe; }


        // Métodos Set
        public void setidMedicamento(int idMedicamento) { this.idMedicamento = idMedicamento; }
        public void setnombreMed(string nombreMed) { this.nombreMed = nombreMed; }
        public void setdescripcion(string descripcion) { this.descripcion = descripcion; }
        public void setinstrucciones(string instrucciones) { this.instrucciones = instrucciones; }
        public void setExiste(bool Existe) { this.Existe = Existe; }

    }
}
