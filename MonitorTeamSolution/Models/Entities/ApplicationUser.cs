using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [NotMapped]
        public ICollection<string> Roles { get; set; }

        public bool HasRole(string roleName)
        {
            return Roles.Any(r => r == roleName);
        }//end method
    }//end class
}//end namespace
