
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RobbsShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobbsShoppingCart.Infrastructure
{
    public class RobbsShoppingCartContext : IdentityDbContext<AppUser>
    {
        public RobbsShoppingCartContext(DbContextOptions<RobbsShoppingCartContext> options)
            :base(options)
        {
                
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
