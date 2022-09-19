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
    public class MultipleInputModel : PageModel
    {
        private readonly UploadFiles.Data.ApplicationDbContext _context;

        public MultipleInputModel(UploadFiles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public List<AppFile> AppFile { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            System.Diagnostics.Debugger.Break();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AppFiles.AddRange(AppFile);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
