using Abp.AutoMapper;
using Nisus.Trade.Web.Authentication.External;

namespace Nisus.Trade.Web.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
