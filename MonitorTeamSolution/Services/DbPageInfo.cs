using MonitorTeamSolution.Data;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services
{
    public class DbPageInfo : IPageInfoRepo
    {
        ApplicationDbContext _db;

        public DbPageInfo(ApplicationDbContext db)
        {
            _db = db;
        }

        public PageInfo CreatePageInfo(PageInfo pI)
        {
            _db.Pages.Add(pI);
            _db.SaveChanges();
            return pI;
        }

        public void DeletePageInfo(int id)
        {
            var pageInfo = _db.Pages.Find(id);
            _db.Pages.Remove(pageInfo);
            _db.SaveChanges();
        }

        public IEnumerable<PageInfo> ReadAllPageInfo()
        {
            return _db.Pages.ToList();
        }

        public PageInfo ReadPageInfo(int id)
        {
            return _db.Pages.FirstOrDefault(pI => pI.Id == id);
        }

        public void UpdatePageInfo(int id, PageInfo pI)
        {
            throw new NotImplementedException();
        }
    }
}
