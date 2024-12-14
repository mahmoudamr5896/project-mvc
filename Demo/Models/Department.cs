using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manger { get; set; }

    }
}

