using System.Web.Mvc;
using Template.Service.Interfaces;
using Template.Service.Implementations;
using Template.Entities.ViewModels;
using Template.DB.Models;
using System.Collections.Generic;

namespace Template.Web.Controllers
{
    public class TemplateController : Controller
    {
        private IUserDetailsService UserdetailService;
        public TemplateController()
        {
            UserdetailService = new UserDetailsService();
        }
        // GET: Template
        public ActionResult Index()
        {
            UserDetailsViewModel viewModel = (UserDetailsViewModel)TempData["ViewData"];
            if (viewModel == null)
            {
                var skillSet = new SkillSet();
                viewModel = new UserDetailsViewModel();
                viewModel.SkillSets = new List<SkillSet>();
                viewModel.SkillSets.Add(skillSet);
                ViewBag.viewModel = viewModel;
            }

            TempData["ViewData"] = viewModel;
            return View(viewModel);
        }

        [HttpPost]
        public void Register(UserDetailsViewModel userDetails)
        {
            UserdetailService.RegisterUser(userDetails);
        }
    }
}