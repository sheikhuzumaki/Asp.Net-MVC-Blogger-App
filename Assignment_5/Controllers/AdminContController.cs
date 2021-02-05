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
    public class AdminContController : Controller
    {
        public IActionResult Index()
        {

            List<CAccount> users = CAccount.GetAllUsers();

            ViewData["users"] = users;


            return View("Index");
        }

       
    }
}
