using Modelos;
using System.Data.SqlClient;

namespace ejercicioperros
{
    public class DPerro
    {
        public static void Insert(string nombre, string apellido, string raza, int peso)
        {
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conec = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand("InsertPerro", conec);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@raza", raza);
            command.Parameters.AddWithValue("@peso", peso);

            conec.Open();
            command.ExecuteNonQuery();
            conec.Close();

        }
        public static void Update(int id, string nombre, string apellido, string raza, int peso)
        {
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conec = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand("UpdatePerro", conec);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@raza", raza);
            command.Parameters.AddWithValue("@peso", peso);

            conec.Open();
            command.ExecuteNonQuery();
            conec.Close();

        }
        public static void Delete(int id)
        {
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conec = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand("DeletePerro", conec);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);

            conec.Open();
            command.ExecuteNonQuery();
            conec.Close();

        }

        public static List<Perro> GetAll(){
           var lista = new List<Perro>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                SqlConnection conec=new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllPerro", conec);
                conec.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Perro p = new Perro();
                    p.id = Convert.ToInt32(reader["id"]);
                    p.nombre = reader["nombre"].ToString();
                    p.apellido = reader["apellido"].ToString();
                    p.raza = reader["raza"].ToString();
                    p.peso = Convert.ToInt32(reader["peso"]);
                    lista.Add(p);
                }
                conec.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return lista;
        }

    }
}