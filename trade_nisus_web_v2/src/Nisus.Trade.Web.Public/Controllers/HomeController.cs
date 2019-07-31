using Microsoft.AspNetCore.Mvc;
using Nisus.Trade.Web.Controllers;

namespace Nisus.Trade.Web.Public.Controllers
{
    public class HomeController : TradeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}