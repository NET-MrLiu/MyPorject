using Nisus.Trade.EntityFrameworkCore;

namespace Nisus.Trade.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly TradeDbContext _context;

        public InitialHostDbBuilder(TradeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
