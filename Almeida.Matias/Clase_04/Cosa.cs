using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        //para el string = "sin valor";
        //para el entero = 10;
        //para el DateTime = DateTime.Now;

        public Cosa()
        {
            this.cadena = "Sin valor";
            this.entero = 10;
            this.fecha = DateTime.Now;
        }

        public Cosa(int entero) : this()
        {          
           //this.fecha = DateTime.Now;
           //this.cadena = "Sin valor";
            this.entero = entero;
        }

        public Cosa(int entero, DateTime fecha) : this(entero)
        {
            //this.entero = entero;
            this.fecha = fecha;
            //this.cadena = "Sin valor";
        }

        public Cosa(int entero, DateTime fecha, string cadena) : this(entero, fecha)
        {
            //this.entero = entero;
            //this.fecha = fecha;
            this.cadena = cadena;
        }

        public string Mostrar()
        {
            return this.cadena + "-" + this.entero.ToString() + "-" + this.fecha.ToString();
        }

        public static string Mostrar(Cosa objeto)
        {
            return objeto.Mostrar(); //reutilizacion de codigo jeje
                //objeto.cadena + "-" + objeto.entero.ToString() + "-" + objeto.fecha.ToLongTimeString().ToString();
        }  

        public void EstablecerValor(int num)
        {
            this.entero = num;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }


    }
}
