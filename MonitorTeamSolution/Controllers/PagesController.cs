using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorTeamSolution.Models.ViewModels;
using MonitorTeamSolution.Services.Interfaces;

namespace MonitorTeamSolution.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        private IPagesRepo _pagesRepo;
        private IUserRepo _userRepo;
        private IRoleRepo _roleRepo;
        public PagesController(IPagesRepo repo,
                             IUserRepo userRepo,
                             IRoleRepo roleRepo)
        {
            _pagesRepo = repo;
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
             

            var pages = _pagesRepo.ReadAll();
            var pageList = pages
               .Select(u => new PageListVM
               {
                   Id = u.Id,
                   TimeStamp= u.TimeStamp,
                   PageTitle = u.PageTitle,
                   UserName = u.UserName,
                   ApplicationUsers = u.ApplicationUsers,
                   LogList = u.LogList
               });
            return View(pageList);

        } //end Index method

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var user = _userRepo.Read(User.Identity.Name);
            if (!user.HasRole("Admin"))
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }

            return View();
        }//end GET create

        [Authorize(Roles = "Admin")]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(PageCreateVM pageVM)
        {
            PageCreateVM newPage = new PageCreateVM
            {
                Id = pageVM.Id,
                ApplicationUsers = pageVM.ApplicationUsers,
                LogList = pageVM.LogList,
                PageTitle = pageVM.PageTitle,
                TimeStamp = pageVM.TimeStamp,
                UserName = pageVM.UserName
            };
            _pagesRepo.Create(newPage);
            return RedirectToAction("Index", "Pages");
        }//end Create Pages
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var page = _pagesRepo.Read(id);
            if (page == null)
            {
                return NotFound("Could not find Project.");
            }

            var pageVM = new PageEditVM
            {
                Id = page.Id,
                PageTitle = page.PageTitle,
                TimeStamp = page.TimeStamp,
                UserName = page.UserName,
                ApplicationUsers = page.ApplicationUsers,
                LogList = page.LogList
            };
            return View(pageVM);
        }//end get edit
        [Authorize(Roles = "Admin")]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(PageEditVM pageEditVm)
        {
            if (ModelState.IsValid)
            {
                _pagesRepo.Update(pageEditVm.Id, pageEditVm);
            }

            return RedirectToAction("Index", "Pages");
        }//end edit POST
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var deletePage = _pagesRepo.Read(id);
            if (deletePage == null)
            {
                return NotFound("Could not find Page .");
            }

            var deletePageVM = new PageDeleteVM
            {
                Id = deletePage.Id,
                PageTitle = deletePage.PageTitle,
                TimeStamp = deletePage.TimeStamp,
                UserName = deletePage.UserName,
                ApplicationUsers = deletePage.ApplicationUsers,
                LogList = deletePage.LogList
            };
            return View(deletePageVM);
        }//Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _pagesRepo.Delete(id);
            return RedirectToAction("Index", "Pages");
        }

    }
}