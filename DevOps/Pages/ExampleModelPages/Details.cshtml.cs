using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOps.Data;
using DevOps.Models;

namespace DevOps.Pages.ExampleModelPages
{
    public class DetailsModel : PageModel
    {
        private readonly DevOps.Data.DevOpsContext _context;

        public DetailsModel(DevOps.Data.DevOpsContext context)
        {
            _context = context;
        }

      public ExapmleModel ExapmleModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ExapmleModel == null)
            {
                return NotFound();
            }

            var exapmlemodel = await _context.ExapmleModel.FirstOrDefaultAsync(m => m.ExapmleModelID == id);
            if (exapmlemodel == null)
            {
                return NotFound();
            }
            else 
            {
                ExapmleModel = exapmlemodel;
            }
            return Page();
        }
    }
}
