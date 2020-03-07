using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorTeamSolution.Models.ViewModels;
using MonitorTeamSolution.Services.Interfaces;

namespace MonitorTeamSolution.Controllers
{
    public class PagesController : Controller
    {
        private IPagesRepo _pagesRepo;
        public PagesController(IPagesRepo repo)
        {
            _pagesRepo = repo;
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

            var pages = _pagesRepo.ReadAll();
            var pageList = pages
               .Select(u => new PageListVM
               {
                   Id = u.Id,
                   TimeStamp= u.TimeStamp,
                   PageTitle = u.PageTitle,
                   UserName = u.UserName
               });
            return View(pageList);

        }



    }
}