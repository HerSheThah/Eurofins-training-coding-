using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EFexample.Models;

namespace MVC_EFexample.Controllers
{
    public class CompanyController : Controller
    {
        private companyContext db;
        public CompanyController(companyContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            if(ViewBag.username != null)
            {
                var res = db.EmployeeTables.Include(x => x.Dept);
                return View(res.ToList());
            }
            else
            {
                return RedirectToAction("login", "user");
            }
         
        }
        public IActionResult Create()
        {
            var result = db.DepartmentTables.ToList();
            ViewBag.Deptid = new SelectList(result, "Deptid", "Deptname");

            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeTable e)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeTables.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.username = HttpContext.Session.GetString("username");
                if(ViewBag.username != null)
            {
                EmployeeTable e = db.EmployeeTables.Find(id);
                var result = db.DepartmentTables.ToList();
                ViewBag.Deptid = new SelectList(result, "Deptid", "Deptname");
                return View(e);
            }
            else
            {
                return RedirectToAction("login", "user");

            }


        }

        [HttpPost]
        public IActionResult Edit(EmployeeTable e)
        {
            db.EmployeeTables.Update(e);

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            if (ViewBag.username != null)
            {
                var result = db.EmployeeTables.Include(x => x.Dept);
                EmployeeTable e = result.Where(x => x.Empid == id).Select(x => x).SingleOrDefault();
                return View(e);
            }
            else
            {
                return RedirectToAction("login", "user");
            }
            
        }

        public IActionResult Delete(int id)
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            if (ViewBag.username != null)
            {
                var result = db.EmployeeTables.Include(x => x.Dept);
            EmployeeTable e = result.Where(x => x.Empid == id).Select(x => x).SingleOrDefault();
            return View(e);
            }
            else
            {
                return RedirectToAction("login", "user");
            }

        }

        [HttpPost]
        [ActionName("Delete")]

        public IActionResult DeleteConfirmed(int id)
        {
            EmployeeTable e = db.EmployeeTables.Find(id);
            db.EmployeeTables.Remove(e);
            db.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}
