using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Segundo.Parcial.Facil
{
    public class Manzana : Fruta, ISerializable
    {
        public string distribuidora;

        public override bool TieneCarozo { get => true; }
        public string Tipo { get => "Manzana"; }
        public string PaisOrigen { get => this.distribuidora; set => this.distribuidora = value; }

        public Manzana() : base(0, 0)
        {

        }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base(peso, color)
        {
            this.distribuidora = distribuidora;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "PAIS DE ORIGEN: " + this.distribuidora + "\n";
        }

        public override string ToString()
        {
            return this.Tipo + "\n" + this.FrutaToString() + "TIENE CAROZO: " + this.TieneCarozo.ToString() + "\n";
        }

        public string RutaArchivo { get; set; }

        public bool SerializarXML()
        {
            bool flag = false;
            this.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ManzanaSerializada.xml";
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                StreamWriter file = new StreamWriter(this.RutaArchivo);
                ser.Serialize(file, this);
                file.Close();
                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return flag;
        }

        public bool DeserializarXML()
        {
            bool flag = false;
            this.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ManzanaSerializada.xml";
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                StreamReader file = new StreamReader(this.RutaArchivo);
                Manzana aux = (Manzana)ser.Deserialize(file);
                Console.WriteLine(aux.ToString());
                file.Close();
                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return flag;
        }
    }
}
