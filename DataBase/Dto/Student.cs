using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Dto
{
    [Table("student")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("group_id")]
        public int? group_id { get; set; }
    }
}
