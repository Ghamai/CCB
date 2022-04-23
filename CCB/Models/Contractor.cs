using System.ComponentModel.DataAnnotations;

namespace CCB.Models
{
    public class Contractor
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Manager { get; set; }
        public string  Title { get; set; }
        public int CurrentCtsNumber { get; set; }

    }
}
