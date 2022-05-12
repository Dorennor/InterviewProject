using System.ComponentModel.DataAnnotations;

namespace InterviewProject.ViewModels
{
    public class CreateTopicViewModel
    {
        [Required]
        [Display(Name = "CreatorName")]
        public string CreatorName { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}