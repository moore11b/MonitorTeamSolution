using MonitorTeamSolution.Data;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services
{
    public class DbLogsRepo : ILogsRepo
    {
        private readonly ApplicationDbContext _db;
        public DbLogsRepo(ApplicationDbContext db)
        {
            _db = db;
        }



        public IQueryable<Logs> ReadAll()
        {
            ICollection<Logs> logList = new List<Logs>();
            foreach (var log in _db.Logs)
            {
                logList.Add(log);
            }
            return logList.AsQueryable();
        }

    }
}