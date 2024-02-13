using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadCitasWeb
    {
        private int IDcitaWeb;
        private int IDAgendaEspecialista;
        private int IdPaciente;
        private TimeSpan HoraInicio;
        private DateTime? Fecha;

        //Constructor con parametros
        public EntidadCitasWeb(int iDcitaWeb, int iDAgendaEspecialista, int idPaciente, TimeSpan horaInicio, DateTime fecha)
        {
            IDcitaWeb = iDcitaWeb;
            IDAgendaEspecialista = iDAgendaEspecialista;
            IdPaciente = idPaciente;
            HoraInicio = horaInicio;
            Fecha = fecha;
        }

        //Constructor vacio
        public EntidadCitasWeb()
        {
            IDcitaWeb = 0;
            IDAgendaEspecialista = 0;
            IdPaciente = 0;
            HoraInicio = TimeSpan.Zero;
            Fecha = Convert.ToDateTime("01/01/1900");
        }

        //Metodos de acceso generados
        public int IDcitaWeb1 { get => IDcitaWeb; set => IDcitaWeb = value; }
        public int IDAgendaEspecialista1 { get => IDAgendaEspecialista; set => IDAgendaEspecialista = value; }
        public int IdPaciente1 { get => IdPaciente; set => IdPaciente = value; }
        public TimeSpan HoraInicio1 { get => HoraInicio; set => HoraInicio = value; }
        public DateTime? Fecha1 { get => Fecha; set => Fecha = value; }


        //Metodos de acceso
        public int GetIDCitaWeb()
        {
            return IDcitaWeb;
        }

        public void SetIDCitaWeb(int value)
        {
            IDcitaWeb = value;
        }

        public int GetIDAgendaEspecialista()
        {
            return IDAgendaEspecialista;
        }

        public void SetIDAgendaEspecialista(int value)
        {
            IDAgendaEspecialista = value;
        }

        public int GetIDPaciente()
        {
            return IdPaciente;
        }

        public void SetIDPaciente(int value)
        {
            IdPaciente = value;
        }

        public TimeSpan GetHoraInicio()
        {
            return HoraInicio;
        }

        public void SetHoraInicio(TimeSpan value)
        {
            HoraInicio = value;
        }

        public DateTime? GetFecha()
        {
            return Fecha;
        }

        public void SetFecha(DateTime? value)
        {
            Fecha = value;
        }

    }
}
