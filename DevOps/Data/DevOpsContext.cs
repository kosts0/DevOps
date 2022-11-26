using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevOps.Models;

namespace DevOps.Data
{
    public class DevOpsContext : DbContext
    {
        public DevOpsContext (DbContextOptions<DevOpsContext> options)
            : base(options)
        {
        }

        public DbSet<DevOps.Models.ExapmleModel> ExapmleModel { get; set; } = default!;
    }
}
