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
        [Authorize(Roles = "Admin")]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(LogCreateVM logVM)
        {
            LogCreateVM newLog = new LogCreateVM
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

        public IActionResult Edit(int id)
        {
            var log = _logsRepo.ReadLog(id);
            if (log == null)
            {
                return NotFound("Could not find Log.");
            }

            var logVM = new LogEditVM
            {
                Id = log.Id,
                NumberOfPageViews = log.NumberOfPageViews,
                PageTitle = log.PageTitle,
                SessionDuration = log.SessionDuration,
                TimeLoggedIn = log.TimeLoggedIn,
                TimeLoggedOut = log.TimeLoggedOut,
                TimeStamp = log.TimeStamp,
                UserName = log.UserName
            };
            return View(logVM);
        }

        /// <summary>
        /// Provides conventional routing for the POST Project/edit/<PersonID>/<ID>.
        /// </summary>
        /// <param name="PersonId"></param>
        /// <param name="id"></param>
        /// <param name="ProjectVM"></param>
        /// <returns>A redirect to Person/details/<PersonID> if the update is successful. Otherwise, return a view with a Project edit view model.</returns>
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(LogEditVM logEditVm)
        {
            if (ModelState.IsValid)
            {
                _logsRepo.UpdateLog(logEditVm.Id, logEditVm);
            }

            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var deleteLog = _logsRepo.ReadLog(id);
            if (deleteLog == null)
            {
                return NotFound("Could not find log.");
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