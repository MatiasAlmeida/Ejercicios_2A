using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get { return this.periodicidad; }
        }

        private float CalcularInteres()
        {
            switch (this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    return (float)(this.Monto * 0.25);
                case PeriodicidadDePagos.Bimestral:
                    return (float)(this.Monto * 0.35);
                case PeriodicidadDePagos.Trimestral:
                    return (float)(this.Monto * 0.40);
                default:
                    return 0;
            }
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan dias = this.Vencimiento - nuevoVencimiento;
            this.monto += (float)(2.5 * dias.Days);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendFormat(" - Periodicidad: {0} - Interes: {1}", this.periodicidad.ToString(), this.Interes.ToString());
            //sb.AppendLine();
            return sb.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {
            
        }
    }
}
