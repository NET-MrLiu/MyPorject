using System.ComponentModel.DataAnnotations;
using Nisus.Trade.Authorization.Users;

namespace Nisus.Trade.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}