using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Mascota.Entidades
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        {
        }

        protected override string Ficha()
        {
            return this.DatosCompletos() + ", edad " + (int)this;
        }

        public static bool operator ==(Perro perro1, Perro perro2)
        {
            return perro1.Nombre == perro2.Nombre && perro1.Raza == perro2.Raza && perro1._edad == perro2._edad;
        }

        public static bool operator !=(Perro perro1, Perro perro2)
        {
            return !(perro1 == perro2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro._edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return obj is Perro && (Perro)obj == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
