using Blog_Project.BLL;
using Blog_Project.Entities;
using Blog_Project.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //if (TempData["mm"] != null)
            //{
            //    return View(TempData["mm"] as List<Blog>);
            //}

            BlogManager bm = new BlogManager();

            //return View(bm.GetAllBlogQueryable().OrderByDescending(x => x.ModifiedOn).ToList());
            return View(bm.GetAllBlog().OrderByDescending(x=> x.ModifiedOn).ToList()); // C# tarafında order by çalışır.
        }

        public ActionResult ByCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CategoryManager cm = new CategoryManager();
            Category cat = cm.GetCategoryById(id.Value);

            if (cat == null)
            {
                return HttpNotFound();
                //return RedirectToAction("Index","Home");
            }           
            return View("Index",cat.Blogs.OrderByDescending(x => x.ModifiedOn).ToList());
        }

        public ActionResult MostLiked()
        {
            BlogManager bm = new BlogManager();
            return View("Index", bm.GetAllBlog().OrderByDescending(x => x.LikeCount).ToList());
        }

        public ActionResult About()
        {         
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}