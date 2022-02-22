using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RealSourceCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RealSourceCore.Models.ViewModels;

namespace RealSourceCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set;}

        public DbSet<RealSourceCore.Models.ViewModels.CustomerVM> CustomerVM { get; set; }

    }
}
