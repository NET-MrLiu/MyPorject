using System.Collections.Generic;
using Nisus.Trade.Authorization.Permissions.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}