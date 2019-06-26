using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.Clase21
{
    public class Persona : Humano, ISerializableXML, ISerializableBinario
    {
        private string apellido;
        private string nombre;

        public Persona() : this("","")
        {

        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.apellido + " - " + this.nombre;
        }

        public bool DeserializarXML()
        {
            return true;
        }

        public bool SerializarXML()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                StreamWriter archivo = new StreamWriter("D:/VisualStudio/Almeida.Matias" + "@arhivo.xml");
                ser.Serialize(archivo, this);
                archivo.Close();
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return false;
            }
        }

        public string Path
        {
            set; get;
        }

        bool ISerializableBinario.SerializarXML()
        {
            return true;
        }
    }
}
