using FinalProject_Stew_MacF.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FinalProject_Stew_MacF.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Route("api/group-food")]
    public class GroupFoodController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            return View(db.GroupFood.ToList());
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupFood groupFood = db.GroupFood.Find(Id);
            if (groupFood == null)
            {
                return HttpNotFound();
            }
            return View(groupFood);
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View(new GroupFood());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GroupFood groupFood)
        {
            if (ModelState.IsValid)
            {
                db.GroupFood.Add(groupFood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groupFood);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupFood groupFood = db.GroupFood.Find(Id);
            if (groupFood == null)
            {
                return HttpNotFound();
            }
            return View(groupFood);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GroupFood groupFood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groupFood).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View(groupFood);
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupFood groupFood = db.GroupFood.Find(Id);
            if (groupFood == null)
            {
                return HttpNotFound();
            }
            return View(groupFood);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            GroupFood groupFood = db.GroupFood.Find(Id);
            db.GroupFood.Remove(groupFood);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
