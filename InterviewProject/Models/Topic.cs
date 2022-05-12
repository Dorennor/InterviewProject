using System;

namespace InterviewProject.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastPostDateTime { get; set; }
        public int NumberOfPosts { get; set; }
    }
}