using System.Diagnostics;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        static int reloadCount = 0;

        public ActionResult Index()
        {
            if (reloadCount > 100)
            {
                Debugger.Break();
            }
            ViewBag.Title = $"Loaded {++reloadCount} times";
            return View();
        }

        public ActionResult RichEditPartial()
        {
            //DevExpress.Web.Office.Internal.WorkSessionAdminTools.CloseWorkSessionOlderThen(1);


            return PartialView("_RichEditPartial");
        }
    }
}