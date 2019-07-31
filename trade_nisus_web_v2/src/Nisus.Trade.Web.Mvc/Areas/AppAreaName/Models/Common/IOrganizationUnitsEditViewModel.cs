using System.Collections.Generic;
using Nisus.Trade.Organizations.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}