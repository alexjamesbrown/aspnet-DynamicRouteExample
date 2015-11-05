using System.Web.Mvc;

namespace DynamicRouteExample.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index(string category, string location)
        {
            //normally we would retrieve the category from the database
            //and the location

            ViewBag.Category = category;
            ViewBag.Location = location;

            return View();
        }
    }
}