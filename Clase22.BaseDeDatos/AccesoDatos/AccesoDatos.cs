using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AccesoDatos.Properties;

namespace AccesoDatos
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private List<Persona> lista;

        public AccesoDatos()
        {
            this.lista = new List<Persona>();
            this._conexion = new SqlConnection(Properties.Settings.Default.Conexion_bd);
        }

        public List<Persona> TraerTodos()
        {
            AccesoDatos bd = new AccesoDatos();
            this._comando = new SqlCommand();
            this._comando.Connection = bd._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT * FROM Padron.dbo.Personas";

            try
            {
                bd._conexion.Open();
                SqlDataReader dataReader = this._comando.ExecuteReader();

                while (dataReader.Read())
                {
                    Persona aux = new Persona("","",12,23);
                    aux.nombre = dataReader.GetString(0);
                    aux.apellido = dataReader.GetString(0);
                    aux.edad = dataReader.GetInt32(0);
                    aux.id = dataReader.GetInt32(0);
                    bd.lista.Add(aux);

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            this._conexion.Close();

            return bd.lista;
        }

    }

    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int id;

        /*public Persona()
        {
            /*this.apellido;
            this.edad = edad;
            this.id = id;
            this.nombre = nombre;
        }*/

        public Persona(string nombre, string apellido, int edad, int id)
        {
            this.apellido = apellido;
            this.edad = edad;
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.apellido + "-" + this.nombre + "-" + this.edad.ToString() + "-" + this.id.ToString();
        }
    }
}
