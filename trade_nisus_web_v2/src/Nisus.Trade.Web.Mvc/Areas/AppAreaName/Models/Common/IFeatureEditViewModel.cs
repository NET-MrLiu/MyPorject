using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Nisus.Trade.Editions.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}