using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ENTIDADES.SP
{
    public static class ClaseExtensora
    {
        public static bool EliminarFruta(this Cajon<Manzana> c, int id)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();
            SqlConnection bdConnection = new SqlConnection(Properties.Settings.Default.Conexion_bd);
            SqlCommand command = new SqlCommand();
            command.Connection = bdConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM sp_lab_II.dbo.frutas WHERE id = " + id.ToString();

            try
            {
                bdConnection.Open();

                if (command.ExecuteNonQuery() > 0)
                    flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                bdConnection.Close();
            }

            return flag;
        }
    }
}
