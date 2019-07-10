using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almeida.Matias._2A
{
    public class Equipo
    {
        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby
        }

        public Deportes Deporte
        {
            set { deporte = value; }
        }

        static Equipo()
        {
            deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt)
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this(nombre, dt)
        {
            this.Deporte = deporte;
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                    return true;
                else
                    continue;
            }

            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count > 0 && e != j)
                e.jugadores.Add(j);
            else if (e.jugadores.Count == 0)
                e.jugadores.Add(j);

            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e.jugadores.Count > 0 && e == j)
                e.jugadores.Remove(j);

            return e;
        }

        public static implicit operator string(Equipo e)
        {
            string aux = null;
            aux = "**Huracán de San Rafael Futbol**\nNómina Jugadores:\n";

            foreach(Jugador item in e.jugadores)
            {
                aux += item.ToString() + "\n";
            }

            aux += "Dirigido por: " + e.dt.ToString();

            return aux;
        }
    }
}
