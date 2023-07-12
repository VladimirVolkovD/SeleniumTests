using Core.Configuration;
using Dapper;
using DataBase.Dto;
using MySqlConnector;

namespace DataBase
{
    public class StudentTable
    {
        string connectionString;

        public StudentTable()
        {
            connectionString = new MySqlConnectionStringBuilder
            {
                Server = AppConfiguration.Database.Server,
                Database = AppConfiguration.Database.Database,
                UserID = AppConfiguration.Database.User,
                Password = AppConfiguration.Database.Password,
            }.ConnectionString;

        }

        public List<Student> ReadFromTable()
        {   
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                var parameters = new Dictionary<string, string>
                {
                    {"@Table", "students" }
                };

                var query = "SELECT * FROM students";

                var result = connection.Query<Student>(query).ToList();

               return result;

            }
        }

        public void CreateStudent(Student student)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();                        

                var query = $"INSERT INTO students (name,group_id) VALUES ('{student.Name}',{student.group_id})";

                var result = connection.Query(query);

            }
        }

    }

   

}