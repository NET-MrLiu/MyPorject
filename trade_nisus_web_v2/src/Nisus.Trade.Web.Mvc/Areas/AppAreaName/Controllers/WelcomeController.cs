using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nisus.Trade.Web.Controllers;

namespace Nisus.Trade.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : TradeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}