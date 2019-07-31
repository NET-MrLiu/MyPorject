using System.ComponentModel.DataAnnotations;

namespace Nisus.Trade.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
