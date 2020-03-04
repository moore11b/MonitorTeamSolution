
using MonitorTeamSolution.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface ILogsRepo
    {
        Logs CreateLogs(Logs logs);
        Logs ReadLogs(int id);
        IEnumerable<Logs> ReadAllLogs();
        void UpdateLogs(int id, Logs log);
    }
}
