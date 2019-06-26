using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo <Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.Conexion_bd);
            this.comando = new SqlCommand();
            this.comando.Connection = conexion;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            Sql baseDeDatos = new Sql();
            baseDeDatos.comando.CommandType = CommandType.Text;
            DataTable tablaNueva = new DataTable(tabla);
            baseDeDatos.comando.CommandText = "";
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
        }
    }
}
