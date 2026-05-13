using Microsoft.AspNetCore.Mvc;
using PeopleConnect.Domain.Entities;
using PeopleConnect.Infrastructure.Data;
using PeopleConnect.Infrastructure.Migrations;

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
                @TempData["success"] = "The Post has been created Successfuly";
                return RedirectToAction("Index");
            }
            return View(post);
        }
        [HttpGet]
        public IActionResult Edit(int postId)
        {
            Post? post = _db.Posts.FirstOrDefault(u => u.PostId == postId);
            if(post == null)
            {
                return NotFound();
            }
           return View(post);
        }
        [HttpPost]
        public IActionResult Edit(Post post)
        {
            if (ModelState.IsValid && post.PostId > 0)
            {
                _db.Posts.Update(post);
                _db.SaveChanges();
                @TempData["success"] = "The Post has been Updated Successfuly";
                return RedirectToAction("Index");
            }
            return View(post);
        }
        [HttpGet]
        public IActionResult Delete(int postId)
        {
            Post? post = _db.Posts.FirstOrDefault(u => u.PostId == postId);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
        [HttpPost]
        public IActionResult Delete(Post post)
        {
            Post? objform = _db.Posts.FirstOrDefault(u => u.PostId == post.PostId);
            if (objform is not null)
            {
                _db.Posts.Remove(objform);
                _db.SaveChanges();
                @TempData["success"] = "The Post has been deleted Successfuly";
                return RedirectToAction("Index");
            }
            @TempData["error"] = "The Post has not been deleted";

            return View(post);
        }
    }
}
