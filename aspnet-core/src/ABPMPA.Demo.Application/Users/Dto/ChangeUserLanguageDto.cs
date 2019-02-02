using System.ComponentModel.DataAnnotations;

namespace ABPMPA.Demo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}