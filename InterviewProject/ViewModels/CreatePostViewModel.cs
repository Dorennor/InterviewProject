using System.ComponentModel.DataAnnotations;

namespace InterviewProject.ViewModels
{
    public class CreatePostViewModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "TopicId")]
        public int TopicId { get; set; }

        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }

        public CreatePostViewModel()
        {
            UserName = default;
            TopicId = default;
            Text = default;
        }
    }
}