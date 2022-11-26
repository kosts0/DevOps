using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevOps.Data;
using DevOps.Models;

namespace DevOps.Pages.ExampleModelPages
{
    public class EditModel : PageModel
    {
        private readonly DevOps.Data.DevOpsContext _context;

        public EditModel(DevOps.Data.DevOpsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExapmleModel ExapmleModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ExapmleModel == null)
            {
                return NotFound();
            }

            var exapmlemodel =  await _context.ExapmleModel.FirstOrDefaultAsync(m => m.ExapmleModelID == id);
            if (exapmlemodel == null)
            {
                return NotFound();
            }
            ExapmleModel = exapmlemodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ExapmleModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExapmleModelExists(ExapmleModel.ExapmleModelID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExapmleModelExists(int id)
        {
          return _context.ExapmleModel.Any(e => e.ExapmleModelID == id);
        }
    }
}
