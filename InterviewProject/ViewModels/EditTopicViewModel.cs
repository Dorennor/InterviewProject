using System.ComponentModel.DataAnnotations;

namespace InterviewProject.ViewModels
{
    public class EditTopicViewModel
    {
        [Required]
        [Display(Name = "TopicId")]
        public int TopicId { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}