using Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Entities.Models;

namespace Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AdminsConfguration());
            builder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
