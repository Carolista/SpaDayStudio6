using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;

[Route("/user")]
public class UserController : Controller
{

    // Endpoint: GET /user/add
    [HttpGet("add")]
    public IActionResult RenderAddUserForm()
    {
        return View("Add");
    }

    // Endpoint: POST /user
    [HttpPost]
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
