using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GovernmentTaxPrj.Models
{
    public class IncomeType
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(60,MinimumLength =3)]
        public string Name { get; set; }    
        [Required]
        [Display(Name ="Status")]
        public string Status { get; set; }
        public ICollection<TaxTransaction> TaxTransactions { get; set; }
    }
}
