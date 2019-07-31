using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Nisus.Trade.Configuration;
using Nisus.Trade.Web;

namespace Nisus.Trade.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TradeDbContextFactory : IDesignTimeDbContextFactory<TradeDbContext>
    {
        public TradeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TradeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TradeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TradeConsts.ConnectionStringName));

            return new TradeDbContext(builder.Options);
        }
    }
}