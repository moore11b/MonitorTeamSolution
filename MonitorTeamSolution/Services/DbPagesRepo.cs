using Microsoft.AspNetCore.Identity;
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
    public class DbPagesRepo : IPagesRepo
    {
        private readonly ApplicationDbContext _db;
        public DbPagesRepo(ApplicationDbContext db)
        {
            _db = db;
        }



        public IQueryable<PageInfo> ReadAll()
        {
            ICollection<PageInfo> appUsers = new List<PageInfo>();
            foreach (var page in _db.Pages)
            {
                appUsers.Add(page);
            }
            return appUsers.AsQueryable();
        }



        public PageInfo Create(PageCreateVM page)
        { 
            PageInfo newPage = new PageInfo();
            if(page != null)
            {
                newPage.ApplicationUsers = page.ApplicationUsers;
                newPage.Id = page.Id;
                newPage.LogList = page.LogList;
                newPage.PageTitle = page.PageTitle;
                newPage.TimeStamp = page.UserName;
            }
            _db.Pages.Add(newPage);
            _db.SaveChanges();
            return newPage;
        }
        public PageInfo Read(int id)
        {
            return _db.Pages.FirstOrDefault(l => l.Id == id);
        }


        public void Update(int id, PageEditVM page)
        {
            var oldPage = Read(id);
            if (oldPage != null)
            {
                oldPage.Id = page.Id;
                oldPage.TimeStamp = page.TimeStamp;
                oldPage.PageTitle = page.PageTitle;
                oldPage.UserName = page.UserName;
                _db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var page = _db.Pages.Find(id);
            _db.Pages.Remove(page);
            _db.SaveChanges();
        }
    }//end class
}//end namespace
