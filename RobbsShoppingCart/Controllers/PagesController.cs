using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobbsShoppingCart.Infrastructure;
using RobbsShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobbsShoppingCart.Controllers
{
    public class PagesController : Controller
    {
        private readonly RobbsShoppingCartContext context;

        public PagesController(RobbsShoppingCartContext context)
        {
            this.context = context;
        }

        //GET /or /slug
        public async Task<IActionResult> Page(string slug)
        {
            if (slug == null)
            {
                return View(await context.Pages.Where(x => x.Slug == "home").FirstOrDefaultAsync());
            }

            Page page = await context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }
    }
}
