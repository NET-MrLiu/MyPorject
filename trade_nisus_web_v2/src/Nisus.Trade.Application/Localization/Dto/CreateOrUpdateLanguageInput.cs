using System.ComponentModel.DataAnnotations;

namespace Nisus.Trade.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}