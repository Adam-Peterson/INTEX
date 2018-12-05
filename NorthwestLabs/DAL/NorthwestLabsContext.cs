using NorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwestLabs.DAL
{
    public class NorthwestLabsContext : DbContext
    {
        public NorthwestLabsContext() : base("NorthwestLabsContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<PaymentInformation> PaymentInformations { get; set; }
        public DbSet<Compound> Compounds { get; set; }

        public System.Data.Entity.DbSet<NorthwestLabs.Models.TestTube> TestTubes { get; set; }

        public System.Data.Entity.DbSet<NorthwestLabs.Models.TestTubeStatus> TestTubeStatus { get; set; }
    }
}