
using Microsoft.AspNetCore.Identity;
using MonitorTeamSolution.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface IUserRepo
    {
        IQueryable<ApplicationUser> ReadAll();
        ApplicationUser Read(string userName);
        bool AssignRole(string userName, string roleName);
        Task<ApplicationUser> CreateAsync(IdentityUser identityUser, string password);
        bool Exists(string username);

    }
}
