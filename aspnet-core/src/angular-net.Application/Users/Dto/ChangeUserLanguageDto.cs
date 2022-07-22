using System.ComponentModel.DataAnnotations;

namespace angular-net.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}