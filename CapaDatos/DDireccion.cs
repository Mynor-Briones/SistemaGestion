using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDireccion
    {
        public int Id_Direccion { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public int Codigo_Postal { get; set; }

        public DDireccion BuscarPorId(int id)
        {
            DDireccion direccion = new DDireccion();
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;

                SqlComando.CommandText = "SELECT * FROM [BD_Gestion].[dbo].[DIRECCIONES] where id_direccion =" + id;

                SqlComando.CommandType = CommandType.Text;

                SqlDataReader reader = SqlComando.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        direccion.Id_Direccion = id;
                        direccion.Calle = reader[1].ToString();
                        direccion.Numero = int.Parse(reader[2].ToString());
                        direccion.Piso = reader[3].ToString();
                        direccion.Departamento = reader[4].ToString();
                        direccion.Ciudad = reader[5].ToString();
                        direccion.Provincia = reader[6].ToString();
                        direccion.Pais = reader[7].ToString();
                        direccion.Codigo_Postal = int.Parse(reader[8].ToString());

                    }
                }

                
            }

            catch (Exception ex)
            {
                direccion = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.BuscarCliente. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return direccion;
        }
    }
}
