using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Configuration;
using System.IO;


namespace Assignment_5.Controllers
{
    public class CAccountController : Controller
    {
      
        public ViewResult Register()
        {
            return View("Register");
        }


        public ViewResult LogIn()
        {
            return View("LogIn");
        }


        [HttpPost]

        public ActionResult LogInForm(string uname , string pass)
        {
            string user_name = uname;
            string password = pass;

            CAccount temp = CAccount.GetCAccountBy_user_name_and_password(user_name, password);

            if (temp != null)
            {
                if (temp.is_admin == 0)
                {
                    HttpContext.Session.SetInt32("uid", temp.id);
                    return RedirectToAction("Index", "UserDashBoard");
                }
                else
                {
                    ViewBag.Message1 = "Sorry ! Only For Users !";
                    return View("LogIn");
                }
            }
            else
            {
                ViewBag.Message = "UserName or Password Incorrect !";
                return View("LogIn");
            }
        }

        [HttpPost]
        public async Task<IActionResult> RegisterForm(string fname, string uname, string email, string pass, IFormFile PIC)
        {
            string extension = Path.GetExtension(PIC.FileName).ToLower();
            Random random = new Random();
            int num = random.Next();
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == "gif")
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(),"Content/Images" , num + PIC.FileName );
                using (var stream = new FileStream(path, FileMode.Create))
                {
                     await PIC.CopyToAsync(stream);
                }

                CAccount temp = CAccount.GetCAccountBy_user_name_and_password(uname, pass);

                     string pic = num + PIC.FileName;   
                    if(temp != null)
                    {
                        ViewBag.Message = "User Name or Email Already Register !";
                        return View("Register") ; 
                    }
                    else
                    {

                        CAccount.Register_User(fname, uname, email, pass ,  pic);
                        return View("LogIn");
                    }
                
         }
            else
            {
                ViewBag.Message2 = "Only Image Allowed";
                return View("Register");
            }
            
        }

        public IActionResult LogInForm_Admin(string auname ,string apass)
        {

            CAccount temp = CAccount.GetCAccountBy_user_name_and_password(auname, apass);
            if (temp != null)
            {
                if (temp.is_admin == 1)
                {

                    return RedirectToAction("Index" , "AdminCont");
                }
                else
                {
                    ViewBag.Message1 = "Sorry ! Only For Admin !";
                    return View("LogIn");
                }
            }
            else
            {
                ViewBag.Message = "UserName or Password Incorrect !";
                return View("LogIn");
            }

              
        }
    }

    
}
