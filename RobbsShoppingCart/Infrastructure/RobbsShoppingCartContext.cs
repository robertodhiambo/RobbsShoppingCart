using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobbsShoppingCart.Infrastructure
{
    public class RobbsShoppingCartContext : DbContext
    {
        public RobbsShoppingCartContext(DbContextOptions<RobbsShoppingCartContext> options)
            :base(options)
        {
                
        }
    }
}
