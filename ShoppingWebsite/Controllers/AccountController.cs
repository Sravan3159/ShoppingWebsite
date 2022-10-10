using ShoppingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShoppingWebsite.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        ShoppingEntities db = new ShoppingEntities();

        // GET: Account
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            bool isvalid = db.Users.Any(x => x.username == user.username && x.password == user.password);
            if(isvalid)
            {
                FormsAuthentication.SetAuthCookie(user.username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username and password");
                return View();

            }
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Login");

        }
    }
}