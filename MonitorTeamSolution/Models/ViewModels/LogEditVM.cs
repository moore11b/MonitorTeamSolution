using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Models.ViewModels
{
    public class LogEditVM
    {
        public int Id { get; set; }
        public string TimeStamp { get; set; }
        public string UserName { get; set; }
        public string TimeLoggedIn { get; set; }
        public string TimeLoggedOut { get; set; }
        public string NumberOfPageViews { get; set; }
        public string SessionDuration { get; set; }
        public string PageTitle { get; set; }
    }
}
