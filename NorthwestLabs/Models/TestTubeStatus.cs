using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestTubeStatus")]
    public class TestTubeStatus
    {
        [Key]
        public int TestTubeStatusID { get; set; }
        public string TestTubeStatusDescription { get; set; }
    }
}