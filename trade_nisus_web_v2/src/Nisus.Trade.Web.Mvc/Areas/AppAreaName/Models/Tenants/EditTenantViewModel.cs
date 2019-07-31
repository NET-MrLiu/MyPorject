using System.Collections.Generic;
using Nisus.Trade.Editions.Dto;
using Nisus.Trade.MultiTenancy.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}