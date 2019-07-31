using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Nisus.Trade.Configuration.Host.Dto;
using Nisus.Trade.Editions.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}