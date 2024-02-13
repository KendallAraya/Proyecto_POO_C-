using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class EntidadBitacora
    {
        private int idBitacora;
        private DateTime? Fecha;
        private TimeSpan Hora;
        private string movimiento;

        public EntidadBitacora(int idBitacora, DateTime? fecha, TimeSpan hora, string movimiento)
        {
            this.idBitacora = idBitacora;
            Fecha = fecha;
            Hora = hora;
            this.movimiento = movimiento;
        }

        public int IdBitacora { get => idBitacora; set => idBitacora = value; }
        public DateTime? Fecha1 { get => Fecha; set => Fecha = value; }
        public TimeSpan Hora1 { get => Hora; set => Hora = value; }
        public string Movimiento { get => movimiento; set => movimiento = value; }
    }
}
