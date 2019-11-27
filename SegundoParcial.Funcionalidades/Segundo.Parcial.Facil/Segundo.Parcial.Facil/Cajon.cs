using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Segundo.Parcial.Facil
{
    public class Cajon <T> : ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;

        public List<T> Frutas { get => this._frutas; }
        public float PrecioTotal { get => this.Frutas.Count * this._precioUnitario; }

        public Cajon()
        {
            this._frutas = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c._capacidad > c.Frutas.Count)
                c.Frutas.Add(f);
            else
                throw new CajonLlenoException("No se pueden agregar mas frutas. El cajón alcanzo su capacidad máxima.");

            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CAPACIDAD: " + this._capacidad.ToString() + "\nCANTIDAD DE FRUTAS: " 
                + this.Frutas.Count.ToString() + "\nPRECIO TOTAL: " + this.PrecioTotal.ToString());
            foreach (T item in this.Frutas)
                sb.AppendLine(item.ToString());
            
            return sb.ToString();
        }

        public string RutaArchivo { get; set; }

        public bool SerializarXML()
        {
            bool flag = false;
            this.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CajonDeFrutas.xml";
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
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
            this.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CajonDeFrutas.xml";
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
                StreamReader file = new StreamReader(this.RutaArchivo);
                Cajon<T> aux = (Cajon<T>)ser.Deserialize(file);
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
