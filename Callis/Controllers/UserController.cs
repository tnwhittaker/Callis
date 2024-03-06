﻿using Callis.Data;
using Callis.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Callis.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext dbContext) {
            _db = dbContext;
        
        }

        [Route("/User/Login", Name = "login")]
        public IActionResult Login()
        {
            return View();
        }
        
        [Route("/User/SignUp", Name = "signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/User/LoginUser", Name = "loginuser")]
        public IActionResult LoginUser(User obj)
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/User/CreateUser",Name ="newuser")]
        public IActionResult CreateUser(User obj)
        {
            try
            {
                obj.AccountTypeId = 2;
                obj.TaskNo = 0;
                var passwordHasher = new PasswordHasher<User>();
                obj.PasswordHash = passwordHasher.HashPassword(obj, obj.PasswordHash);
                _db.Add(obj);
                _db.SaveChanges();
                ViewBag.Message = "Account created successully";
                ViewBag.Success = true;
                ViewBag.Image = "~/images/372103860_CHECK_MARK_400px.gif";
            }
            catch (DbUpdateException)
            {
                
                ViewBag.Message = "Account creation failed";
                ViewBag.Success = false;
                ViewBag.Image = "~/images/372103860_CHECK_MARK_400px.gif";
                throw;
            }
            
            return View("SignUp");
        }

    }
}
