using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Mascota.Entidades
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;

        public EtipoManada Tipo
        {
            set { _tipo = value; }
        }

        static Grupo()
        {
            _tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada etipo) : this(nombre)
        {
            this.Tipo = etipo;
        }

        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            bool flag = false;

            foreach (Mascota item in grupo._manada)
            {
                if (mascota == item)
                    flag = true;
            }

            return flag;
        }

        public static bool operator !=(Grupo grupos, Mascota mascota)
        {
            return !(grupos == mascota);
        }

        public static Grupo operator +(Grupo grupos, Mascota mascota)
        {
            if (grupos != mascota)
                grupos._manada.Add(mascota);
            else
                Console.WriteLine("Ya está el {0} en el grupo.", mascota.ToString());

            return grupos;
        }

        public static Grupo operator -(Grupo grupos, Mascota mascota)
        {
            if (grupos == mascota)
                grupos._manada.Remove(mascota);
            else
                Console.WriteLine("No está el {0} en el grupo.", mascota.ToString());

            return grupos;
        }

        public static implicit operator string(Grupo grupo)
        {
            string retorno;

            retorno = "Grupo: " + grupo._nombre + " - tipo: " + Grupo._tipo.ToString() + "\nIntegrantes <" + grupo._manada.LongCount() + ">:\n";
            foreach(Mascota item in grupo._manada)
            {
                retorno += item.ToString() + "\n";
            }

            return retorno;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
