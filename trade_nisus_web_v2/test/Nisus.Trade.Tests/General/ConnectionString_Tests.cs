using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace Nisus.Trade.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=Trade; Trusted_Connection=True;");
            csb["Database"].ShouldBe("Trade");
        }
    }
}
