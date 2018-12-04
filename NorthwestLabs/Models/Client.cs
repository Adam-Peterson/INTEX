using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientAddressTwo { get; set; }
        public string ClientState { get; set; }
        public string ClientCity { get; set; }
        public string ClientZipCode { get; set; }
        public Decimal? DiscountPercentage { get; set; }
        public string ClientPhone { get; set; }
        public Decimal? ClientBalance { get; set; }
        public string ClientEmail { get; set; }
    }
}