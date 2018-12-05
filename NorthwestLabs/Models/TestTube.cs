using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestTube")]
    public class TestTube
    {
        [Key]
        public string TestSerialNumber { get; set; }
        public int TestTubeID { get; set; }
        public decimal Concentration { get; set; }

        [ForeignKey("TestTubeStatus")]
        public virtual int TestTubeStatusID { get; set; }
        public virtual TestTubeStatus TestTubeStatus { get; set; }

        [ForeignKey("Compound")]
        public virtual int LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}