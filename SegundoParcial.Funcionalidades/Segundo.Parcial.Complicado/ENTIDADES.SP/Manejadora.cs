using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ENTIDADES.SP
{
    public class Manejadora <T>
    {
        public void Manejador(double precioTotal)
        {
            try
            {
                StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ArchivoEvento.txt");
                file.WriteLine(DateTime.Now.ToString());
                file.WriteLine("PRECIO TOTAL: " + precioTotal.ToString());
                file.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
