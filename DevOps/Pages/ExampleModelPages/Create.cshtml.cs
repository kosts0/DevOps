using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DevOps.Data;
using DevOps.Models;

namespace DevOps.Pages.ExampleModelPages
{
    public class CreateModel : PageModel
    {
        private readonly DevOps.Data.DevOpsContext _context;

        public CreateModel(DevOps.Data.DevOpsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ExapmleModel ExapmleModel { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ExapmleModel.Add(ExapmleModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
