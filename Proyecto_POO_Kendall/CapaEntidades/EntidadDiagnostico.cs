using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadDiagnostico
    {
        private int idDiagnostico;
        private string idEspecialista;
        private DateTime? FechaRealizacion;
        private string Resultados;
        private bool existe;

        public EntidadDiagnostico(int idDiagnostico, string idEspecialista, DateTime? fechaRealizacion, string resultados, bool existe = false)
        {
            this.idDiagnostico = idDiagnostico;
            this.idEspecialista = idEspecialista;
            this.FechaRealizacion = fechaRealizacion;
            this.Resultados = resultados;
            this.existe = existe;
        }

        public EntidadDiagnostico()
        {
            idDiagnostico = 0;
            idEspecialista = string.Empty; ;
            FechaRealizacion = Convert.ToDateTime("01/01/1900");
            Resultados = string.Empty;
            existe = false;
        }

        public int IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public string IdEspecialista { get => idEspecialista; set => idEspecialista = value; }
        public DateTime? FechaRealizacion1 { get => FechaRealizacion; set => FechaRealizacion = value; }
        public string Resultados1 { get => Resultados; set => Resultados = value; }
        public bool Existe { get => existe; set => existe = value; }

        // Métodos Get
        public int getidDiagnostico() { return idDiagnostico; }
        public string getIdEspecialista() { return IdEspecialista; }
        public DateTime? getFechaRealizacion() { return FechaRealizacion; }
        public string getResultados() { return Resultados; }
        public bool getExiste() { return existe; }


        // Métodos Set
        public void setidDiagnostico(int idDiagnostico) { this.idDiagnostico = idDiagnostico; }
        public void setIdEspecialista(string IdEspecialista) { this.IdEspecialista = IdEspecialista; }
        public void setFechaRealizacion(DateTime? FechaRealizacion) { this.FechaRealizacion = FechaRealizacion; }
        public void setResultados(string Resultados) { this.Resultados = Resultados; }
        public void setExiste(bool Existe) { this.existe = Existe; }
    }
}
