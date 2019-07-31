using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nisus.Trade.Web.Areas.AppAreaName.Models.Layout;
using Nisus.Trade.Web.Session;
using Nisus.Trade.Web.Views;

namespace Nisus.Trade.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : TradeViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
