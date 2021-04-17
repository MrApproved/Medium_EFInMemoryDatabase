using EFInMemoryDatabase.Database;
using EFInMemoryDatabase.Database.Tables;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace EFInMemoryDatabase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MovieContext _context;
        public List<Movie> Movies { get; set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            MovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }
    }
}
