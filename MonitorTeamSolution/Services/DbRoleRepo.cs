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
        /// <summary>
        /// Private field to inject the DbContext into the Constructor. 
        /// </summary>
        private ApplicationDbContext _db;
        /// <summary>
        /// Constructor for the Role repository. 
        /// </summary>
        /// <param name="db"></param>
        public DbRoleRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// This method reads all the roles in the database, and
        /// returns them as a "queryable" instance. 
        /// </summary>
        /// <returns></returns>
        public IQueryable<IdentityRole> ReadAll()
        {
            return _db.Roles;
        }
    }//end class
}//end namespace
