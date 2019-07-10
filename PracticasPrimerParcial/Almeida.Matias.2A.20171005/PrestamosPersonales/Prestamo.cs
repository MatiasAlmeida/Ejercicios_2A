using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get { return this.monto; }
        }

        public DateTime Vencimiento
        {
            get { return this.vencimiento; }
            set {
                if (value > this.vencimiento)
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Now;
            }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return "Monto: " + this.Monto.ToString() + " - Vence: " + this.Vencimiento;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            if (p1.Vencimiento > p2.Vencimiento)
                return 1;
            else if (p1.Vencimiento < p2.Vencimiento)
                return -1;
            else
                return 0;
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
    }
}
