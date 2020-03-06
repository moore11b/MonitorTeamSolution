using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MonitorTeamSolution.Data;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services
{
    public class DbUserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _db;
        UserManager<IdentityUser> _userManager;
        public DbUserRepo(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IQueryable<ApplicationUser> ReadAll()
        {
            ICollection<ApplicationUser> appUsers = new List<ApplicationUser>();
            foreach (var user in _db.Users)
            {
                ApplicationUser usr = new ApplicationUser
                {
                    User = user
                };
                AddRoles(usr);
                appUsers.Add(usr);
            }
            return appUsers.AsQueryable();
        }

        private void AddRoles(ApplicationUser user)
        {
            var roleIds = _db.UserRoles
               .Where(ur => ur.UserId == user.User.Id)
               .Select(ur => ur.RoleId);
            foreach (var roleId in roleIds)
            {
                user.Roles.Add(_db.Roles.Find(roleId));
            }
        }

        public ApplicationUser Read(string userName)
        {
            ApplicationUser appUser = null;
            var identityUser = _db.Users.FirstOrDefault(u => u.UserName == userName);
            if (identityUser != null)
            {
                appUser = new ApplicationUser
                {
                    User = identityUser
                };
                AddRoles(appUser);
            }
            return appUser;
        }

        public bool AssignRole(string userName, string roleName)
        {
            var user = Read(userName);
            if (user != null)
            {
                //If user does not have role roleName
                if (!user.HasRole(roleName))
                {
                    _userManager.AddToRoleAsync(user.User, roleName).Wait();
                    return true;
                }
            }
            return false;
        }

        public async Task<ApplicationUser> CreateAsync(IdentityUser identityUser, string password)
        {
            await _userManager.CreateAsync(identityUser, password);
            ApplicationUser user = new ApplicationUser
            {
                User = identityUser
            };
            return user;
        }


        public bool Exists(string username)
        {
            if (_db.Users.Any(u => u.UserName == username))
            {
                return false;
            }
            return true;
        }
    }//end class
}//end namespace
