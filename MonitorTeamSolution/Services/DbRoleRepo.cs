using Microsoft.AspNetCore.Identity;
using MonitorTeamSolution.Data;
using MonitorTeamSolution.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services
{
    public class DbRoleRepo : IRoleRepo
    {
        private readonly ApplicationDbContext _db;
    public DbRoleRepo(ApplicationDbContext db)
    {
        _db = db;
    }

    public IQueryable<IdentityRole> ReadAll()
    {
        var list = _db.Roles.ToList();
        var query = list.AsQueryable();
        return query;
    }

}
}
