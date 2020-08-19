using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GovernmentTaxPrj.Models
{
    [Table("TaxPayer")]
    public class TaxPayer
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter TinNumber")]
        public string TinNumber { get; set; }
        [Required(ErrorMessage ="Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Please Enter Nrc")]
        public string Nrc { get; set; }
        [Required(ErrorMessage ="Please Enter TaxType")]
        public string TaxType { get; set; }
        [ForeignKey("Township")]
        public long TownshipId { get; set; }
        public Township Township { get; set; }
    }
}
