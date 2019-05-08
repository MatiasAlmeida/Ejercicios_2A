using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Ejercicio_Herencia_Vehiculos.Entidades
{
    public abstract class Vehiculo
    {
        protected string _patente;
        protected Byte _cantRuedas;
        protected EMarcas _marca;

        protected abstract string Mostrar();

        public Vehiculo(string patente, Byte ruedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }

        public string Patente
        {
            get { return this._patente; }
        }

        public string Marca
        {
            get{ return this._marca.ToString(); }
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1._patente == vehiculo2._patente && vehiculo1._marca == vehiculo2._marca;
        } 

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1._patente == vehiculo2._patente && vehiculo1._marca == vehiculo2._marca);
        }

        public override string ToString()
        {
            return this._cantRuedas.ToString() + " - " + this.Marca + " - " + this.Patente;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            /*bool flag = false;

            if (obj is Vehiculo)
            {
                if (this == (Vehiculo)obj)
                {
                    flag = true;
                }
            }*/

            return obj is Vehiculo && this == (Vehiculo)obj;
        }
    }
        /* public override bool Equals(object obj)
         * {
         *      if(obj is OtroObjetoAleatorio)
         *      {
         *          if((OtroObjetoAleatorio)obj.atributos == OtroObjetoAleatorio.atributos)
         *          {
         *              devolver true y que se vayan todos a la concha de su madre;
         *          }
         *          
         *          return;
         *      }
         * }
         * 
         * 
         * 
         */

        // Definiendo la firma de una propiedad y metodos abstractos abajo

        // ej:
        // public abstract double precio { get; set;}; el set y el get depende de si yo quiero que sean de lectura o escritura
        // lo de arriba es para un atributo

        // ahora para un metodo
        // public abstract void Acelerar(); sin poner las llaves del cuerpo del codigo
        // no puede tener sobrecargas, ni para la clase padre ni para los hijos directos del padre, pero si se puede modificar
        // en la descendencia de los hijos directos, es decir, cualquier clase hija que no derive directamente del padre.
}
