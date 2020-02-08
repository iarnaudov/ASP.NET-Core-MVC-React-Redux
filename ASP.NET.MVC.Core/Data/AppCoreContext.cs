using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET.MVC.Core.Models;

namespace ASP.NET.MVC.Core.Data
{
    public class AppCoreContext : DbContext
    {
        public AppCoreContext (DbContextOptions<AppCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET.MVC.Core.Models.Book> Books { get; set; }
    }
}
