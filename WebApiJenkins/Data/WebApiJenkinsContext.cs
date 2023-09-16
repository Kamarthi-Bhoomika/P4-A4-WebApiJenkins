using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiJenkins.Models;

namespace WebApiJenkins.Data
{
    public class WebApiJenkinsContext : DbContext
    {
        public WebApiJenkinsContext (DbContextOptions<WebApiJenkinsContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiJenkins.Models.Movie> Movie { get; set; } = default!;
    }
}
