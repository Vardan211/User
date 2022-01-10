using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskVardan.DataAccess
{
    public class DataContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
