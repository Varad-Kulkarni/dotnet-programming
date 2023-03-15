using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace csharp_programming {
    class Program {
        static void Main(string[] args) {
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                IDbConnection connection = new SqlConnection(connectionString);
                connection.Open();

                IDbCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.Text;
                authorCommand.CommandText = "select Au_ID, Author from Authors where Au_ID < 10";

                IDataReader authorReader = authorCommand.ExecuteReader();
                while (authorReader.Read()) {
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