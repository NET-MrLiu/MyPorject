using Nisus.Trade.Authorization.Accounts.Dto;

namespace Nisus.Trade.Web.Models.Account
{
    public class EmailConfirmationViewModel : ActivateEmailInput
    {
        /// <summary>
        /// Tenant id.
        /// </summary>
        public int? TenantId { get; set; }
    }
}