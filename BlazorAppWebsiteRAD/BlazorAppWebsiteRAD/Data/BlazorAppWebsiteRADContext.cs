using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppWebsiteRAD.Model;

namespace BlazorAppWebsiteRAD.Data
{
    public class BlazorAppWebsiteRADContext : DbContext
    {
        public BlazorAppWebsiteRADContext (DbContextOptions<BlazorAppWebsiteRADContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppWebsiteRAD.Model.Monkey> Monkey { get; set; } = default!;
    }
}
