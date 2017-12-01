using System.ComponentModel.DataAnnotations;

namespace StudyPro.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}