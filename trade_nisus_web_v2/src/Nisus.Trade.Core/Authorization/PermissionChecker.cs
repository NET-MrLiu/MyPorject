using Abp.Authorization;
using Nisus.Trade.Authorization.Roles;
using Nisus.Trade.Authorization.Users;

namespace Nisus.Trade.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
