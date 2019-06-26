using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Platano : Fruta , ISerializable
    {
        private string paisOrigen;

        public override bool TieneCarozo { get { return false; } }

        public string Tipo { get { return "Platano"; } }

        string ISerializable.RutaArchivo
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.xml"; }
            set { string aux1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                string aux2 = null;
                aux2 = aux1 + value;  }
        }

        public Platano() { }

        public Platano(float peso, ConsoleColor color, string pais) : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "\nPais de origen: " + this.paisOrigen + "\nTiene caroso?: " + this.TieneCarozo
                + "\nTipo: " + this.Tipo;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        bool ISerializable.SerializarXML()
        {
            bool flag = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Platano));
                StreamWriter wr = new StreamWriter(((ISerializable)this).RutaArchivo);

                ser.Serialize(wr, this);
                wr.Close();
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return flag;
        }

        bool ISerializable.Deserializar()
        {
            bool flag = false;
            try
            {
                StreamReader wr = new StreamReader(((ISerializable)this).RutaArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(Platano));
                Platano aux;

                aux = (Platano)ser.Deserialize(wr);
                wr.Close();
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return flag;
        }
    }
}
