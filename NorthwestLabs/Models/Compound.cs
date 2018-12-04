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
        public string CompoundDescription { get; set; }
        public decimal MaxToleratedDosage { get; set; }

        [ForeignKey("WorkOrder")]
        public virtual int? OrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}