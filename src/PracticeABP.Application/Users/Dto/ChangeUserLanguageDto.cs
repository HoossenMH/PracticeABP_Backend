using System.ComponentModel.DataAnnotations;

namespace PracticeABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}