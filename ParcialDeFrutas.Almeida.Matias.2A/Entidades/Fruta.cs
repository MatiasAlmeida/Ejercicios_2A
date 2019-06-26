using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Fruta
    {
        private ConsoleColor _color;
        private float _peso;

        public abstract bool TieneCarozo { get; }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        protected Fruta() { }

        protected virtual string FrutaToString()
        {
            return "\n\nColor: " + this._color.ToString() + "\nPeso: " + this._peso.ToString();            
        }
    }
}
