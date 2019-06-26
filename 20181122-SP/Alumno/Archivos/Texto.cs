using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.IO;
using System.Text.RegularExpressions;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            try
            {
                StreamWriter file = new StreamWriter(archivo);
                file.Write(datos.ToString());
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            try
            {
                StreamReader file = new StreamReader(archivo);
                Queue<Patente> aux = new Queue<Patente>();
                string auxPatente = file.ReadLine();

                while (auxPatente != null)
                {
                    aux.Enqueue(PatenteStringExtension.ValidarPatente(auxPatente));
                    auxPatente = file.ReadLine();
                }

                datos = aux;                
                file.Close();
            }
            catch(PatenteInvalidaException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
