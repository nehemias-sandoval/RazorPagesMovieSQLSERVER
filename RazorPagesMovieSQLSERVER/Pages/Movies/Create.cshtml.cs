using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovieSQLSERVER.Data;
using RazorPagesMovieSQLSERVER.Models;

namespace RazorPagesMovieSQLSERVER.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovieSQLSERVER.Data.RazorPagesMovieSQLSERVERContext _context;

        public CreateModel(RazorPagesMovieSQLSERVER.Data.RazorPagesMovieSQLSERVERContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
