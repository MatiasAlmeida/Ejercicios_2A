using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Sanatorio
    {
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Queue<Paciente> pacientesEnEspera;
        private int turnosTotales;

        private Sanatorio()
        {
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
        }

        public Sanatorio(int numero) : this()
        {
            this.turnosTotales = numero;
        }

        private static void TomarDatos(Paciente p)
        {
            StreamWriter wr = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + string.Format("\\{0}.{1}.xml", p.Nombre, p.Apellido));
            XmlSerializer ser = new XmlSerializer(typeof(Paciente));

            ser.Serialize(wr, p);
            wr.Close();
        }

        public static Sanatorio operator +(Sanatorio sanatorio, Paciente p)
        {
            if(sanatorio.turnosTotales > 0)
            {
                sanatorio.pacientesEnEspera.Enqueue(p);
                sanatorio.turnosTotales--;
            }
            else
            {
                TomarDatos(p);
            }

            return sanatorio;
        }
    }
}
