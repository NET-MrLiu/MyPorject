using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Nisus.Trade.Web.Views
{
    public abstract class TradeRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TradeRazorPage()
        {
            LocalizationSourceName = TradeConsts.LocalizationSourceName;
        }
    }
}
