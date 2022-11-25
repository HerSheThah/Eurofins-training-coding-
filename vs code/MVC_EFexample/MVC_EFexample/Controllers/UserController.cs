using Microsoft.AspNetCore.Mvc;
using MVC_EFexample.Models;

namespace MVC_EFexample.Controllers
{
    public class UserController : Controller
    {
        private readonly companyContext db;
        private readonly ISession session;

        public UserController(companyContext _db, IHttpContextAccessor httpContextAccessor)
        {
            this.db = _db;
            session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Userlogin user)
        {
            var result = (from i in db.Userlogins 
                          where i.Username == user.Username && i.Password == user.Password 
                          select i).SingleOrDefault();
            if(result != null)
            {
                HttpContext.Session.SetString("username", user.Username);
                return RedirectToAction("Index","company");
            }
            else
            {
                return View();
            }
        }
        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register(Userlogin newuser)
        {
            if (ModelState.IsValid)
            {
                db.Userlogins.Add(newuser);
                db.SaveChanges();
                return RedirectToAction("login");
            }
            else {
            return View();

            }
        }

        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
    }
}
