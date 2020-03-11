using MonitorTeamSolution.Data;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Models.ViewModels;
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
            return _db.Logs;
        }

        public Logs CreateLog(LogCreateVM log)
        {
            Logs newLog = new Logs();
            if (log != null)
            {
                newLog.NumberOfPageViews = log.NumberOfPageViews;
                newLog.PageTitle = log.PageTitle;
                newLog.SessionDuration = log.SessionDuration;
                newLog.TimeLoggedIn = log.TimeLoggedIn;
                newLog.TimeLoggedOut = log.TimeLoggedOut;
                newLog.TimeStamp = log.TimeStamp;
            }
            _db.Logs.Add(newLog);
            _db.SaveChanges();
            return newLog;
        }
        public Logs ReadLog(int id)
        {
            return _db.Logs.FirstOrDefault(l => l.Id == id);
        }


        public void UpdateLog(int id, LogEditVM log )
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