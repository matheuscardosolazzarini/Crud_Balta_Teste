using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BaltaTest.Models;
using BaltaTeste.Data;

namespace BaltaTeste.Pages_Premiums
{
    public class IndexModel : PageModel
    {
        private readonly BaltaTeste.Data.ApplicationDbContext _context;

        public IndexModel(BaltaTeste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premiums.ToListAsync();
        }
    }
}
