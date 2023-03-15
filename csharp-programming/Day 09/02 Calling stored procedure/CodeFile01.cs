using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace csharp_programming {
    class Program {
        static void Main(string[] args) {
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.StoredProcedure;
                authorCommand.CommandText = "AuthorDetails";
                SqlParameter authorId = new SqlParameter("@au_id", 1);
                authorCommand.Parameters.Add(authorId);

                SqlDataReader authorReader = authorCommand.ExecuteReader();
                if (authorReader.HasRows) {
                    authorReader.Read();
                    Console.WriteLine("\t{0}\t{1}", authorReader["Au_ID"], authorReader["Author"]);
                }

                authorReader.Close();
                connection.Close();
            }
            catch (SqlException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}