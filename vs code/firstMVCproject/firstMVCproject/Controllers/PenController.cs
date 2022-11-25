using Microsoft.AspNetCore.Mvc;
using firstMVCproject.Models;

namespace firstMVCproject.Controllers
{
    public class PenController : Controller
    {
        public static Pens p = new Pens();

        public static List<Pens> PensList = Pens.getPens();


        public  IActionResult Pendetails()
        {
            return View(PensList);
        }

        public IActionResult AddPen()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPen(Pens p)
        {
            PensList.Add(p);
            return RedirectToAction("pendetails");
        }

        public IActionResult Edit(int id)
        {
            HttpContext.Session.SetInt32("pid", id);

            p = PensList.Where(x=>x.Id==id).SingleOrDefault();
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(Pens p)
        {
            int id= (int)HttpContext.Session.GetInt32("pid");
            Pens oldPen = PensList.Where(x=>x.Id==id).SingleOrDefault();
            oldPen.Name = p.Name;
            oldPen.Price = p.Price;
            return RedirectToAction("penDetails");

        }
        public IActionResult Details(int id)
        {
            p = PensList.Where(x => x.Id == id).SingleOrDefault();
            return View(p);
        }
        public IActionResult Delete(int id)
        {
            p = PensList.Where(x => x.Id == id).SingleOrDefault();
            return View(p);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            p = PensList.Where(x => x.Id == id).SingleOrDefault();
            PensList.Remove(p);
            return RedirectToAction("pendetails");
        }
    }
}
