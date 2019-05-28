using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return a.Color == b.Color && a.Marca == b.Marca;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        
        public override string ToString()
        {
            return this.Marca + " - " + this.Color;
        }

        public override bool Equals(object obj)
        {
            return obj is Auto && (Auto)obj == this;
        }
    }
}
