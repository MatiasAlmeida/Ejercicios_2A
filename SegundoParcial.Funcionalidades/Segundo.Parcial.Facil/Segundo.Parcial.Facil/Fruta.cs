using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo.Parcial.Facil
{
    public abstract class Fruta
    {
        private ConsoleColor _color;
        private float _peso;

        public abstract bool TieneCarozo { get; }
        public ConsoleColor Color { get => this._color; set => this._color = value; }
        public float Peso { get => this._peso; set => this._peso = value; }

        public Fruta(float peso, ConsoleColor color)
        {
            this._peso = peso;
            this._color = color;
        }

        protected virtual string FrutaToString()
        {
            return "PESO: " + this._peso.ToString() + "\n" + "COLOR: " + this._color.ToString() + "\n";
        }
    }
}
