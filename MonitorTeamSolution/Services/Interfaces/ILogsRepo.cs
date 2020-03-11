using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface ILogsRepo
    {
        IQueryable<Logs> ReadAll();
        Logs CreateLog(LogCreateVM log);
        Logs ReadLog(int id);
        void UpdateLog(int id, LogEditVM log);

        void DeleteLogs(int id);

    }
}
