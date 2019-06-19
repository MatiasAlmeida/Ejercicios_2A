using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
  public static class Extensora
  {
    public static void Metodo(this Externa.Sellada.PersonaExternaSellada a)
    {
      string aux = a.Apellido;
    }
  }
}
