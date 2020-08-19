using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GovernmentTaxPrj.Models
{
    public class TaxAccount
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="Please Enter TaxAmount")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage ="Please Enter TaxAccount OpenDate")]
        [Display(Name = "OpenDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OpenDate { get; set; }
    }
}
