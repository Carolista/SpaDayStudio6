using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;

[Route("/user")]
public class UserController : Controller
{
    [HttpGet]
    public IActionResult RenderUserWelcomePage()
    {
        return View("Index");
    }

    [HttpGet("add")]
    public IActionResult RenderAddUserForm()
    {
        return View("Add");
    }

    [HttpPost("add")]
    public IActionResult ProcessAddUserForm(string username, string email, string password, string verify)
    {
        if (password != verify)
        {
            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.Error = "Passwords must match.";
            return View("Add");
        }
        ViewBag.User = new User(username, email, password);
        return View("Index");
    }
}
