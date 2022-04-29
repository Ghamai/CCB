using CCB.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCB.Data
{
    public class Renewals
    {
        // this is entity class for Renewals
        [Key]
        public int Id { get; set; }
        public string Period { get; set; }
        public double Charbacks { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //adding foreign key for Contractors
        [DisplayName("Contractor")]
        public int ContractorId { get; set; }
        [ForeignKey("ContractorId")]
        public virtual Contractor Contractor { get; set; }
    }
}
