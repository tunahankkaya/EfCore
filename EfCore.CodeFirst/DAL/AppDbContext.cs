using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext :DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (Initializer.Configuration == null)
        {
            Initializer.Build();
        }
        optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }

    public override int SaveChanges()
    {
        ChangeTracker.Entries().ToList().ForEach(e =>
        {
            if (e.Entity is Product product)
            {
                if (e.State == EntityState.Added)   // track'i added olanların CreateDate'ini ekliyoruz.
                    product.CreatedDate = DateTime.Now;
            }
        });

        return base.SaveChanges();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Product>().ToTable("ProductTBB",schema: "productstbb");

        base.OnModelCreating(modelBuilder);
    }
}