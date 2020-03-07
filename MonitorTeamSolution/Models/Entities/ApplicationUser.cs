using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Models.Entities
{
    public class ApplicationUser 
    {
        public int Id { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<IdentityRole> Roles { get; set; }

        public ApplicationUser()
        {
            Roles = new List<IdentityRole>();
        }

        public bool HasRole(string roleName)
        {
            return Roles.FirstOrDefault(r => r.Name == roleName) != null;
        }
    }//end class
}//end namespace
