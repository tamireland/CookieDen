using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieDen.Models
{
    public class DatabaseContext: IdentityDbContext<IdentityUser>
    {
        //private DbContextOptions 
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Cookie> Cookies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
