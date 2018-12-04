using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("PaymentInformation")]
    public class PaymentInformation
    {
        [Key]
        public int PaymentID { get; set; }
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public string CVC { get; set; }

        [ForeignKey("Client")]
        public virtual int? ClientID { get; set; }
        public virtual Client Client { get; set; }
    }
}