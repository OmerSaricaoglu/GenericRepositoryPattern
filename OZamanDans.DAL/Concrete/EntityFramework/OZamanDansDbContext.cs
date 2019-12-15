using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.DAL.Concrete.EntityFramework
{
    public class OZamanDansDbContext : DbContext
    {
        public OZamanDansDbContext() : base("Server=.; Database=OZamanDansDB; uid=sa; pwd=123")
        {
            Database.SetInitializer(new OZamanDansInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasRequired(a => a.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.CategoryID);
        }

    }

    class OZamanDansInitializer : CreateDatabaseIfNotExists<OZamanDansDbContext>
    {
        protected override void Seed(OZamanDansDbContext context)
        {
            context.Categories.Add(new Category()
            {
                CategoryName = "İçecekler"
            });

            context.Categories.Add(new Category()
            {
                CategoryName = "Yiyecekler"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
