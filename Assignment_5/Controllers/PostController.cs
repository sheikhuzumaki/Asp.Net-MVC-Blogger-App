using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Assignment_5.Controllers;

namespace Assignment_5.Controllers
{
    
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            return View("Create" , id);
        }

        [HttpPost]
        public IActionResult CreateForm(string title , string body , int user_id)
        {

            CAccount user = CAccount.Get_User_By_ID(user_id);
            string name = user.fname;
            string pic = user.pic;
            Post.Create_Post(title, body, user_id, name, pic);
            return RedirectToAction("Index", "UserDashBoard");
        }


        [HttpGet]
        public IActionResult Show(int id)
        {
            int user_id = (int)HttpContext.Session.GetInt32("uid");
            int post_id = id;

            List<Post> posts = Post.Get_Post_By_ID(post_id);

            
            ViewData["posts"] = posts;

            Post temp = Post.Get_Post_By_PostandUser_ID(post_id , user_id);

            if (temp != null)
            {
                ViewBag.Message = "Can Edit";
            }
            
            return View("Show" , post_id);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            int post_id = id;

            Post.Delete_Post(post_id);

            return RedirectToAction("Index", "UserDashBoard");
        }

        public IActionResult Update(int id)
        {
            int post_id = id;
            return View("Update" , post_id);
        }

        [HttpPost]
        public IActionResult UpdateForm(string title , string body , int post_id)
        {

            Post.Update_Post(title, body, post_id);
            return RedirectToAction("Index", "UserDashBoard");
        }
        public IActionResult About(int id)
        {
            return View("About" , id);
        }
        public IActionResult Profile(int id)
        {
            int user_id = id;
            CAccount temp = CAccount.Get_User_By_ID(id);
            ViewBag.pic = temp.pic;
            ViewBag.name = temp.fname;
            return View("Profile" , user_id);
        }

        public IActionResult ProfileForm(string uname , string email , string cpass , string npass , int id)
        {

            CAccount temp = CAccount.GetCAccountBy_user_name_and_password(uname , cpass);
            
           
            if (temp != null)
            {

                CAccount.Update_User(uname, email, npass, id);
                return RedirectToAction("Index", "UserDashBoard");
            }
            else
            {
                ViewBag.Message = "Old Password Not Correct , Please Enter Correcrt Password Else Cant Update";
                return View("Profile" , id);
            }

            
        }
    }
}
