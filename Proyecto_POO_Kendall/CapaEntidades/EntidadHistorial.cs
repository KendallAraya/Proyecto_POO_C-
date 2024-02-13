using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadHistorial
    {
        private int idHistorial;
        private int idPaciente;
        private int idDiagnostico;
        private int idMedicamento;
        private bool existe;

        public EntidadHistorial(int idHistorial, int idPaciente, int idDiagnostico, int idMedicamento, bool existe)
        {
            this.idHistorial = idHistorial;
            this.idPaciente = idPaciente;
            this.idDiagnostico = idDiagnostico;
            this.idMedicamento = idMedicamento;
            this.existe = existe;
        }

        public EntidadHistorial()
        {
            idHistorial = 0;
            idPaciente = 0;
            idDiagnostico = 0;
            idMedicamento = 0;
            existe = false;
        }

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public int IdMedicamento { get => idMedicamento; set => idMedicamento = value; }
        public bool Existe { get => existe; set => existe = value; }

        public int GetIdHistorial()
        {
            return idHistorial;
        }

        public void SetIdHistorial(int idHistorial)
        {
            this.idHistorial = idHistorial;
        }

        public int GetIdPaciente()
        {
            return idPaciente;
        }

        public void SetIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        public int GetIdDiagnostico()
        {
            return idDiagnostico;
        }

        public void SetIdDiagnostico(int idDiagnostico)
        {
            this.idDiagnostico = idDiagnostico;
        }

        public int GetIdMedicamento()
        {
            return idMedicamento;
        }

        public void SetIdMedicamento(int idMedicamento)
        {
            this.idMedicamento = idMedicamento;
        }

        public bool GetExiste()
        {
            return existe;
        }

        public void SetExiste(bool Existe)
        {
            this.existe = Existe;
        }
    }
}
