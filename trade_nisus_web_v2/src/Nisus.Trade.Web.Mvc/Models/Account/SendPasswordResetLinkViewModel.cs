using System.ComponentModel.DataAnnotations;

namespace Nisus.Trade.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}