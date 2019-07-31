using System.Collections.Generic;
using Nisus.Trade.Authorization.Users.Dto;
using Nisus.Trade.Dto;

namespace Nisus.Trade.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}