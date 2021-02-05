using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Configuration;
using System.IO;
using System.Web;

namespace Assignment_5.Controllers
{
    public class AdminDashBoardController : Controller
    {
        public IActionResult Delete(int id)
        {
            int temp = Post.Get_Post_By_User_ID(id);

            while (temp != 0)
            {

                Post.Delete_Post_By_UserID(id);
                temp--;
          
            }
  
            CAccount.Delete_User(id);
            //asas
            return RedirectToAction("Index", "AdminCont");
        }

        public IActionResult Edit(int id)
        {
            return View("Edit" , id);
        }

        [HttpPost]
        public IActionResult EditForm(int id, string name, string uname, string email, string pass)
        {
            CAccount.Update_User_for_Admin(id, name, uname, email, pass );
            return RedirectToAction("Index", "AdminCont");
        }
        public IActionResult AddUser()
        {
            return View("AddUser");
        }
        
        [HttpPost]
        public async Task<IActionResult> AddUserForm(string fname , string uname , string email , string pass , IFormFile PIC)
        {
            string extension = Path.GetExtension(PIC.FileName).ToLower();
            Random random = new Random();
            int num = random.Next();
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == "gif")
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Content/Images", num + PIC.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await PIC.CopyToAsync(stream);
                }

                CAccount temp = CAccount.GetCAccountBy_user_name(uname);

                string pic = num + PIC.FileName;
                if (temp != null)
                {
                    ViewBag.Message = "User Name Already Register !";
                    return View("AddUser");
                }
                else
                {

                    CAccount.Add_User_For_Admin( fname, uname, email, pass , pic);
                    return RedirectToAction("Index", "AdminCont");
                }

            }
            else
            {
                ViewBag.Message2 = "Only Image Allowed";
                return View("AddUser");
            }
        }
    }
}
