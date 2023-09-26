using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolWepAppTest.Models;

namespace SchoolWepAppTest.Data
{
    public class SchoolWepAppTestContext : DbContext
    {
        public SchoolWepAppTestContext (DbContextOptions<SchoolWepAppTestContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolWepAppTest.Models.Student> Student { get; set; } = default!;
    }
}
