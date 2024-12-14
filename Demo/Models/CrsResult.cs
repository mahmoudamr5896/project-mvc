using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class CrsResult
    {

        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Courses")]
        public int crs_ID { get; set; }
        [ForeignKey("Trainee")]

        public int Trainee_ID { get; set; }

        public virtual Courses? Courses { get; set; }
        public virtual Trainee? Trainee { get; set; }
    }
}
