using System.Threading.Tasks;

namespace Nisus.Trade.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}