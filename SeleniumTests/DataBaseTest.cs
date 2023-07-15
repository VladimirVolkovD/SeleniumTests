using DataBase;
using DataBase.Dto;

namespace SeleniumTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    internal class DataBaseTest
    {
        StudentTable studentTable = new();

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Before test\n" + new string('-', 20));
            var students = studentTable.GetAllStudent();
            DatabaseUtils.PrintQueryResults(students);
        }


        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("After test\n" + new string('-', 20));

            var students = studentTable.GetAllStudent();
            DatabaseUtils.PrintQueryResults(students);
        }

        [Test]
        [Order(0)]
        public void CreatNewStudent()
        {
            Student newStudent = new Student { Name = "dbuser_AT_DeleteUser_After_Test", group_Id = 1 };
            studentTable.CreatNewStudent(newStudent);
        }

        [Test]
        [Order(1)]
        public void UpdateStudent()
        {
            var oldSudent = studentTable.GetAllStudent().First(x => x.Name.Equals("dbuser"));

            oldSudent.group_Id = 3;

            studentTable.UpdateStudent(oldSudent);
        }

        [Test]
        [Order(2)]
        public void DeleteStudent()
        {
            var oldSudent = studentTable.GetAllStudent().First(x => x.Name.Equals("dbuser"));
            studentTable.DeleteStudentByName(oldSudent.Name);
        }

    }
}
