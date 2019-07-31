using Abp.Domain.Services;

namespace Nisus.Trade
{
    public abstract class TradeDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TradeDomainServiceBase()
        {
            LocalizationSourceName = TradeConsts.LocalizationSourceName;
        }
    }
}
