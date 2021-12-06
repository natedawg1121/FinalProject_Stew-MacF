using FinalProject_Stew_MacF.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FinalProject_Stew_MacF.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Route("api/group-information")]
    public class GroupInformationController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            return View(db.GroupInformation.ToList());
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupInformation groupInformation = db.GroupInformation.Find(Id);
            if (groupInformation == null)
            {
                return HttpNotFound();
            }
            return View(groupInformation);
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View(new GroupInformation());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GroupInformation groupInformation)
        {
            if (ModelState.IsValid)
            {
                db.GroupInformation.Add(groupInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groupInformation);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupInformation groupInformation = db.GroupInformation.Find(Id);
            if (groupInformation == null)
            {
                return HttpNotFound();
            }
            return View(groupInformation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GroupInformation groupInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groupInformation).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View(groupInformation);
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupInformation groupInformation = db.GroupInformation.Find(Id);
            if (groupInformation == null)
            {
                return HttpNotFound();
            }
            return View(groupInformation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            GroupInformation groupInformation = db.GroupInformation.Find(Id);
            db.GroupInformation.Remove(groupInformation);
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
