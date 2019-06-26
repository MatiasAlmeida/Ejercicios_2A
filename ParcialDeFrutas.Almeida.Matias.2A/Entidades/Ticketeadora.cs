using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> t, string path)
        {
            bool flag = false;
            try
            {
                StreamWriter wr = new StreamWriter(path);
                wr.WriteLine(DateTime.Now + " - Precio total: " + t.PrecioTotal.ToString());
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return flag;
        }
    }
}
