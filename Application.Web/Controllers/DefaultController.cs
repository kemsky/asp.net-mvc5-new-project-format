using System.Web.Mvc;

namespace Application.Web.Controllers
{
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}