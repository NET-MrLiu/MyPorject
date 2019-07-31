using Abp.AutoMapper;
using Nisus.Trade.MultiTenancy;
using Nisus.Trade.MultiTenancy.Dto;
using Nisus.Trade.Web.Areas.AppAreaName.Models.Common;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}