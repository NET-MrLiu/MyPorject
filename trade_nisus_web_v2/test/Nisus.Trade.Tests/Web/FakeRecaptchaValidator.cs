using System.Threading.Tasks;
using Nisus.Trade.Security.Recaptcha;

namespace Nisus.Trade.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
