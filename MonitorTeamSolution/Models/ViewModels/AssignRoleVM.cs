using System.Collections.Generic;

namespace MonitorTeamSolution.Models.ViewModels
{
    public class AssignRoleVM
    {
        public ICollection<string> UserNames { get; set; }
        public ICollection<string> RoleNames { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
