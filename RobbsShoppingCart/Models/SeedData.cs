using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RobbsShoppingCart.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobbsShoppingCart.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RobbsShoppingCartContext
                (serviceProvider.GetRequiredService<DbContextOptions<RobbsShoppingCartContext>>()))
            {
                if(context.Pages.Any())
                {
                    return;
                }

                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Context = "home page",
                        Sorting = 0
                    },
                    new Page
                    {
                        Title = "About us",
                        Slug = "about us",
                        Context = "about us page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Context = "services page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Contact",
                        Slug = "contact",
                        Context = "contact page",
                        Sorting = 100
                    }

                 );
                context.SaveChanges();
            }
        }
    }
}
