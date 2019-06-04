using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase21;
using System.Xml.Serialization;
using System.IO;

namespace Test.Clase21
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano h1 = new Humano();
            Persona p1 = new Persona("Rodrigo", "Alvarez");
            //Persona p2 = new Persona("Chicho", "Benitez");
            Profesor prof1 = new Profesor();
            Alumno a1 = new Alumno();
            List<Humano> lista = new List<Humano>();
            lista.Add(h1);
            lista.Add(p1);
            lista.Add(prof1);
            lista.Add(a1);
            Program.SerializarAlumno(a1);
            Program.SerializarLista(lista);

            Console.WriteLine(Program.DeserializarAlumno().ToString());
            Console.ReadKey();


           
        }

        public static bool SerializarAlumno(Alumno a)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                StreamWriter archivo = new StreamWriter("D:/VisualStudio/Almeida.Matias" + "@arhivo.xml");
                ser.Serialize(archivo,a);
                archivo.Close();
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return false;
            }

            
        }

        public static Alumno DeserializarAlumno()
        {
            StreamReader archivo = new StreamReader("D:/VisualStudio/Almeida.Matias" + "@arhivo.xml");
            XmlSerializer ser = new XmlSerializer(typeof(Alumno));
            Alumno aux;

            aux = (Alumno)ser.Deserialize(archivo);

            archivo.Close();

            return aux;

        }

        public static void SerializarLista(List<Humano> lista)
        {
            StreamWriter archivo = new StreamWriter("D:/VisualStudio/Almeida.Matias" + "@otroArhivo.xml");
            XmlSerializer ser = new XmlSerializer(typeof(Humano));

            foreach (Humano item in lista)
            {
                ser.Serialize(archivo,item);
            }

            archivo.Close();
        }

        public static List<Humano> DeserializarLista()
        {
            return null;
        }

        //public bool SerializarXML(); //son como abstract pero no llevan abstract , porque son interfaces
                                       //las clases deben implementar todos los metodos de de la clase interfaz
                                       //son clases, pero trabajan con generics

        public static bool SerializarXML(ISerializableXML o)
        {
            o.SerializarXML();
            return true;
        }
    }
}

