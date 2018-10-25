using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Entities.ViewModels;
using Template.DB.Repositories;
using Template.DB.Models;

namespace Template.Web.Controllers
{
    public class TemplateController : Controller
    {
        // GET: Template
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Register(UserDetailsViewModel userDetails)
        {
            //userDetails.UserID;
            //userDetails.Password;
            LoginRepositoryManager loginManager = new LoginRepositoryManager();
                UserDetails details = new UserDetails();
            details.UserName = userDetails.UserName;
            details.Password = userDetails.Password;

            loginManager.RegisterUser(details);
        }
    }
}