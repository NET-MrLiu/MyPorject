using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Nisus.Trade.Editions.Dto;

namespace Nisus.Trade.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}