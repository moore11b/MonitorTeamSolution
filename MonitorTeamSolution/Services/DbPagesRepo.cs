using Microsoft.AspNetCore.Identity;
using MonitorTeamSolution.Data;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services
{
    public class DbPagesRepo : IPagesRepo
    {
        private readonly ApplicationDbContext _db;
        public DbPagesRepo(ApplicationDbContext db)
        {
            _db = db;
        }



        public IQueryable<PageInfo> ReadAll()
        {
            ICollection<PageInfo> appUsers = new List<PageInfo>();
            foreach (var page in _db.Pages)
            {
                appUsers.Add(page);
            }
            return appUsers.AsQueryable();
        }
    }
}
