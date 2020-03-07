using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Models.ViewModels;

namespace MonitorTeamSolution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Logs> Logs { get; set; }
        public DbSet<PageInfo> Pages { get; set; }
        public DbSet<MonitorTeamSolution.Models.ViewModels.UserListVM> UserListVM { get; set; }
        public DbSet<MonitorTeamSolution.Models.ViewModels.LogListVM> LogListVM { get; set; }
        public DbSet<MonitorTeamSolution.Models.ViewModels.PageListVM> PageListVM { get; set; }
    }
}
