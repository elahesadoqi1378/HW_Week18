using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2
{
    public class AppDBContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer
                   ("Data Source =ELAMIR\\SQLEXPRESS; Database =Hw_Week18; Integrated Security=True; User ID = sa; Password =123456 ; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoryy>().HasData(
               new Categoryy { Id = 1, Name = "Electronics" },
               new Categoryy { Id = 2, Name = "Clothing" },
               new Categoryy { Id = 3, Name = "ّFood" }
           );

            modelBuilder.Entity<Productt>().HasData(
                new Productt { Id = 1, Name = "Laptop", Price = 1000, CategoryId = 1 },
                new Productt { Id = 2, Name = "Smartphone", Price = 800, CategoryId = 1 },
                new Productt { Id = 3, Name = "T_shirt", Price = 400, CategoryId = 2 },
                new Productt { Id = 4, Name = "Meat", Price = 500, CategoryId = 3 }
            );
            modelBuilder.Entity<User>().HasData(

                new User { Id = 1, UserName = "ela", Password = "1234", Email = "ela.sdq@gmail.com" },
                new User { Id = 2, UserName = "amir", Password = "1234", Email = "amir.nameni@gmail.com" }

            );
            modelBuilder.Entity<Productt>()
           .HasOne(p => p.Category)
           .WithMany(c => c.Products)
           .HasForeignKey(p => p.CategoryId);

        }
        public DbSet<Categoryy> Categories { get; set; }
        public DbSet<Productt> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }


}





