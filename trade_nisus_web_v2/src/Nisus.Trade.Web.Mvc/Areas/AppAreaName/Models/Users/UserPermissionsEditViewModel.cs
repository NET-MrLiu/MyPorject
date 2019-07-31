using Abp.AutoMapper;
using Nisus.Trade.Authorization.Users;
using Nisus.Trade.Authorization.Users.Dto;
using Nisus.Trade.Web.Areas.AppAreaName.Models.Common;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}