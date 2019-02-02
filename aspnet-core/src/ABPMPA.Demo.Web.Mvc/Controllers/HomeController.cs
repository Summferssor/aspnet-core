using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPMPA.Demo.Controllers;

namespace ABPMPA.Demo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
