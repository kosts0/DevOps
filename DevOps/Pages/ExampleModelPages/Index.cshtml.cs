using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOps.Data;
using DevOps.Models;

namespace DevOps.Pages.ExampleModelPages;

public class IndexModel : PageModel
{
    private readonly DevOps.Data.DevOpsContext _context;

    public IndexModel(DevOps.Data.DevOpsContext context)
    {
        _context = context;
    }

    public IList<ExapmleModel> ExapmleModel { get;set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.ExapmleModel != null)
        {
            ExapmleModel = await _context.ExapmleModel.ToListAsync();
        }
    }
}
