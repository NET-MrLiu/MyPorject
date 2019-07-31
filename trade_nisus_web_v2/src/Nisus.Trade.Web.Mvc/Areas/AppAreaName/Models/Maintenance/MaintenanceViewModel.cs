using System.Collections.Generic;
using Nisus.Trade.Caching.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}