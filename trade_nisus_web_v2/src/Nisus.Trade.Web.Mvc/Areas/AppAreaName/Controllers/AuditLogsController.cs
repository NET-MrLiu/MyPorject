using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using Nisus.Trade.Authorization;
using Nisus.Trade.Web.Controllers;

namespace Nisus.Trade.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : TradeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}