using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Nisus.Trade.Authorization.Permissions.Dto;

namespace Nisus.Trade.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
