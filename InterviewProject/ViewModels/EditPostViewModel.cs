using System.ComponentModel.DataAnnotations;

namespace InterviewProject.ViewModels
{
    public class EditPostViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public int PostId { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }
    }
}