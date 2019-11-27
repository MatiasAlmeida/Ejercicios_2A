using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Segundo.Parcial.Facil
{
    public static class Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> c, string path)
        {
            bool flag = false;
            try
            {
                StreamWriter file = new StreamWriter(path);
                file.WriteLine(DateTime.Now.ToString());
                file.WriteLine(c.PrecioTotal.ToString());
                file.Close();
                flag = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return flag;
        }
    }
}
