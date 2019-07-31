using Nisus.Trade.Dto;

namespace Nisus.Trade.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}