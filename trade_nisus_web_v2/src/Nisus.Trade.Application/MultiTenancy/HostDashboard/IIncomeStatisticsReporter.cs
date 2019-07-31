using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nisus.Trade.MultiTenancy.HostDashboard.Dto;

namespace Nisus.Trade.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}