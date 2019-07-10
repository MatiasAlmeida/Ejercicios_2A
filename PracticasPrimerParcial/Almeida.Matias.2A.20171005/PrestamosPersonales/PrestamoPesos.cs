using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        private float CalcularInteres()
        {
            return this.Monto * this.porcentajeInteres / 100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan dias = this.Vencimiento - nuevoVencimiento;
            this.porcentajeInteres += (float)(0.25 * dias.Days);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendFormat(" - Porcentaje de interes: {0} - Interes: {1}", this.porcentajeInteres.ToString(), this.Interes.ToString());
            //sb.AppendLine();
            return sb.ToString();
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }
    }
}
