using Abp.AspNetCore.Mvc.ViewComponents;

namespace Nisus.Trade.Web.Public.Views
{
    public abstract class TradeViewComponent : AbpViewComponent
    {
        protected TradeViewComponent()
        {
            LocalizationSourceName = TradeConsts.LocalizationSourceName;
        }
    }
}