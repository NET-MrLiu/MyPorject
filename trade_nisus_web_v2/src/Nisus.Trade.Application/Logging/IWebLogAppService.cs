using Abp.Application.Services;
using Nisus.Trade.Dto;
using Nisus.Trade.Logging.Dto;

namespace Nisus.Trade.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
