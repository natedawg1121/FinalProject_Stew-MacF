using FinalProject_Stew_MacF.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FinalProject_Stew_MacF.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Route("api/group-school")]
    public class GroupSchoolController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            return View(db.GroupSchool.ToList());
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupSchool groupSchool = db.GroupSchool.Find(Id);
            if (groupSchool == null)
            {
                return HttpNotFound();
            }
            return View(groupSchool);
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View(new GroupSchool());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GroupSchool groupSchool)
        {
            if (ModelState.IsValid)
            {
                db.GroupSchool.Add(groupSchool);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groupSchool);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupSchool groupSchool = db.GroupSchool.Find(Id);
            if (groupSchool == null)
            {
                return HttpNotFound();
            }
            return View(groupSchool);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GroupSchool groupSchool)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groupSchool).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View(groupSchool);
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupSchool groupSchool = db.GroupSchool.Find(Id);
            if (groupSchool == null)
            {
                return HttpNotFound();
            }
            return View(groupSchool);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            GroupSchool groupSchool = db.GroupSchool.Find(Id);
            db.GroupSchool.Remove(groupSchool);
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
