using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;

[Route("/user")]
public class UserController : Controller
{

    // NOTE: There is no endpoint for GET /user so you will get a 404 if you try to 
    // go directly there in the browser instead of starting at /user/add

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
