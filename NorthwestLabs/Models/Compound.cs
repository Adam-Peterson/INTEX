using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        public int LTNumber { get; set; }

        [Display(Name = "Compound Description")]
        [Required(ErrorMessage = "Compound Description Required")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Compound Description must be 250 characters or less")]
        public string CompoundDescription { get; set; }

        [Display(Name = "Maximum Tolerated Dosage")]
        [Required(ErrorMessage = "Maximum Tolerated Dosage Required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Maximum Tolerated Dosage must be numeric")]
        public decimal MaxToleratedDosage { get; set; }

        [ForeignKey("WorkOrder")]
        public virtual int? OrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}