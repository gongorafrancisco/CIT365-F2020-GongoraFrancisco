using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Journal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context)
        {
            _context = context;
        }
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentBook { get; set; }
        public string CurrentSort { get; set; }


        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }


        public async Task OnGetAsync(string sortOrder, string SearchString, string ScriptureBook)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = SearchString;
            CurrentBook = ScriptureBook;

            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;

            var scriptures = from s in _context.Scripture
                         select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(CurrentBook))
            {
                scriptures = scriptures.Where(x => x.Book == CurrentBook);
            }

            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }
            
            Scripture = await scriptures.AsNoTracking().ToListAsync();
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

        }
    }
}
