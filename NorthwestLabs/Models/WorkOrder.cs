using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        public int OrderID { get; set; }
        public String OrderComments { get; set; }
        public Decimal MinQuotedPrice { get; set; }
        public Decimal MaxQuotedPrice { get; set; }
        public DateTime? DueDate { get; set; }
        public Decimal? CashAdvance { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey("Client")]
        public virtual int? ClientID { get; set; }
        public virtual Client Client { get; set; }
    }
}