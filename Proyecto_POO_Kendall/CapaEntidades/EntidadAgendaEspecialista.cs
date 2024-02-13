using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadAgendaEspecialista
    {
        private int idAgenda;
        private string idEspecialista;
        private TimeSpan HoraInicio;
        private TimeSpan HoraFinal;
        private DateTime? FechaCita;
        private bool existe;

        public EntidadAgendaEspecialista(int idAgenda, string idEspecialista, TimeSpan horaInicio, TimeSpan horaFinal, DateTime? fechaCita, bool existe)
        {
            this.idAgenda = idAgenda;
            this.idEspecialista = idEspecialista;
            HoraInicio = horaInicio;
            HoraFinal = horaFinal;
            FechaCita = fechaCita;
            this.existe = existe;
        }

        public EntidadAgendaEspecialista()
        {
            idAgenda = 0;
            idEspecialista = string.Empty;
            HoraInicio = new TimeSpan(0, 0, 0);
            HoraFinal = new TimeSpan(0, 0, 0);
            FechaCita = Convert.ToDateTime("01/01/1900");
            existe = false;
        }

        public int IdAgenda { get => idAgenda; set => idAgenda = value; }
        public string IdEspecialista { get => idEspecialista; set => idEspecialista = value; }
        public TimeSpan HoraInicio1 { get => HoraInicio; set => HoraInicio = value; }
        public TimeSpan HoraFinal1 { get => HoraFinal; set => HoraFinal = value; }
        public DateTime? FechaCita1 { get => FechaCita; set => FechaCita = value; }
        public bool Existe { get => existe; set => existe = value; }

        // Métodos Get
        public int getIdAgenda() { return idAgenda; }
        public string getIdEspecialista() { return idEspecialista; }
        public TimeSpan getHoraInicio() { return HoraInicio; }
        public TimeSpan getHoraFinal() { return HoraFinal; }
        public DateTime? getFechaCita() { return FechaCita; }

        // Métodos Set
        public void setIdAgenda(int idAgenda) { this.idAgenda = idAgenda; }
        public void setIdEspecialista(string idEspecialista) { this.idEspecialista = idEspecialista; }
        public void setHoraInicio(TimeSpan HoraInicio) { this.HoraInicio = HoraInicio; }
        public void setHoraFinal(TimeSpan HoraFinal) { this.HoraFinal = HoraFinal; }
        public void setFechaCita(DateTime? FechaCita) { this.FechaCita = FechaCita; }
    }
}
