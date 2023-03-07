﻿using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        public DbSet<Admin> admins { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
