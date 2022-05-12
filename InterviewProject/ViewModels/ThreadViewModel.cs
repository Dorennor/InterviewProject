using InterviewProject.Models;
using System.Collections.Generic;

namespace InterviewProject.ViewModels
{
    public class ThreadViewModel
    {
        public bool ConfirmedEmail { get; set; }
        public CreatePostViewModel ViewModel { get; set; }
        public Topic Topic { get; set; }
        public List<Post> Posts { get; set; }

        public ThreadViewModel(Topic topic, List<Post> posts, bool confirmedEmail)
        {
            Topic = topic;
            Posts = posts;
            ConfirmedEmail = confirmedEmail;
        }

        public ThreadViewModel()
        {
            Topic = default;
            Posts = default;
            ViewModel = default;
            ConfirmedEmail = default;
        }
    }
}