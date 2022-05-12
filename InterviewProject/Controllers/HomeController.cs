using InterviewProject.Models;
using InterviewProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (_context.Topics.Any())
            {
                return View(_context.Topics.ToList());
            }

            return RedirectToAction("Error", "Account");
        }

        [HttpGet]
        public IActionResult CreateTopic()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTopic(CreateTopicViewModel model)
        {
            await _context.Topics.AddAsync(
                new Topic
                {
                    Description = model.Description,
                    Title = model.Title,
                    LastPostDateTime = DateTime.Now,
                    UserName = model.CreatorName,
                    NumberOfPosts = 1
                });
            await _context.SaveChangesAsync();
            var userTopics = (from t in _context.Topics where t.UserName.Equals(User.Identity.Name) select t).ToList();
            var newTopicId = (from p in userTopics where p.Title.Equals(model.Title) select p).First().Id;

            await _context.Posts.AddAsync(
                new Post
                {
                    PostDateTime = DateTime.Now,
                    Text = model.Description,
                    TopicId = newTopicId,
                    UserName = model.CreatorName
                }
            );

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult DeleteTopic(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        public async Task<IActionResult> ConfirmDeleteTopic(int id)
        {
            _context.Topics.RemoveRange(_context.Topics.Where(t => t.Id.Equals(id)));
            _context.Posts.RemoveRange(_context.Posts.Where(p => p.TopicId.Equals(id)));
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTopic(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditTopic(EditTopicViewModel model)
        {
            var userTopics = _context.Topics.Where(t => t.UserName.Equals(User.Identity.Name)).ToList();
            var topic = userTopics.Where(t => t.Id.Equals(model.TopicId)).ToList().FirstOrDefault();

            if (topic == null) return RedirectToPage("Error");
            if (model.Title != null) topic.Title = model.Title;
            if (model.Description != null) topic.Description = model.Description;
            _context.Topics.Update(topic);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}