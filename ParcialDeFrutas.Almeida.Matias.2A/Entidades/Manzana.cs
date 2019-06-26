using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Manzana : Fruta , ISerializable
    {
        private string distribuidora;

        public override bool TieneCarozo { get { return true; } }

        public string Tipo { get { return "Manzana"; } }

        string ISerializable.RutaArchivo
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.xml"; }
            set
            {
                string aux1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                string aux2 = null;
                aux2 = aux1 + value;
            }
        }

        public Manzana() { }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base(peso, color)
        {
            this.distribuidora = distribuidora;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "\nDistribuidora: " + this.distribuidora + "\nTiene caroso?: " + this.TieneCarozo
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
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
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
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                Manzana aux;

                aux = (Manzana)ser.Deserialize(wr);
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
