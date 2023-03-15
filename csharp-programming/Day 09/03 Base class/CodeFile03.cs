﻿using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace csharp_programming {
    class Program {
        private static DbProviderFactory _providerFactory = SqlClientFactory.Instance;

        static void Main(string[] args) {
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                DbConnection connection = _providerFactory.CreateConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.Text;
                authorCommand.CommandText = "select Au_ID, Author from Authors where Au_ID < 10";

                DbDataReader authorReader = authorCommand.ExecuteReader();
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