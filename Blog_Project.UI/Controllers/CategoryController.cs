using Blog_Project.BLL;
using Blog_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project.UI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //public ActionResult Select(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    CategoryManager cm = new CategoryManager();
        //    Category cat = cm.GetCategoryById(id.Value);

        //    if (cat == null)
        //    {
        //        return HttpNotFound();
        //        //return RedirectToAction("Index","Home");
        //    }
        //    TempData["mm"] = cat.Blogs;
        //    return RedirectToAction("Index", "Home");
        //}
    }
}