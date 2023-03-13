using GoodRead.Domain.Entities.Addresses;
using GoodRead.Domain.Entities.Books;
using GoodRead.Domain.Entities.Orders;
using GoodRead.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GoodRead.DataAccess.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate();
            Database.EnsureCreated();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique(true);
            modelBuilder.Entity<Genre>().HasIndex(x => x.Name).IsUnique(true);
            modelBuilder.Entity<Publisher>().HasIndex(x => x.Name).IsUnique(true);
        }
    }
}
