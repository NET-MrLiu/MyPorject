using System.Collections.Generic;
using Nisus.Trade.Authorization.Permissions.Dto;

namespace Nisus.Trade.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}