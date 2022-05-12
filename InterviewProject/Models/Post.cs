using System;

namespace InterviewProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public string Text { get; set; }
        public DateTime PostDateTime { get; set; }
    }
}