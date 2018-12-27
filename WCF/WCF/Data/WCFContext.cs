using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WCF.Models;

namespace WCF.Models
{
    public class WCFContext : DbContext
    {
        public WCFContext (DbContextOptions<WCFContext> options)
            : base(options)
        {
        }

        public DbSet<WCF.Models.StudentClass> StudentClass { get; set; }

        public DbSet<WCF.Models.Student> Student { get; set; }
    }
}
