using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ENTIDADES.SP
{
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre { get => "Manzana"; }
        public override bool TieneCarozo { get => true; }
        public string ProvinciaOrigen { get => this._provinciaOrigen; set => this._provinciaOrigen = value; }

        public Manzana() : base(null, 0)
        {
        }

        public Manzana(string color, double peso, string provinciaOrigen) : base(color, peso)
        {
            this._provinciaOrigen = provinciaOrigen;
        }

        protected override string FrutaToString()
        {
            return this.Nombre + base.FrutaToString() + "PROVINCIA DE ORIGEN: " + this.ProvinciaOrigen + "\n"
                + "TIENE CAROZO: " + this.TieneCarozo.ToString() + "\n";
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool Xml(string path)
        {
            bool flag = false;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + path);
                ser.Serialize(file, this);
                file.Close();
                flag = true;
            }
            catch(Exception e)
            {
                throw e;
            }

            return flag;
        }

        bool IDeserializar.Xml(string path, out Fruta f)
        {
            bool flag = false;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                StreamReader file = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + path);
                f = (Manzana)ser.Deserialize(file);
                file.Close();
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }
    }
}
