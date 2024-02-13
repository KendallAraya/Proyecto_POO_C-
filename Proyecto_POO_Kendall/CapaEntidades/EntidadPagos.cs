using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadPagos
    {
        private int idFactura;
        private int idPaciente;
        private string idFuncionario;
        private double monto;
        private string tipoPago;
        private DateTime? FechaRealiza;
        private bool existe;

        public EntidadPagos(int idFactura, int idPaciente, string idFuncionario, double monto, string tipoPago, DateTime? fechaRealiza, bool existe)
        {
            this.idFactura = idFactura;
            this.idPaciente = idPaciente;
            this.idFuncionario = idFuncionario;
            this.monto = monto;
            this.tipoPago = tipoPago;
            FechaRealiza = fechaRealiza;
            this.existe = existe;
        }

        public EntidadPagos()
        {
            idFactura = 0;
            idPaciente = 0;
            idFuncionario = string.Empty;
            monto = 0.0;
            tipoPago = string.Empty;
            FechaRealiza = Convert.ToDateTime("01/01/1900");
            existe = false;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public double Monto { get => monto; set => monto = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public DateTime? FechaRealiza1 { get => FechaRealiza; set => FechaRealiza = value; }
        public bool Existe { get => existe; set => existe = value; }

        public int GetIdFactura()
        {
            return idFactura;
        }

        public void SetIdFactura(int value)
        {
            idFactura = value;
        }

        public int GetIdPaciente()
        {
            return idPaciente;
        }

        public void SetIdPaciente(int value)
        {
            idPaciente = value;
        }


        public string GetIdFuncionario()
        {
            return idFuncionario;
        }

        public void SetIdFuncionario(string value)
        {
            idFuncionario = value;
        }


        public double GetMonto()
        {
            return monto;
        }

        public void SetMonto(double value)
        {
            monto = value;
        }

        public string GetTipoPago()
        {
            return tipoPago;
        }

        public void SetTipoPago(string value)
        {
            tipoPago = value;
        }


        public DateTime? GetFechaRealiza()
        {
            return FechaRealiza;
        }

        public void SetFechaRealiza(DateTime? value)
        {
            FechaRealiza = value;
        }
    }
}
