using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GovernmentTaxPrj.Models
{
    [Table("BudgetYear")]
    public class BudgetYear
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="Please Enter BudgetName")]
        [Display(Name ="Budget Year")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter Code")]
        public string Code { get; set; }
        [Required(ErrorMessage ="Please Enter Budget StartDate")]
        
        [Display(Name ="Budget StartDate")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage ="Please Enter Budget EndDate")]
        [Display(Name ="Budget EndDate")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name ="Status")]
        public bool Status { get; set; }
    }
}
