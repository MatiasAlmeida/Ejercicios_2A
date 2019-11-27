using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ENTIDADES.SP
{
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get; }
        public string Color { get => this._color; set => this._color = value; }
        public double Peso { get => this._peso; set => this._peso = value; }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return "\nCOLOR: " + this.Color + "\nPESO: " + this.Peso.ToString() + "\n";
        }
    }
}
