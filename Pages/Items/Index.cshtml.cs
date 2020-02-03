using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wesner.Data;
using Wesner.Models;

namespace Wesner
{
    public class IndexModel : PageModel
    {
        private readonly Wesner.Data.WesnerContext _context;

        public IndexModel(Wesner.Data.WesnerContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
