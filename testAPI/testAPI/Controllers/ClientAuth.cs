using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using testAPI.IServices;
using testAPI.Models;
using RandomString4Net;
using Microsoft.AspNetCore.Http.HttpResults;

namespace testAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientAuth : ControllerBase
    {
        public readonly ExoDbContext dbContext;
        public readonly UserManager<AppUser> userManager;
        public readonly RoleManager<IdentityRole> roleManager;
        public readonly SignInManager<AppUser> signInManager;
        public ClientAuth(ExoDbContext _dbContext, UserManager<AppUser> _userManager, RoleManager<IdentityRole> _roleManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = _userManager;
            this.dbContext = _dbContext;
            this.roleManager = _roleManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]string email, [FromBody]string password)
        { 
            var user1 = new AppUser { Email=email, UserName = email };
            string randomString = RandomString.GetString(Types.ALPHABET_LOWERCASE, 15);
            var result = await userManager.CreateAsync(user1, password);
            var c1 = new Client { FirstName = "Claudux", LastName = randomString, AppUser = user1, AppUserId = user1.Id };
            await dbContext.AddAsync(c1);

            await dbContext.SaveChangesAsync();
            return Ok(result);
        }
        [HttpPost("registere")]
        public async Task<IActionResult> Register([FromBody]AppUser model,string password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (password != model.)
            {
                return BadRequest("Confirm password does not match.");
            }

            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // Vous pourriez vouloir envoyer un email de confirmation ici ou logger l'utilisateur
                return Ok(new { Success = true, Message = "Registration successful" });
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return BadRequest(ModelState);
        }
    }

}
}
