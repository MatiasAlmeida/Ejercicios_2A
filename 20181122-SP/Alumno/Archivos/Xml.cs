using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml <T> : IArchivo <T>
    {
        public void Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                StreamWriter file = new StreamWriter(archivo);
                ser.Serialize(file, datos);
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                StreamReader file = new StreamReader(archivo);
                datos = (T)ser.Deserialize(file);
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
