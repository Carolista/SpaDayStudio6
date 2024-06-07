using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/user/add")]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new();
            return View(addUserViewModel);
        }

        [HttpPost("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {   
            if (ModelState.IsValid)
            {
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new()
                    {
                        Username = addUserViewModel.Username,
                        Email = addUserViewModel.Email,
                        Password = addUserViewModel.Password
                    };
                    ViewBag.user = newUser;
                    return View("Index", newUser);
                }
                else
                {   
                    ViewBag.error = "Passwords do not match! Try again!";
                }
            } 
            return View("Add", addUserViewModel);
        }
    }
}

