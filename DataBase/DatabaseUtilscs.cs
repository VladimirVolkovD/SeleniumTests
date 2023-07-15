using Core.Configuration;
using Dapper;
using Dapper.Contrib.Extensions;
using MySqlConnector;
using System.Data;

namespace DataBase
{
    public class DatabaseUtils
    {
        private static string connectionString;

        static DatabaseUtils()
        {
            connectionString = new MySqlConnectionStringBuilder
            {
                Server = AppConfiguration.Database.Server,
                Database = AppConfiguration.Database.Database,
                UserID = AppConfiguration.Database.User,
                Password = AppConfiguration.Database.Password,
            }.ConnectionString;
        }

        public static long InsertRecord<T>(T record) where T : class
        {
            long result = -1;
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                result = connection.Insert(record);
            }

            return result;
        }

        public static IEnumerable<T> ReadRecords<T>(string query, object parameters = null)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<T>(query, parameters);
            }
        }

        public static T ReadRecord<T>(string query, object parameters = null)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<T>(query, parameters);
            }
        }

        public static void UpdateRecord<T>(T record) where T : class
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                connection.Update(record);
            }
        }

        public static void DeleteRecord<T>(T record) where T : class
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                connection.Delete(record);
            }
        }

        public static void PrintQueryResults<T>(IEnumerable<T> records)
        {
            foreach (var record in records)
            {
                Console.WriteLine(record);
            }
        }
    }
}
