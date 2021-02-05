using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;

namespace Assignment_5.Controllers
{
    public class UserDashBoard : Controller
    {
        public ActionResult Index()
        {

            int uid = (int)HttpContext.Session.GetInt32("uid");

            List<Post> posts = Post.Get_All_Post();

            ViewData["posts"] = posts;

            return View("Index" , uid);
        }
    }
}
