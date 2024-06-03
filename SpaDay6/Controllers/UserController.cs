using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;

[Route("/user")]
public class UserController : Controller
{

    [HttpGet("add")]
    public IActionResult RenderAddUserForm()
    {
        return View("Add");
    }

    [HttpPost("add")]
    public IActionResult ProcessAddUserForm(User newUser, string verify)
    {
        ViewBag.User = newUser;
        if (newUser.Password != verify)
        {
            ViewBag.Error = "Passwords must match.";
            return View("Add");
        }
        return View("Index");
    }
}
