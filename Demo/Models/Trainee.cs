using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? IMage { get; set; }

        public int Grade { get; set; }
        [ForeignKey("Department")]
        public int Dept_id { get; set; }

        public virtual Department? Department { get; set; }  
    }
}
