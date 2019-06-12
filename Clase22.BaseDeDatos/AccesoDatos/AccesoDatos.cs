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
            this._comando.CommandText = "SELECT nombre,apellido,edad,id FROM Padron.dbo.Personas";

            try
            {
                bd._conexion.Open();
                SqlDataReader dataReader = this._comando.ExecuteReader();

                while (dataReader.Read())
                {
                    Persona aux = new Persona((string)dataReader["nombre"],(string)dataReader["apellido"],(int)dataReader["edad"],(int)dataReader["id"]);
                    bd.lista.Add(aux);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                this._conexion.Close();
            }

            return bd.lista;
        }

        public bool AgregarPersonaABase()
        {
            bool flag = false;
            Persona p1 = new Persona("pepe", "castillo", 12, 24);
            AccesoDatos bd = new AccesoDatos();
            this._comando = new SqlCommand();
            this._comando.Connection = bd._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "INSERT INTO Padron.dbo.Personas" +
                                        "(nombre, apellido, edad)" +
                                        "values" +
                                        "('" + p1.nombre + "', '" + p1.apellido + "', " + p1.edad.ToString() +")";

            try
            {
                bd._conexion.Open();
               // SqlDataReader dataReader = this._comando.ExecuteReader();

                if (this._comando.ExecuteNonQuery() > 0)
                    flag = true;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                this._conexion.Close();
            }

            return flag;
        }

        public bool ModificarPersona(Persona a)
        {
            bool flag = false;
            //Persona p1 = new Persona("pepe", "castillo", 12, 24);
            AccesoDatos bd = new AccesoDatos();
            this._comando = new SqlCommand();
            this._comando.Connection = bd._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "UPDATE Padron.dbo.Personas" +
                                        "SET nombre = '" + a.nombre + "'," +
                                            "apellido = '" + a.apellido + "'," +
                                            "edad = " + a.edad.ToString() +
                                        "WHERE id = 7";

            try
            {
                bd._conexion.Open();
                // SqlDataReader dataReader = this._comando.ExecuteReader();

                if (this._comando.ExecuteNonQuery() > 0)
                    flag = true;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                this._conexion.Close();
            }

            return flag;
        }

        public bool EliminarPersona()
        {
            return true;
        }

        public DataTable TraerTablaPersonas()
        {
            DataTable tablaPersonas = new DataTable("personas");
            AccesoDatos bd = new AccesoDatos();
            this._comando = new SqlCommand();
            this._comando.Connection = bd._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT nombre,apellido,edad,id FROM Padron.dbo.Personas";

            try
            {
                bd._conexion.Open();
                SqlDataReader dataReader = this._comando.ExecuteReader();
                tablaPersonas.Load(dataReader);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                this._conexion.Close();
            }

            return tablaPersonas;
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
