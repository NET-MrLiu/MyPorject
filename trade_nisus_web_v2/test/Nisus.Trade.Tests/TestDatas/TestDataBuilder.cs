using Nisus.Trade.EntityFrameworkCore;

namespace Nisus.Trade.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly TradeDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(TradeDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
