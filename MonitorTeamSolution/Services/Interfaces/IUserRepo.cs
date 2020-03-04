
using MonitorTeamSolution.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface IUserRepo
    {
        /// <summary>
        /// Reads all the users in the database. 
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<ApplicationUser>> ReadAllAsync();
        /// <summary>
        /// Finds a user by the user's id.  Returns the instance 
        /// of the user as an async task.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApplicationUser> ReadAsync(string username);
        /// <summary>
        /// Assigns a role to the user. (If required)
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<bool> AssignRoleAsync(string userName, string roleName);
        /// <summary>
        /// Finds a user by an email address.  Returns the instance 
        /// of the user as an async task. 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<ApplicationUser> ReadAsyncByEmail(string email);

    }
}
