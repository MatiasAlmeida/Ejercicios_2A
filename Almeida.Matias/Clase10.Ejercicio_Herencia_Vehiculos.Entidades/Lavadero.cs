using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Ejercicio_Herencia_Vehiculos.Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public string MiLavadero
        {
            get
            {
                string listaVehiculos = this.Vehiculos;
                string listaPrecios = "Precios:\n\nPrecio de Auto: " + this._precioAuto;
                listaPrecios += "\nPrecio de Camion: " + this._precioCamion + "\nPrecio de Moto: " + this._precioMoto + "\n";

                return listaPrecios + listaVehiculos;    
            }
        }

        public string Vehiculos
        {
            get
            {
                string vehiculos = "";

                foreach (Vehiculo item in this._vehiculos)
                {
                    if (item is Auto)
                    {
                        vehiculos += "Auto" + " - " + item.ToString() + "\n";
                    }
                    else if (item is Camion)
                    {
                        vehiculos += "Camion" + " - " + item.ToString() + "\n";
                    }
                    else
                    {
                        vehiculos += "Moto" + " - " + item.ToString() + "\n";
                    }
                }

                return vehiculos;
            }
        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool flag = false;


            foreach (Vehiculo item in lavadero._vehiculos)
            {
                if (item == vehiculo)
                    flag = true;
            }

            return flag;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {   
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
                lavadero._vehiculos.Add(vehiculo);

            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
                lavadero._vehiculos.Remove(vehiculo);

            return lavadero;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Lavadero;
        }

        public double MostrarTotalFacturado()
        {
            double gananciaTotal = 0;

            foreach (Vehiculo item in this._vehiculos)
            {
                if (item is Auto)
                {
                    gananciaTotal += this._precioAuto;
                }
                else if (item is Camion)
                {
                    gananciaTotal += this._precioCamion;
                }
                else
                {
                    gananciaTotal += this._precioMoto;
                }
            }

            return gananciaTotal;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculos)
        {
            double gananciaVehiculo = 0;

            switch (vehiculos)
            {
                case (EVehiculos)0:
                    foreach(Vehiculo item in this._vehiculos)
                    {
                        if (item is Auto)
                            gananciaVehiculo += this._precioAuto;
                    }
                    break;
                case (EVehiculos)1:
                    foreach (Vehiculo item in this._vehiculos)
                    {
                        if (item is Camion)
                            gananciaVehiculo += this._precioCamion;
                    }
                    break;
                case (EVehiculos)2:
                    foreach (Vehiculo item in this._vehiculos)
                    {
                        if (item is Moto)
                            gananciaVehiculo += this._precioMoto;
                    }
                    break;
                default:
                    break;
            }

            return gananciaVehiculo;
        }

        private static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Patente, vehiculo2.Patente);
        }

        private int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Marca, vehiculo2.Marca);
        }

        public void SortLavaderoPorMarcas()
        {
            this._vehiculos.Sort(this.OrdenarVehiculosPorMarca);
        }

        public void SortLavaderoPorPatentes()
        {
            this._vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
        }
    }
}
