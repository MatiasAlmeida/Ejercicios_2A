using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            Program p = new Program();
           
            e._LimiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            e._LimiteSueldo += new DelegadoSueldo(p.GuardarLog);

            e.Nombre = "Chicho";
            e.Legajo = 12312;
            e.Sueldo = 12001;

            Console.WriteLine(e.ToString());
            Console.ReadKey();
        }

        private static void LimiteSueldoEmpleado(Empleado e, float sueldo)
        {
            Console.WriteLine("{0} {1}\nSe le quizo asignar un sueldo de: {2}", e.Nombre, e.Legajo, sueldo);
        }

        public void GuardarLog(Empleado e, float sueldo)
        {
            try
            {
                StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\archivo.log");

                writer.Write(DateTime.Now + " - " + e.ToString());
                writer.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
