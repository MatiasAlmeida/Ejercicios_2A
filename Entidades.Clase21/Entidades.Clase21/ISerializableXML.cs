using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase21
{
    public interface ISerializableXML
    {
        bool SerializarXML();
        bool DeserializarXML();
        string Path { get; set; }
    }
}
