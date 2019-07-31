using Abp.Notifications;
using Nisus.Trade.Dto;

namespace Nisus.Trade.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}