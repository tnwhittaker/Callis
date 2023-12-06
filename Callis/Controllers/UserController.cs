using Callis.Data;
using Callis.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Callis.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext dbContext) {
            _db = dbContext;
        
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(User obj)
        {
            obj.AccountTypeId = 2;
            obj.TaskNo = 0;
            var passwordHasher = new PasswordHasher<User>();
            obj.PasswordHash = passwordHasher.HashPassword(obj, obj.PasswordHash);
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}
