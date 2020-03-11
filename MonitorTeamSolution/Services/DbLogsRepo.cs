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

        public Logs CreateLog(Logs log)
        {
            _db.Logs.Add(log);
            _db.SaveChanges();
            return log;
        }
        public Logs ReadLog(int id)
        {
            return _db.Logs.FirstOrDefault(l => l.Id == id);
        }


        public void UpdateLog(int id, Logs log)
        {
            var oldLog = ReadLog(id);
            if(oldLog != null)
            {
                oldLog.NumberOfPageViews = log.NumberOfPageViews;
                oldLog.PageTitle = log.PageTitle;
                oldLog.SessionDuration = log.SessionDuration;
                oldLog.TimeLoggedIn = log.TimeLoggedIn;
                oldLog.TimeLoggedOut = log.TimeLoggedOut;
                oldLog.TimeStamp = log.TimeStamp;
                _db.SaveChanges();
            }
        }

        public void DeleteLogs(int id)
        {
            var log = _db.Logs.Find(id);
            _db.Logs.Remove(log);
            _db.SaveChanges();
        }
    }
}