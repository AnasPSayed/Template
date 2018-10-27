using System.Web.Mvc;
using Template.Service.Interfaces;
using Template.Service.Implementations;
using Template.Entities.ViewModels;

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
            return View();
        }

        [HttpPost]
        public void Register(UserDetailsViewModel userDetails)
        {
            UserdetailService.RegisterUser(userDetails);
        }
    }
}