using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }

        public int MinDegree { get; set; }
        [ForeignKey("Department")]
        public int Dept_id { get; set; }

        public virtual Department? Department { get; set; }

    }
}
