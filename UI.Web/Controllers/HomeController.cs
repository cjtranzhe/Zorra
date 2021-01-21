using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public const string DotCsHtml = ".cshtml";

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult LoadMain(string component)
        {
            return PartialView($"~/Views/Home/{component}/PartialMain{DotCsHtml}");
        }

        public PartialViewResult LoadPartial(string component, string partial)
        {
            return PartialView($"~/Views/{component}/{partial}{DotCsHtml}");
        }
    }
}