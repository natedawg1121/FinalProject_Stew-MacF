using FinalProject_Stew_MacF.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FinalProject_Stew_MacF.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Route("api/group-hobby")]
    public class GroupHobbyController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            return View(db.GroupHobby.ToList());
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupHobby groupHobby = db.GroupHobby.Find(Id);
            if (groupHobby == null)
            {
                return HttpNotFound();
            }
            return View(groupHobby);
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View(new GroupHobby());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GroupHobby groupHobby)
        {
            if (ModelState.IsValid)
            {
                db.GroupHobby.Add(groupHobby);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groupHobby);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupHobby groupHobby = db.GroupHobby.Find(Id);
            if (groupHobby == null)
            {
                return HttpNotFound();
            }
            return View(groupHobby);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GroupHobby groupHobby)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groupHobby).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View(groupHobby);
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GroupHobby groupHobby = db.GroupHobby.Find(Id);
            if (groupHobby == null)
            {
                return HttpNotFound();
            }
            return View(groupHobby);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            GroupHobby groupHobby = db.GroupHobby.Find(Id);
            db.GroupHobby.Remove(groupHobby);
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
