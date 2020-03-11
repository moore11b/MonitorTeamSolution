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
              if (user.HasRole("Admin"))
              {
                  return View("AdminView");
              }

            var pages = _logsRepo.ReadAll();
            var pageList = pages
               .Select(u => new LogListVM
               {
                   Id = u.Id,
                   TimeStamp = u.TimeStamp,
                   TimeLoggedOut = u.TimeLoggedOut,
                   TimeLoggedIn = u.TimeLoggedIn,
                   NumberOfPageViews = u.NumberOfPageViews,
                   SessionDuration = u.SessionDuration,
                   PageTitle = u.PageTitle,
                   UserName = u.UserName
               });
            return View(pageList);

        }//end index
        public IActionResult AdminView()
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
                   TimeLoggedOut = u.TimeLoggedOut,
                   TimeLoggedIn = u.TimeLoggedIn,
                   NumberOfPageViews = u.NumberOfPageViews,
                   SessionDuration = u.SessionDuration,
                   PageTitle = u.PageTitle,
                   UserName = u.UserName
               });
            return View(pageList);

        }//end index
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var user = _userRepo.Read(User.Identity.Name);
            if (!user.HasRole("Admin"))
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
            
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(LogCreateVM logVM)
        {
            Logs newLog = new Logs
            {
                Id = logVM.Id,
                NumberOfPageViews = logVM.NumberOfPageViews,
                PageTitle = logVM.PageTitle,
                SessionDuration = logVM.SessionDuration,
                TimeLoggedIn = logVM.TimeLoggedIn,
                TimeLoggedOut = logVM.TimeLoggedOut,
                TimeStamp = logVM.TimeStamp,
                UserName = logVM.UserName
            };

            _logsRepo.CreateLog(newLog);
            return RedirectToAction("Index", "Logs");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var deleteLog = _logsRepo.ReadLog(id);
            if (deleteLog == null)
            {
                return NotFound("Could not find Grocery List.");
            }
            
            var deleteLogVM = new LogDeleteVM
            {
               Id = deleteLog.Id,
               NumberOfPageViews = deleteLog.NumberOfPageViews,
               PageTitle = deleteLog.PageTitle,
               SessionDuration = deleteLog.SessionDuration,
               TimeLoggedIn = deleteLog.TimeLoggedIn,
               TimeLoggedOut = deleteLog.TimeLoggedOut,
               TimeStamp = deleteLog.TimeStamp,
               UserName = deleteLog.UserName
            };
            return View(deleteLogVM);
        }

        /// <summary>
        /// Deletes a specified grocery list. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _logsRepo.DeleteLogs(id);
            return RedirectToAction("Index", "Home");
        }
    }
}