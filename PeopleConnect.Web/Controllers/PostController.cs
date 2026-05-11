using Microsoft.AspNetCore.Mvc;
using PeopleConnect.Domain.Entities;
using PeopleConnect.Infrastructure.Data;

namespace PeopleConnect.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PostController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var post = _db.Posts.ToList();

            return View(post);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                _db.Posts.Add(post);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }
        [HttpGet]
        public IActionResult Edit(int PostId)
        {
            
            return View();
        }
    }
}
