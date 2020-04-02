using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sample_webapp.Data;
using sample_webapp.Models;

namespace sample_webapp.Views.Movies
{
    public class IndexModel : PageModel
    {
        private readonly sample_webapp.Data.sample_webappContext _context;

        public IndexModel(sample_webapp.Data.sample_webappContext context)
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
