using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Nisus.Trade.Web.Controllers
{
    public class HomeController : TradeControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
