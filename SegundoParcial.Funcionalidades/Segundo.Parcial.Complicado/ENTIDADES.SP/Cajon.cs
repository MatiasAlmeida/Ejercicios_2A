using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ENTIDADES.SP
{
    public class Cajon <T> : ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precionUnitario;
        public event PrecioExcedido eventoPrecio;

        public List<T> Elementos { get => this._elementos; }
        public double PrecioTotal { get => this._elementos.Count * this._precionUnitario; }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precionUnitario = precioUnitario;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c._capacidad > c.Elementos.Count)
            {
                c.Elementos.Add(f);

                if (c.PrecioTotal > 55)
                    c.eventoPrecio.Invoke(c.PrecioTotal);
            }
            else
                throw new CajonLlenoException("Maxima capacidad alcanzada. No se pueden agregrar mas frutas.");

            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAPACIDAD: " + this._capacidad.ToString());
            sb.AppendLine("CANTIDAD DE ELEMENTOS: " + this.Elementos.Count.ToString());
            sb.AppendLine("PRECIO TOTAL: " + this.PrecioTotal.ToString());
            foreach (T item in this.Elementos)
                sb.AppendLine(item.ToString());

            return sb.ToString();
        }

        public bool Xml(string path)
        {
            bool flag = false;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
                StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + path);
                ser.Serialize(file, this);
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
