using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class OffreController : Controller
    {
        public ActionResult Index(int? idEmploi)
        {
            ViewBag.IDEmploi = idEmploi;
            return View();
        }
    }
}