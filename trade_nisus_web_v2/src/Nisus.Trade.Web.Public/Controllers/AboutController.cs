using Microsoft.AspNetCore.Mvc;
using Nisus.Trade.Web.Controllers;

namespace Nisus.Trade.Web.Public.Controllers
{
    public class AboutController : TradeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}