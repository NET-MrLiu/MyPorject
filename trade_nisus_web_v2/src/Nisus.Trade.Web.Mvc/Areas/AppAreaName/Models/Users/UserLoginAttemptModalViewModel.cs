using System.Collections.Generic;
using Nisus.Trade.Authorization.Users.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}