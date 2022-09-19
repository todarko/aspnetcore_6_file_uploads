using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UploadFiles.Data;

namespace UploadFiles.Pages.Upload
{
    public class SingleInputModel : PageModel
    {
        private readonly UploadFiles.Data.ApplicationDbContext _context;

        public SingleInputModel(UploadFiles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MultiAppFile MultiAppFile { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            System.Diagnostics.Debugger.Break();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            //debug and check MultiAppFile

            return RedirectToPage("./Index");
        }
    }
}
