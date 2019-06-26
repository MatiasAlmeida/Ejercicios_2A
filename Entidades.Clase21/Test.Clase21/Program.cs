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
            h1.Dni = 2412523;
            Persona p1 = new Persona("Rodrigo", "Alvarez");
            p1.Dni = 23451;
            //Persona p2 = new Persona("Chicho", "Benitez");
            Profesor prof1 = new Profesor();
            prof1.Dni = 12425124;
            prof1.Titulo = "pepino";
            Alumno a1 = new Alumno();
            a1.Dni = 123151231;
            a1.Legajo = 1234;
            List<Humano> lista = new List<Humano>();
            lista.Add(h1);
            lista.Add(p1);
            lista.Add(prof1);
            lista.Add(a1);
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(path);
            Program.SerializarAlumno(a1);
            Program.SerializarLista(lista);
            prof1.SerializarXML();

            Console.WriteLine(Program.DeserializarAlumno().ToString());
            Console.ReadKey();
           
        }

        public static bool SerializarAlumno(Alumno a)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                StreamWriter archivo = new StreamWriter("C:/Users/mati_/Desktop/Programacion II - Clases y contenido/MiRepositorio/Ejercicios_2A/Entidades.Clase21" + "@arhivo.xml");
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
            StreamReader archivo = new StreamReader("C:/Users/mati_/Desktop/Programacion II - Clases y contenido/MiRepositorio/Ejercicios_2A/Entidades.Clase21" + "@arhivo.xml");
            XmlSerializer ser = new XmlSerializer(typeof(Alumno));
            Alumno aux;

            aux = (Alumno)ser.Deserialize(archivo);

            archivo.Close();

            return aux;

        }

        public static void SerializarLista(List<Humano> lista)
        {
            StreamWriter archivo = new StreamWriter("C:/Users/mati_/Desktop/Programacion II - Clases y contenido/MiRepositorio/Ejercicios_2A/Entidades.Clase21" + "@otroArhivo.xml");
            XmlSerializer ser = new XmlSerializer(typeof(List<Humano>));

            ser.Serialize(archivo, lista);

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

