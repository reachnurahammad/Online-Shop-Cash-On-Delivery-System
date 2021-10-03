using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Dasktop> Desktop { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Laptop> Laptop { get; set; }
        public DbSet<Baik> Baik { get; set; }
        public DbSet<Watch> Watch { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Tv> Tv { get; set; }
        public DbSet<Refrigerator> Refrigerator { get; set; }
        public DbSet<OrderAddress> OrderAddress { get; set; }

        ///....../
        public DbSet<Aarong> Aarong { get; set; }
        public DbSet<BdFood> BdFood { get; set; }
        public DbSet<Lux> Lux { get; set; }
        public DbSet<Shopno> Shopno { get; set; }
        public DbSet<Unilever> Unilever { get; set; }
        public DbSet<AmanFeed> AmanFeed { get; set; }
        public DbSet<Tshirt> Tshirt { get; set; }
        public DbSet<Aci> Aci { get; set; }
        public DbSet<Dano> Dano { get; set; }
        public DbSet<Fresh> Fresh { get; set; }
        public DbSet<Lifebuoy> Lifebuoy { get; set; }
        public DbSet<Primier> Primier { get; set; }
        public DbSet<Jamuna> Jamuna { get; set; }
        public DbSet<Efood> Efood { get; set; }
        public DbSet<Contact> Contact { get; set; }
       
    } 
}
