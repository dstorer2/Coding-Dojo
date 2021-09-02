using System.ComponentModel.DataAnnotations;

namespace DojoSurvey
{
    public class SurveyResult
    {
        [Required]
        [MinLength(2)]
        public string Name {get; set; }
        public string Location {get; set; }
        public string FavLang {get; set; }
        [Display(Name = "Comment (optional):")]
        [MinLength(20)]
        public string? Comment {get; set; }
    }
}