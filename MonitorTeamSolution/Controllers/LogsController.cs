using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonitorTeamSolution.Models.ViewModels;
using MonitorTeamSolution.Services.Interfaces;

namespace MonitorTeamSolution.Controllers
{
    public class LogsController : Controller
    {
        private ILogsRepo _logsRepo;
        public LogsController(ILogsRepo repo)
        {
            _logsRepo = repo;
        }

        /// <summary>
        /// If account is admin, show all users and their roles.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            // var user = _pagesRepo.Read(User.Identity.Name);
            /*  if (!user.HasRole("Admin"))
              {
                  return LocalRedirect("/Identity/Account/AccessDenied");
              }*/

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

        }

    }
}