using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BLL.Test test = new BLL.Test();
            //test.InsertTest();
            //test.UpdateTest();
            //test.DeleteTest();
            test.CommentTest();
            return View();
        }
    }
}