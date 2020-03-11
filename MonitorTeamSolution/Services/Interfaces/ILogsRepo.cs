using MonitorTeamSolution.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface ILogsRepo
    {
        IQueryable<Logs> ReadAll();
        Logs CreateLog(Logs log);
        Logs ReadLog(int id);
        void UpdateLog(int id, Logs log);

        void DeleteLogs(int id);

    }
}
