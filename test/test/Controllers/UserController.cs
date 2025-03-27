using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    // GET api/user
    [HttpGet(Name = "UserGet")]
    [Authorize]
    public IActionResult GetUser()
    {
        WindowsIdentity identity = (WindowsIdentity)User.Identity;

        // Get the username (DOMAIN\username)
        var username = identity.Name;
        bool valid = false;
      
        // You can now use the username for further logic
        return Ok(new { UserName = username, IsAuth = User.Identity.IsAuthenticated});
    }

   
}
