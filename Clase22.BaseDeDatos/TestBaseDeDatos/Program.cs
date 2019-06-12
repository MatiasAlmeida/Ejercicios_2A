using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
namespace TestBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AccesoDatos.AccesoDatos aux = new AccesoDatos.AccesoDatos();
            Persona p1 = new Persona("carlos", "ponche", 54, 12);*/
            DataTable leer = new DataTable("personas");

            /*foreach (Persona item in aux.TraerTodos())
            {
                Console.WriteLine(item.ToString());
            }

            /*if (aux.AgregarPersonaABase())
                Console.WriteLine("Se agrego la personita capo");*/

            //if(aux.ModificarPersona(p1))

            /*leer = aux.TraerTablaPersonas();

            foreach (DataRow item in leer.Rows)
            {
                Console.WriteLine(item["nombre"].ToString() + item["apellido"].ToString() + "-" + item["edad"] + "-" +item["id"]); // cuando haces ReadXmlSchema 
                                                                                                                                   // lo lee en este orden que se
                                                                                                                                   // cargó (se cargo en este orden
                                                                                                                                   // en el metodo TraerTablaPersonas,
                                                                                                                                   // por esa razon tambien lo lei 
                                                                                                                                   // así).
            }

            leer.WriteXmlSchema("Personas_esquema.xml");
            leer.WriteXml("Personas_datos.xml");*/
            leer.ReadXmlSchema("Personas_esquema.xml");
            Console.ReadKey();
        }
    }
}
