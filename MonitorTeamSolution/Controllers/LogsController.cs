using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Models.ViewModels;
using MonitorTeamSolution.Services.Interfaces;

namespace MonitorTeamSolution.Controllers
{
    public class LogsController : Controller
    {
        private ILogsRepo _logsRepo;
        private IUserRepo _userRepo;
        private IRoleRepo _roleRepo;
        public LogsController(ILogsRepo repo, 
                             IUserRepo userRepo,
                             IRoleRepo roleRepo)
        {
            _logsRepo = repo;
            _userRepo = userRepo;
            _roleRepo = roleRepo;
        }

        /// <summary>
        /// If account is admin, show all users and their roles.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
             var user = _userRepo.Read(User.Identity.Name);
              if (!user.HasRole("Admin"))
              {
                  return LocalRedirect("/Identity/Account/AccessDenied");
              }

            var pages = _logsRepo.ReadAll();
            var pageList = pages
               .Select(u => new LogListVM
               {
                   Id = u.Id,
                   TimeStamp = u.TimeStamp,
                   PageTitle = u.PageTitle,
                   UserName = u.UserName
               });
            return View(pageList);

        }//end index
        [Authorize(Roles = "Admin")]
        public IActionResult Create(int logId)
        {
            var user = _userRepo.Read(User.Identity.Name);
            if (!user.HasRole("Admin"))
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
            
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(LogCreateVM log)
        {
            Logs newLog = new Logs
            {
                Id = log.Id
            };
            _logsRepo.CreateLog(newLog);
            return View();
        }
    }
}