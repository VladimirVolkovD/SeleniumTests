using Dapper.Contrib.Extensions;

namespace DataBase.Dto
{
    [Table("students")]
    public class Student : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? group_Id { get; set; }             
    }
}
