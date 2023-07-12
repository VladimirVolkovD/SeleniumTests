using DataBase;
using DataBase.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    internal class DataBaseTest
    {

        [Test]
        public void Test()
        {
            var students = new StudentTable().ReadFromTable();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.Name}, {student.group_id}");
            }

            new StudentTable().CreateStudent(new Student
            {
                Name = "Ttest From Code",
                group_id = 1,
            });

            students = new StudentTable().ReadFromTable();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.Name}, {student.group_id}");
            }
        }
    }
}
