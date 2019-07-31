using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Nisus.Trade.EntityFrameworkCore
{
    public static class TradeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TradeDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TradeDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}