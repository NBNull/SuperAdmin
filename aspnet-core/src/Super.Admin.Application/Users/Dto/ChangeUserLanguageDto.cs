using System.ComponentModel.DataAnnotations;

namespace Super.Admin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}