using DataBase.Dto;

namespace DataBase
{
    public class StudentTable
    {
        public IEnumerable<Student> GetAllStudent()
        {
            return DatabaseUtils.ReadRecords<Student>("SELECT * FROM students");
        }

        public long  CreatNewStudent(Student student)
        {
           return DatabaseUtils.InsertRecord(student);
        }

        public void UpdateStudent(Student student)
        {
            var studentToUpdate = DatabaseUtils.ReadRecord<Student>("SELECT * FROM students WHERE Id = @id", new { id = student.Id });

            if (studentToUpdate != null)
            {
                studentToUpdate.Name = student.Name;
                studentToUpdate.group_Id = student.group_Id;
                DatabaseUtils.UpdateRecord(studentToUpdate);
            }
        }

        public void DeleteStudentByName(string name)
        {
            var studentToDelete = DatabaseUtils.ReadRecord<Student>("SELECT * FROM students WHERE Name = @name", new { name });

            if (studentToDelete != null)
            {
                DatabaseUtils.DeleteRecord(studentToDelete);
            }
        }

    }
}