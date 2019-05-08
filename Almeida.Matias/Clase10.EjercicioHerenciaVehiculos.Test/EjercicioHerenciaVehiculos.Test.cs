using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase10.Ejercicio_Herencia_Vehiculos.Entidades;

namespace Clase10.EjercicioHerenciaVehiculos.Test
{
    class EjercicioHerenciaVehiculosTest
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto(2, "ASD 123", EMarcas.Zanella, 3);
            Auto auto = new Auto(4, "DVS 532", EMarcas.Fiat, 4);
            Camion camion = new Camion(2, "FSA 245", EMarcas.Scania, 14000);
            Lavadero lavadero = new Lavadero(120, (float)159.2, (float)25.25);

            lavadero += moto;
            lavadero += auto;
            lavadero += camion;

            Console.WriteLine("{0}\n{1}\n{2:#,###.00}", lavadero.MiLavadero, lavadero.MostrarTotalFacturado(EVehiculos.Auto), lavadero.MostrarTotalFacturado());
            lavadero.SortLavaderoPorMarcas();
            Console.WriteLine("\n\n----------\n\n{0}", lavadero.MiLavadero);

            lavadero -= camion;
            Console.WriteLine(lavadero.MiLavadero);
            Console.WriteLine(moto.ToString());
            Console.ReadKey();
        }
    }
}
