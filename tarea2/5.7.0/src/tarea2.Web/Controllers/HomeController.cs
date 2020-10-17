using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace tarea2.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : tarea2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}