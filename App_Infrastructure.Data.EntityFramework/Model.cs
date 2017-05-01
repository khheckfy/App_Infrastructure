namespace App_Infrastructure.Data.EntityFramework
{
    using Domain.Entities;
    using System.Data.Entity;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelCs")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.OrderSumm)
                .HasPrecision(18, 6);
        }
    }
}
