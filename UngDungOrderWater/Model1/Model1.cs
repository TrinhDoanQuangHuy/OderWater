using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UngDungOrderWater.Model1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Drink>()
                .Property(e => e.TotalPrice)
                .HasPrecision(10, 2);
        }
    }
}
