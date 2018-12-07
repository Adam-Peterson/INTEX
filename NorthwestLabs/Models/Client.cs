using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Display(Name = "Client Name")]
        [Required(ErrorMessage = "Client Name Required")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Client Name must be 50 characters or less")]
        public string ClientName { get; set; }

        [Display(Name = "Client Address")]
        [Required(ErrorMessage = "Client Address Required")]
        [StringLength(70, MinimumLength = 0, ErrorMessage = "Client Address must be 70 characters or less")]
        public string ClientAddress { get; set; }

        [Display(Name = "Client Address Two: PO BOX (optional)")]
        [StringLength(70, MinimumLength = 0, ErrorMessage = "Client Address must be 70 characters or less")]
        public string ClientAddressTwo { get; set; }

        [Display(Name = "Client State (2 character abbreviation)")]
        [Required(ErrorMessage = "Client State Required")]
        [StringLength(70, MinimumLength = 0, ErrorMessage = "State must be 2 characters only (Ex: 'UT')")]
        public string ClientState { get; set; }

        [Display(Name = "Client City")]
        [Required(ErrorMessage = "Client State Required")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "City must be 50 characters or less")]
        public string ClientCity { get; set; }

        [Display(Name = "Zipcode (5 digit)")]
        [Required(ErrorMessage = "Client Zip Required")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip code must be 5 characters only")]
        public string ClientZipCode { get; set; }

        [Display(Name = "Discount Percentage (Enter Whole Number)")]
        [RegularExpression("^[1-9] [0-9]?$|^100$", ErrorMessage = "Discount Percentage must be between 0 and 100")]
        public Decimal? DiscountPercentage { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Client Phone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Phone Number must be 15 characters or less")]
        public string ClientPhone { get; set; }

        [Display(Name = "Client Balance")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Balance must be numeric")]
        public Decimal? ClientBalance { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Client Email Required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Email must be 50 characters or less")]
        public string ClientEmail { get; set; }





    }
}