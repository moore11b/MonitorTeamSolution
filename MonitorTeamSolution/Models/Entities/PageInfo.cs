using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MonitorTeamSolution.Models.Entities
{
    public class PageInfo
    {
        public int Id { get; set; }
        public string TimeStamp { get; set; }
        public string PageTitle { get; set; }
        public string UserName { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Logs> LogList { get; set; }
    }
}