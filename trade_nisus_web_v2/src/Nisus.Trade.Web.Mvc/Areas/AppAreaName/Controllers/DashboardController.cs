using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nisus.Trade.Authorization;
using Nisus.Trade.Web.Controllers;

namespace Nisus.Trade.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : TradeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}