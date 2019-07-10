using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Dolares); }
        }

        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Pesos); }
        }

        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Todos); }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return this.listaDePrestamos; }
        }

        public string RazonSocial
        {
            get { return this.razonSocial; }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoDePrestamo)
        {
            float aux = 0;
            switch (tipoDePrestamo)
            {
                case TipoDePrestamo.Dolares:
                    foreach(Prestamo item in this.ListaDePrestamos)
                    {
                        if (item is PrestamoDolar)
                            aux += ((PrestamoDolar)item).Interes;
                    }
                    break;
                case TipoDePrestamo.Pesos:
                    foreach (Prestamo item in this.ListaDePrestamos)
                    {
                        if (item is PrestamoPesos)
                            aux += ((PrestamoPesos)item).Interes;
                    }
                    break;
                case TipoDePrestamo.Todos:
                    foreach (Prestamo item in this.ListaDePrestamos)
                    {
                        if (item is PrestamoDolar)
                            aux += ((PrestamoDolar)item).Interes;
                        else
                            aux += ((PrestamoPesos)item).Interes;
                    }
                    break;
                default:
                    break;
            }

            return aux;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon Social: {0}\nInteres Totales: {1}\nIntereses en Dolares: {2}\nIntereses en Pesos: {3}\n",
                financiera.RazonSocial, financiera.InteresesTotales, financiera.InteresesEnDolares, financiera.InteresesEnPesos);

            foreach (Prestamo item in financiera.listaDePrestamos)
            {
                if (item is PrestamoDolar)
                    sb.AppendLine(((PrestamoDolar)item).Mostrar());
                else
                    sb.AppendLine(((PrestamoPesos)item).Mostrar());
            }

            return sb.ToString();
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if(financiera != prestamoNuevo)
                financiera.listaDePrestamos.Add(prestamoNuevo);

            return financiera;
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            foreach(Prestamo item in financiera.ListaDePrestamos)
            {
                if (item == prestamo)
                    return true;
                else
                    continue;
            }

            return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
    }
}
