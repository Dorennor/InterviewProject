using InterviewProject.Models;
using InterviewProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Controllers
{
    public class TopicsController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public TopicsController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            Debug.WriteLine(id);
            var topic = (from t in _context.Topics where t.Id.Equals(id) select t).FirstOrDefault();
            var posts = (from p in _context.Posts where p.TopicId.Equals(id) orderby p.PostDateTime descending select p).ToList();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ThreadViewModel thread = new ThreadViewModel(topic, posts, user.EmailConfirmed);
            return View(thread);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ThreadViewModel model)
        {
            Post post = new Post
            {
                Text = model.ViewModel.Text,
                PostDateTime = DateTime.Now,
                UserName = model.ViewModel.UserName,
                TopicId = model.ViewModel.TopicId
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPost(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(EditPostViewModel model)
        {
            var post = _context.Posts.Where(t => t.Id.Equals(model.PostId)).ToList().FirstOrDefault();

            if (post == null) return RedirectToPage("Error");
            if (model.Text != null) post.Text = model.Text;

            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult DeletePost(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        public async Task<IActionResult> ConfirmDeletePost(int id)
        {
            _context.Posts.RemoveRange(_context.Posts.Where(p => p.Id.Equals(id)));
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}