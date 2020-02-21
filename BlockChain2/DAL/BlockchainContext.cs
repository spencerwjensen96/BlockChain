using BlockChain2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BlockChain2.DAL
{
    public class BlockchainContext: DbContext
    {
        public DbSet<DeliveryService> DeliveryServices{ get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MovementStatus> MovementStatuses { get; set; }
        //public DbSet<Purchaser> Purchasers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Vendor> Vendors { get; set; }
    }
}