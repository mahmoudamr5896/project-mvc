using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Instructor

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image  { get; set; }
        public int Salary { get; set; }
        public string Adress { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        [ForeignKey("Courses")]

        public int Course_ID { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Courses? Courses { get; set; }
    }
}
