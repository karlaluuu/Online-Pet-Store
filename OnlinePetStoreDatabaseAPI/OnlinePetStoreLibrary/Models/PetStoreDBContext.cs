using Microsoft.EntityFrameworkCore;

namespace OnlinePetStoreLibrary.Models
{
    public partial class PetStoreDBContext : DbContext
    {
        public PetStoreDBContext() { }
        public PetStoreDBContext(DbContextOptions<PetStoreDBContext> options) : base(options) { }
        public virtual DbSet<PetStore> Stores {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=petstore.c4bcpnfm8hyd.us-east-2.rds.amazonaws.com,1433;Database=petStoreDB;UserID=admin;Password=password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetStore>(entity =>
            {
                entity.HasKey(e => e.StoreId);
                entity.Property(e => e.StoreId).ValueGeneratedNever();
                entity.Property(e => e.StoreAddress);
                entity.Property(e => e.StoreDescription);
                entity.Property(e => e.StoreName).IsRequired().HasMaxLength(200);

            });
        }
    }

}
