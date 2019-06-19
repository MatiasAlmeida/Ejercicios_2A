using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private string _name;
        private int _legajo;
        private float _sueldo;
        public event DelegadoSueldo _LimiteSueldo;
        
        public string Nombre
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public float Sueldo
        {
            get { return this._sueldo; }
            set {
                if (value > 12000)                   
                    this._LimiteSueldo(this, value);
                else
                    this._sueldo = value; }
        }

        public override string ToString()
        {
            return this.Nombre + "-" + this.Legajo.ToString() + "-" + this.Sueldo.ToString();
        }
        

        
    }
}
