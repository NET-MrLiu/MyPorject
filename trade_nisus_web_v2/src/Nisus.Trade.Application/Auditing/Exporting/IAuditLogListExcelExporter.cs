using System.Collections.Generic;
using Nisus.Trade.Auditing.Dto;
using Nisus.Trade.Dto;

namespace Nisus.Trade.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
