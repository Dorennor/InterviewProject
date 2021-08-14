using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public int UserCreatorId { get; set; }
        public string Title { get; set; }
        public int NumberOfPosts { get; set; }
    }
}
