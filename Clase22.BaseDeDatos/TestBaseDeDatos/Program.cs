using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace TestBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos.AccesoDatos aux = new AccesoDatos.AccesoDatos();

            foreach (Persona item in aux.TraerTodos())
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
