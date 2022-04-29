using System;
using System.ComponentModel.DataAnnotations;

namespace CCB.Data
{
    public class Contractors
    {
        //This is entity class for contractors
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Manager { get; set; }
        public string Title { get; set; }
        public int CurrentCtsNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
