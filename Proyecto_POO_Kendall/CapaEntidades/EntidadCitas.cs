using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadCitas
    {
        private int idCita;
        private int idAgenda;
        private string idFuncionario;
        private int idPaciente;
        private bool existe;

        public EntidadCitas(int idCita, int idAgenda, string idFuncionario, int idPaciente, bool existe)
        {
            this.idCita = idCita;
            this.idAgenda = idAgenda;
            this.idFuncionario = idFuncionario;
            this.idPaciente = idPaciente;
            this.existe = existe;
        }

        public EntidadCitas()
        {
            idCita = 0;
            idAgenda = 0;
            idFuncionario = string.Empty;
            idPaciente = 0;
            existe = false;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdAgenda { get => idAgenda; set => idAgenda = value; }
        public string IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public bool Existe { get => existe; set => existe = value; }

        // Métodos Get
        public int getIdCita() { return idCita; }
        public int getIdAgenda() { return idAgenda; }
        public string getIdFuncionario() { return idFuncionario; }
        public int getIdPaciente() { return idPaciente; }

        // Métodos Set
        public void setIdCita(int idCita) { this.idCita = idCita; }
        public void setIdAgenda(int idAgenda) { this.idAgenda = idAgenda; }
        public void setIdFuncionario(string idFuncionario) { this.idFuncionario = idFuncionario; }
        public void setIdPaciente(int idPaciente) { this.idPaciente = idPaciente; }
    }
}
