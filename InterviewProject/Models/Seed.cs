using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public static class Seed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Topics.Any())
            {
                context.AddRange(
                    new Topic
                    {

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
