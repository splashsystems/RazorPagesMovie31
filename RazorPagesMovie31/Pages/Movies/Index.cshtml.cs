using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie31.Data;
using RazorPagesMovie31.Models;

namespace RazorPagesMovie31.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie31.Data.RazorPagesMovie31Context _context;

        public IndexModel(RazorPagesMovie31.Data.RazorPagesMovie31Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
